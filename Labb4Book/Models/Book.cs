using System.ComponentModel.DataAnnotations;

namespace Labb4Book.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(75)]
        public string Title { get; set; }
        [Required]
        [StringLength(400, MinimumLength = 10)]
        public string Description { get; set; }
        [StringLength(100, MinimumLength = 5)]
        public string Author { get; set; }
        public ICollection<CustomerBook>? CustomerBooks { get; set; }
    }
}
