using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public  interface IItemManagement
    {
      List<MenuItem> GetAllItems();

      bool CreateCheck(CheckSumry check);

      string GetCheckNo();
    }
}
