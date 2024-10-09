using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class Led
    {
        [Key]
        public Guid IdLed { get; set; } // Khóa chính cho Led

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenLed
        public string TenLed { get; set; } // Tên LED

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public string? TrangThai { get; set; } // Trạng thái của LED (nullable)

        // Tham chiếu đến các sản phẩm chi tiết
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; } = new List<SanPhamCT>(); // Khởi tạo danh sách để tránh NullReferenceException

        // Bạn có thể thêm các thuộc tính khác ở đây nếu cần thiết
        // Ví dụ: thuộc tính mô tả chi tiết, màu sắc, công suất, v.v.
    }
}
