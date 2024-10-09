using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class KhuyenMai
    {
        [Key]
        public Guid IdKhuyenMai { get; set; } // Khóa chính cho khuyến mãi

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenKhuyenMai
        public string TenKhuyenMai { get; set; } // Tên khuyến mãi

        // Mức giảm giá dự kiến có thể là số thập phân
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MucGiamGia { get; set; } // Mức giảm giá (nullable)

        public DateTime? NgayBatDau { get; set; } // Ngày bắt đầu khuyến mãi (nullable)

        public DateTime? NgayKetThuc { get; set; } // Ngày kết thúc khuyến mãi (nullable)

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public string? TrangThai { get; set; } // Trạng thái (nullable)

        // Danh sách sản phẩm khuyến mãi liên quan đến khuyến mãi này
        public virtual ICollection<SanPhamKM> SanPhamKMs { get; set; } = new List<SanPhamKM>(); // Khởi tạo danh sách
    }
}
