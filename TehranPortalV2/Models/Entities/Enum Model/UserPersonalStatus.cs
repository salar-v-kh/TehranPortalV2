using System.ComponentModel.DataAnnotations;

namespace PortalWebMVC.Models.Entities.Base_info
{
    public enum UserPersonalStatus
    {

        [Display(Name = "فعال")]
        Active = 1,

        [Display(Name = "غیر فعال")]
        Disactive = 2,




    }
}
