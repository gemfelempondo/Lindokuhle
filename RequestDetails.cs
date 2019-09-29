using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class RequestDetails
    {
        [Key]
        public int RecordId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Total_due { get; set; }
        public double Price { get; set; }
        public double Install { get; set; }
        public double Calc_Install()
        {
            return (Price / 100 * 25);
        }
        public double Calc_due()
        {
            return (Calc_Install() +( Price * Quantity));
        }
    }
}