using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        [Display(Name="Mã Hệ Thống Phân Phối")]
        public string MaHTPP { get; set; }
        [Display(Name="Tên Hệ Thống Phân Phối")]
        public string TenHTPP { get; set; }
        public ICollection<DaiLy> DaiLys { get; set; }
    }
}
