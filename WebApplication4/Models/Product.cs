using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
    }
}
