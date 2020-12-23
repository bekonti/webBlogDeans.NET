using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20,MinimumLength = 3)]
        public string Name { get; set; }
    }
}