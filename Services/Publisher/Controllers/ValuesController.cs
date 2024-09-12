using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBus.Messages.Events;
using MassTransit;
using Publisher.Dtos;

namespace Publisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        public ValuesController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        [HttpPost]
        public async Task<IActionResult> PublishMessage([FromBody] PublisherDto sampleDto)
        {
            await _publishEndpoint.Publish(new PublishEvent
            {
                Id = sampleDto.Id,
                Name = sampleDto.Name
            });
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new PublisherDto
            {
                Id = 1,
                Name = "Test"
            });
        }
    }
}
