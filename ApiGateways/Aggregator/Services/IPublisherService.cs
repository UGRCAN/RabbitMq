using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Aggregator.Models;

namespace Aggregator.Services
{
    public interface IPublisherService
    {
        Task<PublisherModel> GetPublisherModel();

    }
}
