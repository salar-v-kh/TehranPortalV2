using System.ComponentModel.DataAnnotations;

namespace PortalWebMVC.Models.Entities.Base_info
{
    public class ClientPassword
    {

        [Key]
        [Required]
        [Display(Name = "شماره پرسنلی")]
        public required string Id_Personal { get; set; } // شناسه پرسنلی


        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        [Display(Name = "گدرواژه")]
        public required string Password { get; set; } // پسورد

        public virtual UserPersonal? UserPersonal { get; set; }


    }
}
