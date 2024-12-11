using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDemo.Models
{
    [Table("All_p")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public int IPNumber { get; set; }
        public string ProductName { get; set; }

        public int Match { get; set; }

        public ICollection<Category> Category { get; set; }
    }
}
