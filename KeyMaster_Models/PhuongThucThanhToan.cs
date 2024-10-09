using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class PhuongThucThanhToan
    {
        [Key]
        public Guid IdPhuongThucThanhToan { get; set; } // Khóa chính cho phương thức thanh toán

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenPhuongThucThanhToan
        [Required] // Đảm bảo rằng TenPhuongThucThanhToan luôn được cung cấp
        public string TenPhuongThucThanhToan { get; set; } // Tên phương thức thanh toán

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public string? TrangThai { get; set; } // Trạng thái của phương thức thanh toán (nullable)

        // Có thể thêm các thuộc tính khác nếu cần thiết
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>(); // Khởi tạo danh sách cho sản phẩm chi tiết
    }
}
