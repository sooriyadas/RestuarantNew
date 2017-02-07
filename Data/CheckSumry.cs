using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class CheckSumry
    {

        public int Id { get; set; }
        public string CheckNo { get; set; }
        public DateTime CreateDate { get; set; }
        public double Total { get; set; }
        public  IEnumerable<CheckDet> CheckDetails { get; set; }
    }
}
