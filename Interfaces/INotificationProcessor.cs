using Subscriptions.Models;

namespace Subscriptions.Interfaces;


//------------------------------------------------------------------------------
// INotificationProcessor
//------------------------------------------------------------------------------

public interface INotificationProcessor
{
    //------------------------------------------------------------------------------
    // Process
    //------------------------------------------------------------------------------

    void Process(AppleNotification notification);
}