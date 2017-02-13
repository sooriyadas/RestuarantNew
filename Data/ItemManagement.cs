using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Data
{
    public class ItemManagement : IItemManagement
    {
        public List<MenuItem> GetAllItems()
        {
            //IList<MenuItem> menuitems = new List<MenuItem>();
            //RestuarantEntities tstDb = new RestuarantEntities();
            //var list = from k in tstDb.Items select k;
            //foreach (var item in list)
            //{
            //    MenuItem itm = new MenuItem();
            //    itm.Id = item.Id;
            //    itm.ItemName = item.ItemName;
            //    itm.Price = item.Price;
            //    itm.Description = item.Description;
            //    itm.Category = item.Category;
            //    menuitems.Add(itm);

            //}
            //return menuitems;
            using (RestuarantEntitiesNew res = new RestuarantEntitiesNew())
            {
                return res.Items.Select(r => new MenuItem
                {
                    Id = r.Id,
                    ItemName = r.ItemName,
                    Price = r.Price,
                    Description = r.Description,
                    Category = r.Category

                }).ToList();
            }
        }

        public bool CreateCheck(CheckSumry check)
        {
            int ret = 0;
            RestuarantEntitiesNew res = new RestuarantEntitiesNew();
            try
            {
                CheckSummary chk = new CheckSummary();
                chk.CheckNo = check.CheckNo;
                chk.CreateDate = check.CreateDate;
                chk.Total = check.Total;
                res.CheckSummaries.Add(chk);
                res.SaveChanges();
                int id = chk.Id;

                if (id != null)
                {
                    CheckDetail det = new CheckDetail();

                    foreach (var item in check.CheckDetails)
                    {
                        det.ItemId = item.ItemId;
                        det.ItemName = item.ItemName;
                        det.Total = item.Total;
                        det.CheckId = id;
                        det.Qty = item.Qty;
                        res.CheckDetails.Add(det);
                        ret = res.SaveChanges();
                    }
                }
                if (ret > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {

                throw e;
            }


        }

        public string GetCheckNo()
        {
            using (RestuarantEntitiesNew res = new RestuarantEntitiesNew())
            {

                string ckhno = res.CheckSummaries.OrderByDescending(c => c.Id).Select(r => r.Id).First().ToString();
                //    return res.CheckSummaries.Select(r => r.CheckNo.LastOrDefault()
                //   ).ToString();
                return ckhno;
            }


            //return chkNo;
        }
    }
}
