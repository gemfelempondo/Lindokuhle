using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class TrackRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TID { get; set; }


        public int RequestId { get; set; }
        public virtual Request RequestNumber { get; set; }

        [Required(ErrorMessage = "Provide When to install Date!")]
        [Display(Name = "Request Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime captured { get; set; }
        [Required(ErrorMessage = "Provide Status!")]
        [Display(Name = "Status")]
        public RequestStat status { get; set; }
        public TrackRequest()
        {
            captured = DateTime.Now;
            status = RequestStat.OnOurWarehouse;
        }
    }

    public enum RequestStat
    {
        pending,
        OnOurWarehouse,
        OnItsWay,
        Delivered,
        Cancelled
    }
}
