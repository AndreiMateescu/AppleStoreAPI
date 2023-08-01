using Subscriptions.Interfaces;
using Subscriptions.Models;

namespace Subscriptions.Services;


//------------------------------------------------------------------------------
// SubscriptionService
//------------------------------------------------------------------------------

public class SubscriptionService : ISubscriptionService
{
    private readonly INotificationRepository _notificationRepository;
    public SubscriptionService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    //------------------------------------------------------------------------------
    // Update
    //------------------------------------------------------------------------------

    public void Update(NotificationV2 decodedPayload, RenewalInfoV2? renewalInfo, TransactionInfoV2? transactionInfo)
    {
        Notification notification = new Notification
        {
            NotificationType = decodedPayload.NotificationType.ToString(),
            Subtype = decodedPayload.Subtype.ToString(),
            NotificationUUID = decodedPayload.NotificationUUID,
            NotificationVersion = decodedPayload.NotificationVersion
        };
        if (decodedPayload.Data != null)
        {
            notification.BundleId = decodedPayload.Data.BundleId;
        }

        // update in database
        _notificationRepository.AddNotification(notification);
    }
}