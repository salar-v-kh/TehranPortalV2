using System;
using System.ComponentModel.DataAnnotations;
//using PersianDate;

namespace PortalWebMVC.Models.Entities.Base_info
{
    public class YLable
    {
        [Display(Name = "ردیف")]
        public required int Id { get; set; }

        [Display(Name = "شماره اموال")]
        [Key]
        [MaxLength(7)]
        [Required]
        public required string Y_LableCode { get; set; } // کد 7 رقمی

        [Required]
        [Display(Name ="وضعیت")]
        public YLableStatus YLableStatus { get; set; }

        public ITLabele ITLabele { get; set; }

        [MaxLength(10)]
        public string IT_CodeLable { get; set; }

    }
}
