namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// Notification used for Database
//------------------------------------------------------------------------------

public class Notification
{
    public Guid Id { get; set; }
    public string NotificationType { get; set; } = string.Empty;
    public string Subtype { get; set; } = string.Empty;
    public string NotificationUUID { get; set; } = string.Empty;
    public string NotificationVersion { get; set; } = string.Empty;
    public string BundleId { get; set; } = string.Empty;
}