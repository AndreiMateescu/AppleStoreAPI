using Microsoft.EntityFrameworkCore;
using Subscriptions.Data;
using Subscriptions.Interfaces;
using Subscriptions.Models;

namespace Subscriptions.Services;

public class NotificationRepository : INotificationRepository
{
    private readonly DataContext _db;
    
    public NotificationRepository(DataContext db)
    {
        _db = db;
    }

    public void AddNotification(Notification notification)
    {
        _db.Add(notification);
        _db.SaveChanges(true);
    }

    public async Task<IList<Notification>> GetNotifications()
    {
        if (_db.Notifications != null)
        {
            return await _db.Notifications.ToListAsync();
        }
        return new List<Notification>();
    }
}