using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSiteCSharp.Models
{
    [Table("WSCS_USER")]
    public class ContactModel
    {
        [Display(Name = "ID")]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name = "NAME")]
        [Column("NAME")]
        public string Name { get; set; }

        [Display(Name = "EMAIL")]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Display(Name = "PHONENUMBER")]
        [Column("PHONENUMBER")]
        public string PhoneNumber { get; set; }
    }
}
