using Subscriptions.Models;

namespace Subscriptions.Interfaces;

public interface INotificationRepository
{
    Task<IList<Notification>> GetNotifications();
    void AddNotification(Notification notification);
}