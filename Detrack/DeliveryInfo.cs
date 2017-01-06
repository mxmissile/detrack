using System.Collections.Generic;

namespace Detrack
{
    public class DeliveryInfo
    {
        public string Status { get; set; }

        public int Failed { get; set; }

        public IEnumerable<DeliveryResult> Results { get; set; }
    }
}
