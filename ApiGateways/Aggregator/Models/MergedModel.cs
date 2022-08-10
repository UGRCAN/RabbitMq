using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aggregator.Models
{
    public class MergedModel
    {
        public int Id { get; set; }
        public PublisherModel PublisherModel { get; set; }
        public SubscriberModel SubscriberModel { get; set; }
    }
}
