using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CheckDetail
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double Total { get; set; }
        public int CheckId { get; set; }
        public int Qty { get; set; }
    }
}