﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class PublishEvent :IntegrationBaseEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
