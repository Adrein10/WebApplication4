using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Description { get; set; }
    }
}
