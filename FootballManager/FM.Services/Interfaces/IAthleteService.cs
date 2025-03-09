using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;

namespace FM.Services.Interfaces
{
	public interface IAthleteService
	{
		/// <summary>
		/// Get list with athletes.
		/// </summary>
		/// <param name="request">Get athlete request object.</param>
		/// <returns>Return list with athletes.</returns>
		Task<GetAllAthletesResponse> GetAllAthletesAsync(GetAllAthletesRequest request);

		/// <summary>
		/// Get athlete by name.
		/// </summary>
		/// <param name="request">Get name by request object.</param>
		/// <returns>Return single athete by name.</returns>
		Task<GetByNameResponse> GetByNameAsync(GetByNameRequest request);


    /// <summary>
    /// Create athlete.
    /// </summary>
    /// <param name="request">Create athlete request object.</param>
    /// <returns>Return 200 ok.</returns>
    Task<CreateAthleteResponse> SaveAsync(CreateAthleteRequest request);

    /// <summary>
    /// Update an athlete.
    /// </summary>
    /// <param name="id">Id of athlete object to update.</param>
    /// <param name="request">Update athlete request object.</param>
    /// <returns>Return 200 ok.</returns>
    Task<UpdateAthleteResponse> UpdateAthleteAsync(int id, UpdateAthleteRequest request);
  }
}
