namespace FM.Services.Messaging.Responses;
public class GetAllTransfersResponse : ServiceResponseBase
{
	public List<TransferViewModel> Transfers { get; set; }
}
