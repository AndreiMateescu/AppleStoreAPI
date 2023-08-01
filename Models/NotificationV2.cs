using Newtonsoft.Json;

namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// NotificationV2
//------------------------------------------------------------------------------

public class NotificationV2
{
    [JsonProperty("notificationType")]
    public NotificationType NotificationType { get; set; }

    [JsonProperty("subtype")]
    public NotificationSubtype Subtype { get; set; }

    [JsonProperty("notificationUUID")]
    public string NotificationUUID { get; set; } = string.Empty;

    [JsonProperty("notificationVersion")]
    public string NotificationVersion { get; set; } = string.Empty;

    [JsonProperty("data")]
    public NotificationV2Data? Data { get; set; }
}