using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aggregator.Models;
using Aggregator.Services;

namespace Aggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IPublisherService _publisherService;
        private readonly ISubscriberService _subscriberService;

        public ValuesController(IPublisherService publisherService, ISubscriberService subscriberService)
        {
            _publisherService = publisherService;
            _subscriberService = subscriberService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var publisherModel = await _publisherService.GetPublisherModel();
            var subscriberModel = await _subscriberService.GetSubscriberModel();

            return Ok(new MergedModel
            {
                Id = 1,
                SubscriberModel = subscriberModel,
                PublisherModel = publisherModel
            });
            
        }
    }
}
