using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Parameters;
using Subscriptions.Interfaces;

namespace Subscriptions.Services;


//------------------------------------------------------------------------------
// AppleStoreTokenService
//------------------------------------------------------------------------------

public class AppleStoreTokenService : IAppleStoreTokenService
{
    private readonly IConfiguration _configuration;


    //------------------------------------------------------------------------------
    // AppleStoreTokenService
    //------------------------------------------------------------------------------

    public AppleStoreTokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }


    //------------------------------------------------------------------------------
    // GetToken
    //------------------------------------------------------------------------------

    public string GetToken()
    {
        var dsa = GetECDsa();
        return CreateJwt(dsa);
    }


    //------------------------------------------------------------------------------
    // GetECDsa
    //------------------------------------------------------------------------------

    private ECDsa GetECDsa()
    {
        using (TextReader reader = System.IO.File.OpenText(_configuration["PRIVATE_KEY_FILE"] ?? string.Empty))
        {
            var ecPrivateKeyParameters = (ECPrivateKeyParameters)new Org.BouncyCastle.OpenSsl.PemReader(reader).ReadObject();
            var x = ecPrivateKeyParameters.Parameters.G.AffineXCoord.GetEncoded();
            var y = ecPrivateKeyParameters.Parameters.G.AffineYCoord.GetEncoded();
            var d = ecPrivateKeyParameters.D.ToByteArrayUnsigned();

            // Convert the BouncyCastle key to a Native Key.
            var msEcp = new ECParameters {Curve = ECCurve.NamedCurves.nistP256, Q = {X = x, Y = y}, D = d};
            return ECDsa.Create(msEcp);
        }
    }


    //------------------------------------------------------------------------------
    // CreateJwt
    //------------------------------------------------------------------------------

    private string CreateJwt(ECDsa key)
    {
        var securityKey = new ECDsaSecurityKey(key) { KeyId = _configuration["KEY_ID"] };
        var credentials = new SigningCredentials(securityKey, "ES256");

        var now = DateTime.Now;
        var expires = DateTime.Now.AddMinutes(15);

        long nowSeconds = (long)(now - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
        long expireSeconds = (long)(expires - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;

        var payload = new Dictionary<string, object>
        {
            { "iss", _configuration["ISSUER_ID"] ?? string.Empty },
            { "aud", "appstoreconnect-v1" },
            { "iat", nowSeconds },
            { "exp", expireSeconds },
            { "bid", _configuration["BUNDLE_ID"] ?? string.Empty }
        };

        var descriptor = new SecurityTokenDescriptor
        {
            IssuedAt = now,
            Expires = expires,
            Issuer = _configuration["ISSUER_ID"],
            SigningCredentials = credentials,
            Claims = payload
        };

        var handler = new JwtSecurityTokenHandler();
        var encodedToken = handler.CreateEncodedJwt(descriptor);
        return encodedToken;
    }
}
