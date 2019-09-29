using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class RequestsVM
    {
        [Key]
        public int RId { get; set; }

        public string User { get; set; }

        public int RequestId { get; set; }

        public int productId { get; set; }

        public string productName { get; set; }

        public byte[] Image { get; set; }

        public double Price { get; set; }

        public double TotalRequestCost { get; set; }

        public string DeliveryAddress { get; set; }

        public string RequestDate { get; set; }

        public int Quantity { get; set; }

        public string Status { get; set; }
        public double Install { get; set; }
        public double Calc_Install()
        {
            return (Price / 100 * 25);
        }
        public double Calc_due()
        {
            return (Calc_Install() + (Price * Quantity));
        }
    }
}