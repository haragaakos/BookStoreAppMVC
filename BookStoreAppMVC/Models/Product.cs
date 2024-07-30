using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreAppMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? ISBN { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        [Range(1, 100000)]
        public double Price {  get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(name:"CategoryId")]
        public Category? Category { get; set; }
    }
}
