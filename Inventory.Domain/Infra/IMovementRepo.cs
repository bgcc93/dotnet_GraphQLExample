using Domain_Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Inventory.Infra
{
    public interface IMovementRepo
    {
        Task<List<Movement>> GetAll();
        Task<List<Movement>> GetFromItem(Guid Id);
        Task<ILookup<Guid, Movement>> GetFromItemLookup(IEnumerable<Guid> Id);
        Task Add(List<Movement> movements);
        Task Remove(List<Guid> movementIds);
        Task Update(List<Movement> movementIds);
    }
}
