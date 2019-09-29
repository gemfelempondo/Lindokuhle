using GateBoys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class Request
    {
        public Request()
        {
            this.RequestDate = DateTime.Now;
            this.RequestProgress = 1;


        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Total_due { get; set; }
        public decimal Price { get; set; }
        public decimal Install { get; set; }
        public int RequestProgress { get; set; }
        public DateTime RequestDate { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string RequestNumber { get;set; }
        public decimal TotalRequestCost { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string RequestedItems { get; set; }
        public int RequestQty { get; set; }
        [Display(Name = "Driver")]
        public string AssignedDriver { get; set; }
        public ICollection<RequestItem> RequestItems { get; set; }


        public decimal Calc_install()
        {
            return TotalRequestCost= (Price / 100 * 25);
        }
        public decimal Calc_due()
        {
            return Total_due = (Price * Quantity) + Calc_install();
        }
    }
}
public class RequestConfirmation
{
    [Key]
    public int RequestConfirmationID { get; set; }

    public string Username { get; set; }

    public string Note { get; set; }

    [Display(Name = "Request Proof")]
    public byte[] Proof { get; set; }
}
