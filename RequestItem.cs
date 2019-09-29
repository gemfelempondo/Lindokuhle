using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class RequestItem
    {

        [Key]

        public int RequestItemId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int ProductId { get; set; }

        public virtual InventoryProduct Product { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int RequestProg { get; set; }
        public RequestItem()
        {

        }
    }
}