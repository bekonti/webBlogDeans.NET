using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(255,MinimumLength = 15)]
        public string Content { get; set; }

        [Required]
        public DateTime PubDate { get; set; }

        [Required]
        public int Author_id { get; set; }
        public int Likes { get; set; }
    }
}