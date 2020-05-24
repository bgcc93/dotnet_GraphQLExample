using Domain_Inventory.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Inventory.Infra
{
    public interface IInMemoryRepo<T> where T: class
    {
        Task<List<T>> GetAll();
        Task Add(List<T> items);
        Task Remove(List<Guid> itemIds);
        Task Update(List<T> itemIds);
    }
}
