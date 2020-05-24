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
        Task Add(List<Item> items);
        Task Remove(List<Guid> itemIds);
        Task Update(List<Item> itemIds);
    }
}
