using System.Collections.Generic;

namespace Detrack
{
    public class Delivery
    {
        public Delivery()
        {
            Items = new List<DeliveryItem>();
        }

        /// <summary>
        /// format: yyyy-MM-dd
        /// </summary>
        public string Date { get; set; }

        public string Address { get; set; }

        public string DeliverTo { get; set; }

        public string Do { get; set; }

        public IList<DeliveryItem> Items { get; set; }

        public string AssignTo { get; set; }

        public string AddrCompany { get; set; }

        public string InvoiceNo { get; set; }

        public string Customer { get; set; }

        public string OrderNo { get; set; }

        public string SalesPerson { get; set; }

        public string Instructions { get; set; }
    }
}
