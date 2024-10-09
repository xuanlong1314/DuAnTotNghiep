using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class VaiTro
    {
        [Key] // Khóa chính cho vai trò
        public Guid IdVaiTro { get; set; }

        [MaxLength(100)] // Giới hạn độ dài tối đa cho tên vai trò
        public string TenVaiTro { get; set; }

        // Danh sách người dùng liên quan đến vai trò này
        public virtual ICollection<NguoiDung> NguoiDungs { get; set; } = new List<NguoiDung>(); // Khởi tạo danh sách

        // Bạn có thể thêm các thuộc tính khác nếu cần thiết
        // Ví dụ: thuộc tính mô tả chi tiết về vai trò, quyền hạn, v.v.
    }
}
