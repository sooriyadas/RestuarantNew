using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ServiceBridge.Interfaces
{
    interface IItemServiceManagement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<Items> GetAllItemsSOAP();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<Items> GetAllItemsRest();



        bool CreateCheckSOAP(CheckSummary check);

        bool CreateCheckRest(CheckSummary check);

        string GetCheckNoSOAP();
    }
}
