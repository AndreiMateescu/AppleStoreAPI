using Newtonsoft.Json;

namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// RenewalInfoV2
//------------------------------------------------------------------------------

public class RenewalInfoV2
{
    [JsonProperty("autoRenewProductId")]
    public string AutoRenewProductId { get; set; } = string.Empty;

    [JsonProperty("autoRenewStatus")]
    public AutoRenewStatus AutoRenewStatus { get; set; }

    [JsonProperty("expirationIntent")]
    public ExpirationIntent ExpirationIntent { get; set; }

    [JsonProperty("gracePeriodExpiresDate")]
    public long GracePeriodExpiresDate { get; set; }

    [JsonProperty("isInBillingRetryPeriod")]
    public bool IsInBillingRetryPeriod { get; set; }

    [JsonProperty("offerIdentifier")]
    public string OfferIdentifier { get; set; } = string.Empty;

    [JsonProperty("offerType")]
    public OfferType OfferType { get; set; }

    [JsonProperty("originalTransactionId")]
    public string OriginalTransactionId { get; set; } = string.Empty;

    [JsonProperty("priceIncreaseStatus")]
    public PriceConsent PriceIncreaseStatus { get; set; }

    [JsonProperty("productId")]
    public string ProductId { get; set; } = string.Empty;

    [JsonProperty("signedDate")]
    public long SignatureDate { get; set; }
}