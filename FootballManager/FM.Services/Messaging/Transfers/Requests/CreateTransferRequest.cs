namespace FM.Services.Messaging.Requests;
public class CreateTransferRequest : ServiceRequestBase
{
	public TransferCreateModel Transfer { get; set; }

	public CreateTransferRequest(TransferCreateModel transfer)
	{
		Transfer = transfer;
	}
}
