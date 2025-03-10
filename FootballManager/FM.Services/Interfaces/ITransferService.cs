using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;

namespace FM.Services.Interfaces
{
	public interface ITransferService
	{
		/// <summary>
		/// Get list of transfers.
		/// </summary>
		/// <param name="request">Get transfer request object.</param>
		/// <returns>Return list of transfers.</returns>
		Task<GetAllTransfersResponse> GetAllTransfersAsync(GetAllTransfersRequest request);

		/// <summary>
		/// Get transfer by id.
		/// </summary>
		/// <param name="request">Get id by request object.</param>
		/// <returns>Return single transfer by id.</returns>
		Task<GetByIdResponse> GetByIdAsync(GetByIdRequest request);


		/// <summary>
		/// Create transfer.
		/// </summary>
		/// <param name="request">Create transfer request object.</param>
		/// <returns>Return 200 ok.</returns>
		Task<CreateTransferResponse> SaveAsync(CreateTransferRequest request);

		/// <summary>
		/// Delete an transfer.
		/// </summary>
		/// <param name="id">Id of transfer object to delete.</param>
		/// <returns>Return 200 ok.</returns>
		Task<DeleteTransferResponse> SoftDeleteTransferAsync(DeleteTransferRequest request);
	}
}
