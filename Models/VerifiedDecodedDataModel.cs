namespace Subscriptions.Models;


//------------------------------------------------------------------------------
// VerifiedDecodedDataModel<TdataModel>
//------------------------------------------------------------------------------

public class VerifiedDecodedDataModel<TDataModel>
{
    public TDataModel? DecodedPayload { get; set; }

    public bool IsValid { get; set; }
}