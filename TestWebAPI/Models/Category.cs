using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestWebAPI.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string CategoryName { get; set; }
    }
}