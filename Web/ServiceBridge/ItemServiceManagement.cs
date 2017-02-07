using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;
using Web.ItemService;
using Web.ServiceBridge.Interfaces;

using System.Net;
using Newtonsoft.Json;

namespace Web.ServiceBridge
{
    public class ItemServiceManagement : IItemServiceManagement
    {
        ItemServiceClient service = new ItemServiceClient();
        //  RestuarantServiceClient restservice = new RestuarantServiceClient();
        public IList<Items> GetAllItems()
        {
            var list = service.GetAllItems();


            IList<Items> menuitems = new List<Items>();
            foreach (var item in list)
            {
                Items itm = new Items();
                itm.Id = item.Id;
                itm.ItemName = item.ItemName;
                itm.Price = (float)item.Price;
                itm.Description = item.Description;
                itm.Category = item.Category;
                itm.Qty = 1;
                menuitems.Add(itm);

            }
            return menuitems;
        }
        readonly string customerServiceUri = "http://localhost:5028/RestuarantService.svc/";
        //<summary>
        //Rest service
        //</summary>
        //<returns></returns>
        public IList<Items> GetAllItemsRest()
        {

            IList<Items> menuitems = new List<Items>();
            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(customerServiceUri + "Items");
                menuitems = JsonConvert.DeserializeObjectAsync<List<Items>>(dwml).Result;
            }

            //IList<Items> menuitems = new List<Items>();
            //foreach (var item in list)
            //{
            //    Items itm = new Items();
            //    itm.Id = item.Id;
            //    itm.ItemName = item.ItemName;
            //    itm.Price = (float)item.Price;
            //    itm.Description = item.Description;
            //    itm.Category = item.Category;
            //    menuitems.Add(itm);

            //}
            return menuitems;
        }

        public bool CreateCheck(CheckSummary check)
        {
          bool msg = service.CreateCheck(ConvertTo(check));
            return true;
        }


        private static CheckSumry ConvertTo(CheckSummary Data)
        {
            CheckSumry chksummry = new CheckSumry();
            chksummry.CheckNo = Data.CheckNo;
            chksummry.CreateDate = Data.CreateDate;
            chksummry.Total = Data.Total;

            IList<CheckDet> checkdet = new List<CheckDet>();
            foreach (var item in Data.CheckDetails)
            {
                CheckDet itm = new CheckDet();
                itm.ItemId = item.ItemId;
                itm.ItemName = item.ItemName;
                itm.Total = item.Total;
                itm.Qty = item.Qty;
                checkdet.Add(itm);

            }
            chksummry.CheckDetails = checkdet.Cast<CheckDet>().ToArray();
            return chksummry;
        }
    }
}