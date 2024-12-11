using WebDemo.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebDemo.Models
{
    [Table("Category_Name")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public int InputCategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}