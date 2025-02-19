using System.ComponentModel.DataAnnotations;

namespace PortalWebMVC.Models.Entities.other_Model
{
    public class GroupDevice
    {
        public enum MainGroupe
        {
            [Display(Name = "گروه کامپیوتر")]
            ComputerGroup = 1,
            [Display(Name = "پرینتر")]
            PrinterGroup = 2,
            [Display(Name = "اسکنر")]
            ScannerGroup = 3,
            [Display(Name = "مانیتور")]
            MonitorGroup = 4,
            [Display(Name = "گروه شبکه")]
            NetworkGroup = 5,
            [Display(Name = "گروه UPS")]
            UpsGroup = 6
            
        }
        
        public enum ComputerGroup

        {
            [Display(Name = "کیس")]
            Case = 1,
            [Display(Name = "ALL-IN-ONE")]
            allinone = 2,
            [Display(Name = "مینی کیس")]
            minipc = 3
        }

        public enum PrinterGroup
        {
            [Display(Name = "لیزری")]
            LaserJet = 1,
            [Display(Name = "سوزنی")]
            DotMatrixPrinter = 2,
            [Display(Name = "اسلیپ")]
            SlipPrinter = 3
        }

        public enum ScnnerGroup
        {
            [Display(Name = "فیدر دار")]
            FiderScanner = 1,
            [Display(Name = "تخت")]
            SlimScaneer = 2
        }


        public enum MonitorGroup
        {
            [Display(Name = "15")]
            in15 = 1,
            [Display(Name = "17")]
            in17 = 2,
            [Display(Name = "19")]
            in19 = 3,
            [Display(Name = "20")]
            in20 = 4,
            [Display(Name = "22")]
            in22 = 5,
            [Display(Name = "23")]
            in23 = 6,
            [Display(Name = "24")]
            in24 = 7,
            [Display(Name = "27")]
            in27 = 8,
            [Display(Name = "29")]
            in29 = 9
        }


        public enum NetworkGroup
        {
            [Display(Name = "سرور")]
            Server = 1,
            [Display(Name = "روتر")]
            Ruoter =2,
            [Display(Name = "سوییچ")]
            Swetch =3
        }




    }
}
