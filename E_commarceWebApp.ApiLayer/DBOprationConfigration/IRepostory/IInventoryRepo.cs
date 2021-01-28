using E_commarceWebApp.ApiLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commarceWebApp.ApiLayer.DBOprationConfigration.IRepostory
{
   public  interface IInventoryRepo
    {
        Task<Inventory> CrateInventory(Inventory inventory );
        
    }
}
