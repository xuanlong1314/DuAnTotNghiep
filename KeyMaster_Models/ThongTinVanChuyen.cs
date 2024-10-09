using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class ThongTinVanChuyen
    {
        [Key] // Khóa chính cho thông tin vận chuyển
        public Guid IdThongTinVanChuyen { get; set; }

        [MaxLength(255)] // Giới hạn độ dài tối đa cho địa chỉ
        public string DiaChi { get; set; }

        [MaxLength(100)] // Giới hạn độ dài tối đa cho tên người nhận
        public string TenNguoiNhan { get; set; }

        [MaxLength(15)] // Giới hạn độ dài tối đa cho số điện thoại
        public string SoDienThoai { get; set; }

        [MaxLength(100)] // Giới hạn độ dài tối đa cho tỉnh
        public string Tinh { get; set; }

        [MaxLength(100)] // Giới hạn độ dài tối đa cho huyện
        public string Huyen { get; set; }

        [MaxLength(100)] // Giới hạn độ dài tối đa cho xã
        public string Xa { get; set; }

        [ForeignKey("NguoiDung")] // Chỉ định khóa ngoại cho người dùng
        public Guid IdNguoiDung { get; set; }

        // Tham chiếu tới NguoiDung
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }

}
