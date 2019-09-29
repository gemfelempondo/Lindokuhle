using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class RequestVM
    {
        [Key]
        public int RId { get; set; }

        public string User { get; set; }

        public int RequestId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public byte[] Image { get; set; }

        public decimal Price { get; set; }

        public decimal TotalRequestCost { get; set; }

        public string DeliveryAddress { get; set; }

        public string RequestDate { get; set; }

        public int Quantity { get; set; }

        public string Status { get; set; }
        public decimal Install { get; set; }
        public decimal Calc_Install()
        {
            return (Price / 100 * 25);
        }
        public decimal Calc_due()
        {
            return (Calc_Install() + (Price * Quantity));
        }
    }
}
