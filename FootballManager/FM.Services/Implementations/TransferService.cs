using FM.Data.Contexts;
using FM.Services.Interfaces;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Implementations
{
	/// <inheritdoc/>
	public class TransferService : ITransferService
	{
		private readonly FootballManagerDbContext _context;

		/// <summary>
		/// Initializes a new instance of the <see cref="TransferService"/> class.
		/// </summary>
		/// <param name="context">FootballManager database context.</param>
		public TransferService(FootballManagerDbContext context)
		{
			_context = context;
		}

		/// <inheritdoc/>
		public async Task<GetAllTransfersResponse> GetAllTransfersAsync(GetAllTransfersRequest request)
		{
			GetAllTransfersResponse response = new() { Transfers = new() };

			var transfers = await _context.Transfers
				.Include("Athlete")
				.Include("NewTeam")
				.Include("OldTeam")
				.Where(x => x.IsActive).ToListAsync();
			if (transfers is null)
			{
				return response;
			}

			foreach (var transfer in transfers)
			{
				response.Transfers.Add(new()
				{
					Id = transfer.Id,
					NewTeamName = transfer.NewTeam.Name,
					OldTeamName = transfer.OldTeam.Name,
					AthleteName = $"{transfer.Athlete.FirstName} {transfer.Athlete.LastName}",
					TransferValue = transfer.TransferValue
				});
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<GetByIdResponse> GetByIdAsync(GetByIdRequest request)
		{
			GetByIdResponse response = new();

			var transfer = await _context.Transfers
				.Include("Athlete")
				.Include("NewTeam")
				.Include("OldTeam")
				.Where(x => x.IsActive)
				.SingleOrDefaultAsync(x => x.Id == request.Id);

			if (transfer is null)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			response.Transfer = new()
			{
				Id = transfer.Id,
				NewTeamName = transfer.NewTeam.Name,
				OldTeamName = transfer.OldTeam.Name,
				AthleteName = $"{transfer.Athlete.FirstName} {transfer.Athlete.LastName}",
			};

			response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			return response;
		}

		/// <inheritdoc/>
		public async Task<CreateTransferResponse> CreateTransferAsync(CreateTransferRequest request)
		{
			CreateTransferResponse response = new();

			try
			{
				await _context.Transfers.AddAsync(new()
				{
					AthleteId = request.Transfer.AthleteId,
					NewTeamId = request.Transfer.NewTeamId,
					OldTeamId = request.Transfer.OldTeamId,
					TransferValue = request.Transfer.TransferValue
				});

				await _context.SaveChangesAsync();

				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;

			}
			catch (Exception ex)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
				return response;
			}

			return response;
		}

		/// <inheritdoc/>
		public async Task<DeleteTransferResponse> SoftDeleteTransferAsync(DeleteTransferRequest request)
		{
			DeleteTransferResponse response = new();

			var transfer = await _context.Transfers.SingleOrDefaultAsync(x => x.Id == request.Id && x.IsActive);

			if (transfer is null)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
				return response;
			}

			try
			{
				transfer.IsActive = false;

				_context.Transfers.Update(transfer);

				await _context.SaveChangesAsync();

				response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
			}
			catch (Exception)
			{
				response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
			}

			return response;
		}
	}
}