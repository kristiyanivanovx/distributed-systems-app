namespace FM.Services.Messaging.Requests;
public class TransferCreateModel
{
	public int AthleteId { get; set; }

	public int NewTeamId { get; set; }

	public int OldTeamId { get; set; }
	public decimal TransferValue { get; set; }
}
