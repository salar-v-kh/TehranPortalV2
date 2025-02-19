using System.ComponentModel.DataAnnotations;

namespace PortalWebMVC.Models.Entities.Base_info
{
    public enum UserPersonalRole
    {
        [Display(Name = "مدیر سایت")]
        Created = 1,

        [Display(Name = "ادمین سایت")]
        Approved = 2,

        [Display(Name = "رییس شعبه")]
        Rejected = 3,

        [Display(Name = "معاون شعبه")]
        Archived = 4,

        [Display(Name = "رییس خدمات")]
         b = 5,

        [Display(Name = "مدیر")]
        c = 6,

        [Display(Name = "معاون")]
        d = 7,

        [Display(Name = "رییس دایره")]
        Ae = 8



    }
}
