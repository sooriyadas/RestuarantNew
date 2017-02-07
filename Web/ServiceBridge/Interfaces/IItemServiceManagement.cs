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
        IList<Items> GetAllItems();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<Items> GetAllItemsRest();

        bool CreateCheck(CheckSummary check);
    }
}
