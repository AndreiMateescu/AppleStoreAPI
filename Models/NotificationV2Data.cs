using Newtonsoft.Json;

namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// NotificationV2Data
//------------------------------------------------------------------------------

public class NotificationV2Data
{
    [JsonProperty("appAppleId")]
    public string AppAppleId { get; set; } = string.Empty;
    
    [JsonProperty("bundleId")]
    public string BundleId { get; set; } = string.Empty;
    
    [JsonProperty("bundleVersion")]
    public string BundleVersion { get; set; } = string.Empty;
    
    [JsonProperty("environment")]
    public EnvironmentName Environment { get; set; }
    
    [JsonProperty("signedRenewalInfo")]
    public string SignedRenewalInfo { get; set; } = string.Empty;
    
    [JsonProperty("signedTransactionInfo")]
    public string SignedTransactionInfo { get; set; } = string.Empty;
}