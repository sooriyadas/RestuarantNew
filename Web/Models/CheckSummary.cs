using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CheckSummary
    {

        public int Id { get; set; }
        public string CheckNo { get; set; }
        public DateTime CreateDate { get; set; }
        public double Total { get; set; }
        public IList<CheckDetail> CheckDetails { get; set; }
    }
}