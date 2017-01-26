using System;
using System.Collections.Generic;

namespace Detrack
{
    public class DeliveryResult
    {
        public DateTime Date { get; set; }

        public string Do { get; set; }

        public string Status { get; set; }

        public IEnumerable<DeliveryResultError> Errors { get; set; }
    }
}
