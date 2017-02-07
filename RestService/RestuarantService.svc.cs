﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestuarantService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestuarantService.svc or RestuarantService.svc.cs at the Solution Explorer and start debugging.
    public class RestuarantService : IRestuarantService
    {
        IItemManagement service = new ItemManagement();
        public IList<MenuItem> GetAllItems()
        {
            var list = service.GetAllItems();
            return list;
        }


    }
}
