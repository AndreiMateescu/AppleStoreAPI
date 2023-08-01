using Subscriptions.Models;

namespace Subscriptions.Interfaces;


//------------------------------------------------------------------------------
// ISubscriptionService
//------------------------------------------------------------------------------

public interface ISubscriptionService
{
    //------------------------------------------------------------------------------
    // Update
    //------------------------------------------------------------------------------

    void Update(NotificationV2 decodedPayload, RenewalInfoV2? renewalInfo, TransactionInfoV2? transactionInfo);
}