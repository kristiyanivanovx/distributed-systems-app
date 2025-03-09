using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.Data.Contexts;
using FM.Services.Interfaces;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Responses;
using FM.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using FM.Data.Entities;


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
        public async Task<GetAthleteResponse> GetAthleteAsync(GetAthleteRequest request)
        {
            GetAthleteResponse response = new() { Athletes = new() };

            var athletes = await _context.Athletes.ToListAsync();
            if (athletes is null)
            {
                return response;
            }

            foreach (var athlete in athletes)
            {
                response.Athletes.Add(new()
                {
                    FirstName = athlete.FirstName,
                    LastName = athlete.LastName,
                    Nationality = athlete.Nationality,
                    //Team = athlete.Team
                });
            }

            return response;
        }

        /// <inheritdoc/>
        public async Task<GetByNameResponse> GetByNameAsync(GetAthleteRequest request)
        {
            GetByNameResponse response = new();

            var athlete = await _context.Athletes.SingleOrDefaultAsync(x => x.FirstName == request.Name || x.LastName == request.Name);
            if (athlete is null)
            {
                response.StatusCode = Messaging.BusinessStatusCodeEnum.MissingObject;
                return response;
            }

            response.Athlete = new()
            {
                FirstName = athlete.FirstName,
                LastName = athlete.LastName,
                Nationality = athlete.Nationality,
                //Team = athlete.Team
            };

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
            }
            catch (Exception ex)
            {
                response.StatusCode = Messaging.BusinessStatusCodeEnum.InternalServerError;
                return response;
            }


            return response;
        }
    }
}
