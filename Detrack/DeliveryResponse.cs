using System.Collections.Generic;

namespace Detrack
{
    public class DeliveryResponse
    {
        public DeliveryInfo Info { get; set; }

        public IEnumerable<DeliveryResult> Results { get; set; }
    }
}
