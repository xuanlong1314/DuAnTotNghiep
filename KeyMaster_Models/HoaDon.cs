using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class HoaDon
    {
        [Key]
        public Guid IdHoaDon { get; set; }

        public Guid IdNguoiDung { get; set; }
        public Guid IdPhuongThucThanhToan { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }

        [NotMapped]
        public decimal TongTien
        {
            get { return (Gia * SoLuong) + PhiVanChuyen; }
        }

        public string TrangThai { get; set; }

        public DateTime NgayVanChuyen { get; set; }
        public DateTime? NgayGiaoHangDuKien { get; set; }
        public DateTime? NgayNhanHang { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PhiVanChuyen { get; set; }

        public string? GhiChu { get; set; }

        public Guid? IdThongTinVanChuyen { get; set; }
        public Guid? IdPhieuGiamGia { get; set; }

        [ForeignKey("IdNguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }

        [ForeignKey("IdPhuongThucThanhToan")]
        public virtual PhuongThucThanhToan PhuongThucThanhToan { get; set; }

        [ForeignKey("IdThongTinVanChuyen")]
        public virtual ThongTinVanChuyen ThongTinVanChuyen { get; set; }

        [ForeignKey("IdPhieuGiamGia")]
        public virtual PhieuGiamGia PhieuGiamGia { get; set; }

        public virtual ICollection<LichSuHoaDon> LichSuHoaDons { get; set; }
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
    }
}