using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class NguoiDung
    {
        [Key]
        public Guid IdNguoiDung { get; set; } // Khóa chính cho người dùng

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenNguoiDung
        [Required] // Đảm bảo rằng TenNguoiDung luôn được cung cấp
        public string TenNguoiDung { get; set; } // Tên người dùng

        [MaxLength(256)] // Giới hạn độ dài tối đa cho MatKhau
        [Required] // Đảm bảo rằng MatKhau luôn được cung cấp
        public string MatKhau { get; set; } // Mật khẩu người dùng

        [MaxLength(256)] // Giới hạn độ dài tối đa cho Email
        [EmailAddress] // Kiểm tra định dạng email
        public string Email { get; set; } // Email người dùng

        [MaxLength(255)] // Giới hạn độ dài tối đa cho HovaTen
        public string HovaTen { get; set; } // Họ và tên người dùng

        [MaxLength(15)] // Giới hạn độ dài tối đa cho SoDienThoai
        public string SoDienThoai { get; set; } // Số điện thoại người dùng

        [MaxLength(255)] // Giới hạn độ dài tối đa cho Avatar
        public string Avatar { get; set; } // Đường dẫn đến ảnh đại diện

        [MaxLength(10)] // Giới hạn độ dài tối đa cho GioiTinh
        public string GioiTinh { get; set; } // Giới tính người dùng

        public DateTime NgaySinh { get; set; } // Ngày sinh của người dùng

        [Range(100000000, 999999999)] // Giới hạn phạm vi cho CCCD
        public int CCCD { get; set; } // Số CCCD người dùng

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public string? TrangThai { get; set; } // Trạng thái người dùng (nullable)

        public Guid IdVaiTro { get; set; } // Khóa ngoại cho vai trò của người dùng
        public virtual VaiTro VaiTro { get; set; } // Tham chiếu đến VaiTro
        // Có thể thêm các thuộc tính khác nếu cần thiết
    }
}
