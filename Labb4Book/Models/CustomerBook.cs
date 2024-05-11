using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb4Book.Models
{
    public class CustomerBook
    {
        [Key] public int CustomerBookId { get; set; }
        [ForeignKey("Customer")]
        public int FkCustomerId { get; set; }
        public Customer Customer {  get; set; }
        [ForeignKey("Book")]
        public int FkBookId { get; set; }
        public Book Book { get; set; }
        [DisplayName("Rent date")]
        [DataType(DataType.Date)]
        public DateTime BookRentDate { get; set; }

        [DisplayName("Return date")]
        [DataType(DataType.Date)]
        public DateTime BookReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public DateTime ReturnedAt { get; set; }

    }
}
