using Inventory.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Inventory.Model
{
    public class Item
    {
        public Item() { }
        public Item(string name, string category, List<string> subCategories, List<string> tags)
        {
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            SubCategories = subCategories;
            Tags = tags;
            DateCreated = DateTime.Now;
            ItemStatus = ItemStatusEnum.Active;
        }
        public Item(Guid id, string name, string category, List<string> subCategories, List<string> tags) : this(name, category, subCategories, tags)
        {
            Id = id;
        }

        public Item(string name, string category, List<string> subCategories, List<string> tags, List<Movement> movements) : this(name, category, subCategories, tags)
        {
            Id = Guid.NewGuid();
            Movements = movements;
        }

        public Item(Guid id, string name, string category, List<string> subCategories, List<string> tags, List<Movement> movements) : this(name, category, subCategories, tags, movements)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Upc { get; set; }
        public string Category { get; set; }
        public DateTime DateCreated { get; set; }
        public ItemStatusEnum ItemStatus { get; set; }
        public List<string> SubCategories { get; set; }
        public List<string> Tags { get; set; }
        public List<Movement> Movements { get; set; }
    }
}
