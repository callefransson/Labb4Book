using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Labb4Book.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Customer must have a first name")]
        [StringLength(50)]
        [DisplayName("First name")]
        public string CutsomerFirstName { get; set; }
        [Required(ErrorMessage ="Customer must have a last name")]
        [StringLength(50, MinimumLength = 5)]
        [DisplayName("Last name")]
        public string CutsomerLastName { get; set; }
        [Required(ErrorMessage = "Email is requierd")]
        [StringLength(100, MinimumLength = 10)]
        [DisplayName("Email")]
        public string CutsomerEmail { get; set; }
        [Required(ErrorMessage = "Phone number is requierd")]
        [DisplayName("Phone")]
        public string CutsomerPhone { get; set; }
        public ICollection<CustomerBook>? CustomerBooks { get; set; }
    }
}
