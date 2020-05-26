﻿using Rebrandly.Infrastructure.Interfaces;
using Rebrandly.Services.Base;
using Rebrandly.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rebrandly.Services.Interfaces
{
    public interface IRetrievable<TEntity, TOptions> where TEntity : IRebrandlyEntity where TOptions : BaseOptions, new()
    {
        Task<TEntity> Get(string id, TOptions retrieveOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
