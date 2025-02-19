using System.ComponentModel.DataAnnotations;





namespace PortalWebMVC.Models.Entities.Base_info
{
    public class Branch 
    {
        //[Display(Name = "ردیف")]
        //public int Id { get; set; }
        
        [Required]
        [Key]
        [MaxLength(4)]
        [Display(Name = "کد شعبه")]
        public required string BRCode { get; set; } // کد ۴ رقمی

        [Required]
        [Display(Name = "نام شعبه")]
        public required string BRName { get; set; } // نام

        
        [Display(Name = "تلفن رییس")]  
        public  string? BRPhone1 { get; set; } //  تلقن رییس

        
        [Display(Name = "تلفن معاون")]
        public  string? BRPhone2 { get; set; } //  تلقن معاون

        
        [Display(Name = "تلفن خدمات")]
        public  string? BRPhone3 { get; set; } //  تلقن خدمات

     
        [Display(Name = "IP Address")]
        [MaxLength(15)]
        public string? IPAddress { get; set; } //  IP
    }
    }
