namespace FM.Services.Messaging.Requests
{
	public class GetByNameRequest : ServiceRequestBase
	{
		public string Name { get; set; }

		public GetByNameRequest(string name)
		{
			Name = name;
		}
	}
}
