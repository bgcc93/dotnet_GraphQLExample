using Domain_Inventory.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Inventory.Infra
{
    public interface IItemRepo
    {
        Task<List<Item>> GetAll();
        Task<List<Item>> Add(List<Item> items);
        Task Remove(List<Guid> itemIds);
        Task<List<Item>> Update(List<Item> itemIds);
    }
}
