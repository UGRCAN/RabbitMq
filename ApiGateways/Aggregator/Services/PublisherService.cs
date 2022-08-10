using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Aggregator.Extensions;
using Aggregator.Models;

namespace Aggregator.Services
{
    public class PublisherService :IPublisherService
    {
        private readonly HttpClient _client;

        public PublisherService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));

        }

        public async Task<PublisherModel> GetPublisherModel()
        {
            var response = await _client.GetAsync("/api/Values");
            return await response.ReadContentAs<PublisherModel>();

        }
    }
}
