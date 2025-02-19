using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalWebMVC.Models.Entities.Base_info
{
    public class ITLabele
    {
        [Display(Name = "ردیف")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Key]
        [MaxLength(10)]
        [Display(Name = "کد فناوری")]
        public required string IT_CodeLable { get; set; } // کد 10 رقمی


        [Required]
        [Display(Name ="وضعیت")]
        public ITLableStatus ITLableStatus { get; set; }
        
        public ICollection<YLable>  YLables { get; set; }
    
    }

}
