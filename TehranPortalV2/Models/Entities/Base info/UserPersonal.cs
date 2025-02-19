using System.ComponentModel.DataAnnotations;

namespace PortalWebMVC.Models.Entities.Base_info
{
    public class UserPersonal
    {
        [Key]
        [Required]
        [Display(Name = "شماره پرسنلی")]
        public required string Id_Personal { get; set; } // شناسه پرسنلی

        [Required]
        [StringLength(100)]
        [Display(Name = "نام")]
        public required string FirstName { get; set; } // نام

        [Required]
        [StringLength(100)]
        [Display(Name = "نام خانوادگی")]
        public required string LastName { get; set; } // نام خانوادگی

        [Required]
        [Display(Name ="نقش")]
        public UserPersonalRole Role { get; set; }

        [Required]
        [Display(Name ="وضعیت")]
        public required bool Active {  get; set; }
        

        [Required]
        [MaxLength(15)]
        [Phone]
        [Display(Name = "شماره تلفن")]
        public required string PhoneNumber { get; set; } // شماره تلفن


        [Required]
        [Display(Name = "جنسیت")]
        public required bool Gender { get; set; } // جنسیت

        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        [Display(Name = "گدرواژه")]
        public required string Password { get; set; } // پسورد
        public virtual  ClientPassword? ClientPassword { get; set; }
    }
}
