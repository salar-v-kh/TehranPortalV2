using System.ComponentModel.DataAnnotations;

namespace TehranPortalV2.Models.Entities.FirstTable
{
    public class DeviceProfiles
    {

        [Display(Name = "ردیف")]
        public required int Id { get; set; }



        [Required]
        [Key]
        [MaxLength(10)]
        [Display(Name = "کد فناوری")]
        public required string IT_CodeLable { get; set; } // کد 10 رقمی



        [Display(Name = "شماره اموال")]
        [Key]
        [MaxLength(7)]
        [Required]
        public required string Y_LableCode { get; set; } // کد 7 رقمی


        [Required]
        [Key]
        [MaxLength(4)]
        [Display(Name = "کد شعبه")]
        public required string BRCode { get; set; } // کد ۴ رقمی

        [Required]
        [Display(Name = "نام شعبه")]
        public required string BRName { get; set; } // نام





    }
}
