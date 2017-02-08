using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Web.ServiceBridge;
using Web.ServiceBridge.Interfaces;

namespace Web.Controllers
{
 
    public class RestuarantController : Controller
    {
        //
        // GET: /Restuarant/

        IItemServiceManagement servicebridge = new ItemServiceManagement();
        /// <summary>
        /// Index Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(string serviceType)
        {
            IList<Items> list = new List<Items>();
            Session["OrderList"] = null;
            Session["ServiceType"] = serviceType ;

            if (serviceType == null || serviceType == "SOAP")
            {

                list = servicebridge.GetAllItems();

            }
            else
            {
                list = servicebridge.GetAllItemsRest();
                
            }
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
            //get current date
            DateTime CreationDate = DateTime.Today;
            ViewBag.Date = CreationDate;

            //Store the items to a session
            Session["sessionItemsList"] = menuitems;
            return View(menuitems); 
        }



        /// <summary>
        /// Create check
        /// </summary>
        /// <param name="date"></param>
        /// <param name="chkNo"></param>
        /// <returns></returns>
        public JsonResult CreateCheck(string date,string chkNo,double subTot)
        {
            bool msg =false;
            CheckSummary chkSummary = new CheckSummary();
            var orderList = (Session["OrderList"] as IList<Items>) ?? new List<Items>();

            IList<CheckDetail> checkDetail = new List<CheckDetail>();
            foreach (var item in orderList)
            {
                CheckDetail chkDet = new CheckDetail();
                chkDet.ItemId = item.Id;
                chkDet.ItemName = item.ItemName;
                chkDet.Qty = item.Qty;
                chkDet.Total = item.Qty * item.Price;

                checkDetail.Add(chkDet);
            }
            chkSummary.CheckDetails = checkDetail;
            chkSummary.CreateDate = System.DateTime.Now;
            chkSummary.CheckNo = chkNo;
            chkSummary.Total = subTot;

            var serviceType = Session["ServiceType"];
            if (serviceType == null || serviceType == "SOAP")
            {
                msg = servicebridge.CreateCheck(chkSummary);
            }
            else
            {
                msg = servicebridge.CreateCheckRest(chkSummary);
            }
            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddToList(int id)
        {
           

            //To get what you have stored to a session

            var sessionItemsList = Session["sessionItemsList"] as IList<Items>;
            var item = sessionItemsList.Where(i => i.Id == id).FirstOrDefault();

            //Store the items to a session

            var orderList = (Session["OrderList"] as IList<Items>) ?? new List<Items>();

            var matchingvalues = orderList.Where(o => o.Id==id).FirstOrDefault();
            if (matchingvalues==null)
            {
                orderList.Add(item);
            }
            else
            {
                orderList.Remove(matchingvalues);
                matchingvalues.Qty = (matchingvalues.Qty )+1;
                orderList.Add(matchingvalues);
                item = matchingvalues;
            }

            
            Session["OrderList"] = orderList;

            
            //to clear the session value

          //  Session["products"] = null;

            return Json(item, JsonRequestBehavior.AllowGet);
        }


        public JsonResult DeleteItemfromList(int id)
        {


            //To get what you have stored to a session

            var sessionItemsList = Session["sessionItemsList"] as IList<Items>;
            var item = sessionItemsList.Where(i => i.Id == id).FirstOrDefault();

            //Store the items to a session

            var orderList = (Session["OrderList"] as IList<Items>) ?? new List<Items>();

            var matchingvalues = orderList.Where(o => o.Id == id).FirstOrDefault();
            var msg =orderList.Remove(item);
                
            Session["OrderList"] = orderList;

            return Json(msg, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Foods()
        {
            var list = servicebridge.GetAllItems(); 

            var foods= list.Where(f=>f.Category=="Food").ToList();

            IList<Items> menuitems = new List<Items>();
            foreach (var item in foods)
            {
                Items itm = new Items();
                itm.Id = item.Id;
                itm.ItemName = item.ItemName;
                itm.Price = (float)item.Price;
                itm.Description = item.Description;
                itm.Category = item.Category;
                menuitems.Add(itm);

            }
                 
            return PartialView("~Views/Restuarant/Partial/FoodsList",menuitems);
        }

        public ActionResult Beverages()
        {
            var list = servicebridge.GetAllItems();

            var foods = list.Where(f => f.Category == "Beverage").ToList();

            IList<Items> menuitems = new List<Items>();
            foreach (var item in foods)
            {
                Items itm = new Items();
                itm.Id = item.Id;
                itm.ItemName = item.ItemName;
                itm.Price = (float)item.Price;
                itm.Description = item.Description;
                itm.Category = item.Category;
                menuitems.Add(itm);

            }

            return View("BeverageList", menuitems);
        }
	}
}