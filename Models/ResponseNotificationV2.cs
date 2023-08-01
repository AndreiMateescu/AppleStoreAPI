namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// ResponseNotificationV2
//------------------------------------------------------------------------------

public class ResponseNotificationV2
{
    public NotificationV2? NotificationV2 { get; set; }
    public RenewalInfoV2? RenewalInfoV2 { get; set; }
    public TransactionInfoV2? TransactionInfoV2 { get; set; }
}