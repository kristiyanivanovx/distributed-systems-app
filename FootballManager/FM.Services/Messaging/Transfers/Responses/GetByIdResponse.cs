namespace FM.Services.Messaging.Responses;
public class GetByIdResponse : ServiceResponseBase
{
	public TransferViewModel? Transfer { get; set; }
}
