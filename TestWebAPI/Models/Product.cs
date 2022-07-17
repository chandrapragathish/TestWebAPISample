using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestWebAPI.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long CategoryId { get; set; }
        [ForeignKey(ForeignKey.CategoryId)]
        public Category Category { get; set; }
    }
    public static class ForeignKey
    {
        public const string CategoryId = "CategoryId";
    }
}