using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBus.Messages.Events;
using MassTransit;

namespace Subscriber.EventBusConsumer
{
    public class SampleConsumer : IConsumer<PublishEvent>
    {
        public async Task Consume(ConsumeContext<PublishEvent> context)
        {
            var message = context.Message;
            //Message consumed. Do whatever you want with this message
        }
    }
}
