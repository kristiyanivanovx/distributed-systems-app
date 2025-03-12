namespace FM.Services.Messaging.Responses;
public class TransferViewModel
{
	public int Id { get; set; }
	public string AthleteName { get; set; }
	public string OldTeamName { get; set; }
	public string NewTeamName { get; set; }
	public decimal TransferValue { get; set; }
}
