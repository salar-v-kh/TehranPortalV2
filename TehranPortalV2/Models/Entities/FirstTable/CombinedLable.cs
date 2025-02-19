using PortalWebMVC.Models.Entities.Base_info;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TehranPortalV2.Models.Entities.FirstTable
{
    public class CombinedLable
    {
        [Key]
        public int Id { get; set; }

        public string? YLableCode { get; set; }
        public string? ITLableCode { get; set; }

        [ForeignKey("YLableCode")]
        public YLable? YLable { get; set; }

        [ForeignKey("ITLableCode")]
        public ITLabele? ITLabele { get; set; }
    }

}
