using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        IItemManagement service = new ItemManagement();

         [WebMethod]
        public List<MenuItem> GetAllItemsSOAP()
        {
            var list = service.GetAllItems().ToList();
            return list;
        }

         [WebMethod]
        public bool CreateCheckSOAP(CheckSumry check)
        {
            bool msg = service.CreateCheck(check);
            return msg;
        }

         [WebMethod]
        public string GetCheckNoSOAP()
        {
            return service.GetCheckNo();
        }
    }
}
