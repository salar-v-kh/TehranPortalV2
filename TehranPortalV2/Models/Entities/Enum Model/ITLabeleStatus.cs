using System.ComponentModel.DataAnnotations;

namespace PortalWebMVC.Models.Entities.Base_info
{

    
        public enum ITLableStatus
        {

            [Display(Name = "چاپ شده")]
            Created = 1,

            [Display(Name = "نصب شده")]
            Approved = 2,

            [Display(Name = "مخدوش شده")]
            Rejected = 3,

            [Display(Name = "اسقاط شده")]
            Archived = 4


        }
    }




