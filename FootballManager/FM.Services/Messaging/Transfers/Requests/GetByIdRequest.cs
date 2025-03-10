namespace FM.Services.Messaging.Requests;
public class GetByIdRequest : ServiceRequestBase
{
	public int Id { get; set; }

	public GetByIdRequest(int id)
	{
		Id = id;
	}
}
