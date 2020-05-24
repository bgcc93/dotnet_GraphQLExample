using Domain_Inventory.Infra;
using Domain_Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra_Inventory
{
    public class Item_InMemoryRepo : IItemRepo
    {
        private List<Item> items;
        public Item_InMemoryRepo()
        {
            this.items = new List<Item>()
            {
                new Item(Guid.Parse("6ac38af3-7508-4b91-ba65-547a8cd13d75"), "Item 1", "Category 1", new List<string>{ "sub 1", "sub 2"},  new List<string>{ "tag 1", "tag 2"}, new List<Movement> {new Movement(2, "Buy"), new Movement(1, "Sell")}),
                new Item(Guid.Parse("c0529302-2b3e-4255-96e6-2855df760f9f"), "Item 2", "Category 2", new List<string>{ "sub 1", "sub 2"},  new List<string>{ "tag 1", "tag 2"}, new List<Movement> {new Movement(7, "Buy"), new Movement(7, "Sell")}),
                new Item(Guid.Parse("9b148d41-979f-4f09-bdfc-d14fa58e8cda"), "Item 3", "Category 1", new List<string>{ "sub 3", "sub 4"},  new List<string>{ "tag 1", "tag 2"}, new List<Movement> {new Movement(9, "Buy"), new Movement(8, "Sell")}),
                new Item(Guid.Parse("0939db31-2138-4812-bdd5-5e49d1696217"), "Item 4", "Category 2", new List<string>{ "sub 3", "sub 4"},  new List<string>{ "tag 1", "tag 2"}, new List<Movement> {new Movement(10, "Buy"), new Movement(1, "Sell")}),
                new Item(Guid.Parse("b5db226d-30ac-41d2-8477-f88688cced4e"), "Item 5", "Category 1", new List<string>{ "sub 5", "sub 6"},  new List<string>{ "tag 1", "tag 2"}, new List<Movement> {new Movement(10, "Buy"), new Movement(4, "Sell")}),
            };
        }

        public Task Add(List<Item> items)
        {
            this.items.AddRange(items);
            return Task.FromResult(true);
        }

        public Task<List<Item>> GetAll()
        {
            return Task.FromResult(this.items);
        }

        public Task Remove(List<Guid> itemIds)
        {
            this.items.RemoveAll(x => itemIds.Contains(x.Id));
            return Task.FromResult(true);
        }

        public Task Update(List<Item> updatedItems)
        {
            this.items.RemoveAll(x => updatedItems.Select(y => y.Id).Contains(x.Id));
            this.items.AddRange(updatedItems);
            return Task.FromResult(true);
        }
    }
}
