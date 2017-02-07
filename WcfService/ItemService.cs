using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ItemService : IItemService
    {
        IItemManagement service = new ItemManagement();
        public IList<MenuItem> GetAllItems()
        {
            var list = service.GetAllItems();
            return list;
        }

        public bool CreateCheck(CheckSumry check)
        {
            bool msg = service.CreateCheck(check);
            return msg;
        }
    }
}
