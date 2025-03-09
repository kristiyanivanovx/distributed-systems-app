﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// <returns>Return filter list with athletes.</returns>
        Task<GetAthleteResponse> GetAthleteAsync(GetAthleteRequest request);

        /// <summary>
        /// Get athlete by name.
        /// </summary>
        /// <param name="request">Get name by request object.</param>
        /// <returns>Return single athete by name.</returns>
        Task<GetByNameResponse> GetByNameAsync(GetAthleteRequest request);

        /// <summary>
        /// Create athlete.
        /// </summary>
        /// <param name="request">Create athlete request object.</param>
        /// <returns>Return 200 ok.</returns>
        Task<CreateAthleteResponse> SaveAsync(CreateAthleteRequest request);
    }
}
