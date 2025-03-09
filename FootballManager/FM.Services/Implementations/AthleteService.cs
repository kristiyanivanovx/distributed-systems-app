using FM.Data.Contexts;
using FM.Services.Interfaces;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using Microsoft.EntityFrameworkCore;

namespace FM.Services.Implementations
{
    /// <inheritdoc/>
    public class AthleteService : IAthleteService
    {
        private readonly FootballManagerDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AthleteService"/> class.
        /// </summary>
        /// <param name="context">FootballManager database context.</param>
        public AthleteService(FootballManagerDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<GetAllAthletesResponse> GetAllAthletesAsync(GetAllAthletesRequest request)
        {
            GetAllAthletesResponse response = new() { Athletes = new() };

            var athletes = await _context.Athletes.ToListAsync();
            if (athletes is null)
            {
                return response;
            }

            foreach (var athlete in athletes)
            {
                response.Athletes.Add(new()
                {
                    Id = athlete.Id,
                    FirstName = athlete.FirstName,
                    LastName = athlete.LastName,
                    Nationality = athlete.Nationality,
                    //Team = athlete.Team
                });
            }

            return response;
        }

        /// <inheritdoc/>
        public async Task<GetByNameResponse> GetByNameAsync(GetByNameRequest request)
        {
            GetByNameResponse response = new();

            var athlete = await _context.Athletes
                .SingleOrDefaultAsync(x => x.FirstName == request.Name || x.LastName == request.Name);

            if (athlete is null)
            {
                response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
                return response;
            }

            response.Athlete = new()
            {
                Id = athlete.Id,
                FirstName = athlete.FirstName,
                LastName = athlete.LastName,
                Nationality = athlete.Nationality,
                //Team = athlete.Team
            };

            response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
            return response;
        }

        /// <inheritdoc/>
        public async Task<CreateAthleteResponse> SaveAsync(CreateAthleteRequest request)
        {
            CreateAthleteResponse response = new();

            try
            {
                await _context.Athletes.AddAsync(new()
                {
                    FirstName = request.Athlete.FirstName,
                    LastName = request.Athlete.LastName,
                    Nationality = request.Athlete.Nationality,
                    //Team = athlete.Team

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
        public async Task<UpdateAthleteResponse> UpdateAthleteAsync(int id, UpdateAthleteRequest request)
        {
            UpdateAthleteResponse response = new();

            var athlete = await _context.Athletes.SingleOrDefaultAsync(x => x.Id == id);

            if (athlete is null)
            {
                response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
                return response;
            }

            try
            {
                athlete.FirstName = request.Athlete?.FirstName ?? athlete.FirstName;
                athlete.LastName = request.Athlete?.LastName ?? athlete.LastName;
                athlete.Nationality = request.Athlete?.Nationality ?? athlete.Nationality;

                _context.Athletes.Update(athlete);

                await _context.SaveChangesAsync();

                response.StatusCode = Messaging.BusinessStatusCodeEnum.Success;
            }
            catch (Exception ex)
            {
                response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
            }

            return response;
        }
    }
}
