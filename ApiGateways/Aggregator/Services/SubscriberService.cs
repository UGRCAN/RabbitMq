using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Aggregator.Extensions;
using Aggregator.Models;

namespace Aggregator.Services
{
    public class SubscriberService : ISubscriberService
    {


        private HttpClient _client;

        public SubscriberService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
        public async Task<SubscriberModel> GetSubscriberModel()
        {
            var response = await _client.GetAsync("/api/Values");
            return await response.ReadContentAs<SubscriberModel>();
        }
    }
}
