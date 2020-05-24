using Domain_Inventory.Infra;
using Domain_Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra_Inventory
{
    public class Movement_InMemoryRepo : IMovementRepo
    {
        private List<Movement> movements;
        public Movement_InMemoryRepo()
        {
            this.movements = new List<Movement>()
            {
                new Movement(Guid.Parse("6ac38af3-7508-4b91-ba65-547a8cd13d75"), 2, "Buy"), new Movement(Guid.Parse("6ac38af3-7508-4b91-ba65-547a8cd13d75"), 1, "Sell"),
                new Movement(Guid.Parse("c0529302-2b3e-4255-96e6-2855df760f9f"), 7, "Buy"), new Movement(Guid.Parse("c0529302-2b3e-4255-96e6-2855df760f9f"), 7, "Sell"),
                new Movement(Guid.Parse("9b148d41-979f-4f09-bdfc-d14fa58e8cda"), 9, "Buy"), new Movement(Guid.Parse("9b148d41-979f-4f09-bdfc-d14fa58e8cda"), 8, "Sell"),
                new Movement(Guid.Parse("0939db31-2138-4812-bdd5-5e49d1696217"), 10, "Buy"), new Movement(Guid.Parse("0939db31-2138-4812-bdd5-5e49d1696217"), 1, "Sell"),
                new Movement(Guid.Parse("b5db226d-30ac-41d2-8477-f88688cced4e"), 10, "Buy"), new Movement(Guid.Parse("b5db226d-30ac-41d2-8477-f88688cced4e"), 4, "Sell"),
            };
        }

        public Task<List<Movement>> GetAll()
        {
            return Task.FromResult(this.movements);
        }

        public Task<List<Movement>> GetFromItem(Guid Id)
        {
            return Task.FromResult(this.movements.Where(x => x.ItemId == Id).ToList());
        }

        public Task<ILookup<Guid, Movement>> GetFromItemLookup(IEnumerable<Guid> Id)
        {
            return Task.FromResult(this.movements.Where(x => Id.Contains(x.ItemId)).ToList().ToLookup(r => r.ItemId));
        }

        public Task Add(List<Movement> movements)
        {
            this.movements.AddRange(movements);
            return Task.FromResult(true);
        }

        public Task Remove(List<Guid> movementsIds)
        {
            this.movements.RemoveAll(x => movementsIds.Contains(x.Id));
            return Task.FromResult(true);
        }

        public Task Update(List<Movement> updatedMovements)
        {
            this.movements.RemoveAll(x => updatedMovements.Select(y => y.Id).Contains(x.Id));
            this.movements.AddRange(updatedMovements);
            return Task.FromResult(true);
        }
    }
}
