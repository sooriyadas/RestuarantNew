using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestuarantService" in both code and config file together.
    [ServiceContract]
    public interface IRestuarantService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Items", ResponseFormat = WebMessageFormat.Json)]
        IList<MenuItem> GetAllItems();


    }
}
