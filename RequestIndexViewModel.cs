using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class RequestIndexViewModel
    {
        public List<TrackRequest> Pending { get; set; }
        public List<TrackRequest> OnOurWarehouse { get; set; }
        public List<TrackRequest> OnItsWay { get; set; }
        public List<TrackRequest> Delivered { get; set; }
        public List<TrackRequest> CancelledOrders { get; set; }
        public List<TrackRequest> Requests { get; set; }
    }
}