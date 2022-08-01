using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBus.Messages.Events;
using MassTransit;
using Microsoft.Extensions.Logging;

namespace Subscriber.EventBusConsumer
{
    public class SampleConsumer : IConsumer<PublishEvent>
    {
        private readonly ILogger<SampleConsumer> _logger;

        public SampleConsumer( ILogger<SampleConsumer> logger)
        {
            _logger = logger;
        }
        public async Task Consume(ConsumeContext<PublishEvent> context)
        {
            var message = context.Message;
            //Message consumed. Do whatever you want with this message
            _logger.LogInformation("Message consumed successfully. Incoming message Id : {Id}, Name : {Name}", message.Id, message.Name);
        }
    }
}
