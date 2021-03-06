﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

using Web.ServiceBridge.Interfaces;

using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using Web.localhost;

namespace Web.ServiceBridge
{
    public class ItemServiceManagement : IItemServiceManagement
    {
        //  ItemServiceClient service = new ItemServiceClient();
        //  RestuarantServiceClient restservice = new RestuarantServiceClient();
        WebService webservice = new WebService();


        #region SOAP service

        /// <summary>
        /// get all items using SOAP
        /// </summary>
        /// <returns></returns>
        public IList<Items> GetAllItemsSOAP()
        {
            var list = webservice.GetAllItemsSOAP();


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

        /// <summary>
        /// create check using SOAP service
        /// </summary>
        /// <param name="check"></param>
        /// <returns></returns>
        public bool CreateCheckSOAP(CheckSummary check)
        {
            bool msg = webservice.CreateCheckSOAP(ConvertTo(check));
            return true;
        }


        /// <summary>
        /// Get check No
        /// </summary>
        /// <returns></returns>
        public string GetCheckNoSOAP()
        {
            return webservice.GetCheckNoSOAP();
        }

        # endregion


        #region REST service

        readonly string customerServiceUri = "http://localhost:5028/RestuarantService.svc/";
        //<summary>
        //get all items using  Rest service
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

            return menuitems;
        }


        /// <summary>
        /// create check using REST service
        /// </summary>
        /// <param name="check"></param>
        /// <returns></returns>
        public bool CreateCheckRest(CheckSummary check)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    MemoryStream ms = new MemoryStream();
                    DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(CheckSummary));
                    serializerToUplaod.WriteObject(ms, check);
                    wc.Headers["Content-type"] = "application/json";
                    wc.UploadData(customerServiceUri + "Check", "POST", ms.ToArray());
                }

            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }
        #endregion

        #region Private  Methods

        /// <summary>
        /// convert data
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
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
        #endregion


        //public bool CreateCheck(CheckSummary check)
        //{
        //bool msg = service.CreateCheck(ConvertToData(check));
        //    return true;
        //}

    }
}