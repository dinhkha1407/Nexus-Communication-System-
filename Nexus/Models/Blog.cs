﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus.Models
{
    [Table("Blog")]
    public class Blog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
