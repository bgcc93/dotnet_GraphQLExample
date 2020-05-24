using System;

namespace Domain_Inventory.Model
{
    public class Movement
    {
        public Movement() { }
        public Movement(int quantity, string description)
        {
            Id = Guid.NewGuid();
            Quantity = quantity;
            Description = description;
            DateCreated = DateTime.Now;
        }
        public Movement(Guid itemId, int quantity, string description) : this(quantity, description)
        {
            ItemId = itemId;
        }

        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public Item Item { get; set; }
    }
}