using System.Runtime.Serialization;

namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// AutoRenewStatus
//------------------------------------------------------------------------------

public enum AutoRenewStatus
{
    WillRenew = 1,
    WontRenew = 0
}


//------------------------------------------------------------------------------
// CancellationReason
//------------------------------------------------------------------------------

public enum CancellationReason
{
    CustomerUnsatisfied = 1,
    OtherReason = 0
}


//------------------------------------------------------------------------------
// EnvironmentName
//------------------------------------------------------------------------------

public enum EnvironmentName
{
    [EnumMember(Value = "Sandbox")]
    Sandbox = 0,

    [EnumMember(Value = "PROD")]
    PROD = 1
}


//------------------------------------------------------------------------------
// ExpirationIntent
//------------------------------------------------------------------------------

public enum ExpirationIntent
{
    Canceled = 1,
    BillingError = 2,
    NewPriceRefused = 3,
    NotPurchasable = 4,
    Unknown = 5
}


//------------------------------------------------------------------------------
// NotificationSubtype
//------------------------------------------------------------------------------

public enum NotificationSubtype
{
    [EnumMember(Value = "INITIAL_BUY")] INITIAL_BUY,
    
    [EnumMember(Value = "RESUBSCRIBE")] RESUBSCRIBE,
    
    [EnumMember(Value = "DOWNGRADE")] DOWNGRADE,
    
    [EnumMember(Value = "UPGRADE")] UPGRADE,
    
    [EnumMember(Value = "AUTO_RENEW_ENABLED")] AUTO_RENEW_ENABLED,
    
    [EnumMember(Value = "AUTO_RENEW_DISABLED")] AUTO_RENEW_DISABLED,
    
    [EnumMember(Value = "VOLUNTARY")] VOLUNTARY,
    
    [EnumMember(Value = "BILLING_RETRY")] BILLING_RETRY,
    
    [EnumMember(Value = "PRICE_INCREASE")] PRICE_INCREASE,
    
    [EnumMember(Value = "GRACE_PERIOD")] GRACE_PERIOD,
    
    [EnumMember(Value = "BILLING_RECOVERY")] BILLING_RECOVERY,
    
    [EnumMember(Value = "PENDING")] PENDING,
    
    [EnumMember(Value = "ACCEPTED")] ACCEPTED
}


//------------------------------------------------------------------------------
// NotificationType
//------------------------------------------------------------------------------

public enum NotificationType
{
    [EnumMember(Value = "CANCEL")] CANCEL = 1,
    
    [EnumMember(Value = "CONSUMPTION_REQUEST")] CONSUMPTION_REQUEST,
    
    [EnumMember(Value = "DID_CHANGE_RENEWAL_PREF")] DID_CHANGE_RENEWAL_PREF,
    
    [EnumMember(Value = "DID_CHANGE_RENEWAL_STATUS")] DID_CHANGE_RENEWAL_STATUS,
            
    [EnumMember(Value = "DID_FAIL_TO_RENEW")] DID_FAIL_TO_RENEW,
    
    [EnumMember(Value = "DID_RECOVER")] DID_RECOVER,
    
    [EnumMember(Value = "DID_RENEW")] DID_RENEW,
    
    [EnumMember(Value = "INITIAL_BUY")] INITIAL_BUY,
    
    [EnumMember(Value = "INTERACTIVE_RENEWAL")] INTERACTIVE_RENEWAL,
    
    [EnumMember(Value = "PRICE_INCREASE_CONSENT")] PRICE_INCREASE_CONSENT,
    
    [EnumMember(Value = "REFUND")] REFUND,
    
    [EnumMember(Value = "REVOKE")] REVOKE,

    [EnumMember(Value = "TEST")] TEST,
    
    // [Obsolete("Use 'DID_RECOVER' instead")]
    // [EnumMember(Value = "RENEWAL")] RENEWAL,
}


//------------------------------------------------------------------------------
// OfferType
//------------------------------------------------------------------------------

public enum OfferType
{
    Introductory = 0,
    Promotional = 1,
    OfferCode = 3
}


//------------------------------------------------------------------------------
// OwnershipType
//------------------------------------------------------------------------------

public enum OwnershipType
{
    [EnumMember(Value = "PURCHASED")]
    Purchased = 1,

    [EnumMember(Value = "FAMILY_SHARED")]
    FamilyShared = 2
}


//------------------------------------------------------------------------------
// PriceConsent
//------------------------------------------------------------------------------

public enum PriceConsent
{
    Unknown = 0,
    Consented = 1
}


//------------------------------------------------------------------------------
// PurchaseType
//------------------------------------------------------------------------------

public enum PurchaseType
{
    [EnumMember(Value = "Auto-Renewable Subscription")] AutoRenewSub,

    [EnumMember(Value = "Non-Consumable")] NonConsumable,

    [EnumMember(Value = "Consumable")] Consumable,

    [EnumMember(Value = "Non-Renewing Subscription")] NoRenewSub,
}