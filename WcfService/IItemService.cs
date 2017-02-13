using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IItemService
    {
        [OperationContract]
        IList<MenuItem> GetAllItems();

        [OperationContract]
        bool CreateCheck(CheckSumry check);

        [OperationContract]
        string GetCheckNo();
    
    }

    [DataContract]
    public class Items
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ItemName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public float Price { get; set; }
        [DataMember]
        public string Category { get; set; }


    } 
}
