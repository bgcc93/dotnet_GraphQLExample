using Inventory.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.DTO
{
    public class ItemSearchDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsInStock { get; set; }
        public DateTime? DateMovement { get; set; }
        public DateTime? DateCreated { get; set; }
        public ItemStatusEnum? ItemStatus { get; set; }
    }
}
