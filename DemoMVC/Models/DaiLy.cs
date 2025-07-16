using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class DaiLy
    {
        [Key]
        [Display(Name="Mã Đại Lý")] 
        public string MaDaiLy { get; set; }
        [Display(Name="Tên Đại Lý")]
        public string TenDaiLy { get; set; }
        [Display(Name="Địa Chỉ")]
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }
        [Display(Name="Mã Hệ Thống Phân Phối")]
        public string MaHTPP { get; set; }
        [ForeignKey("MaHTPP")]
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
    }
}
