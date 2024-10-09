using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class GioHang
    {
        [Key]
        public Guid IdGioHang { get; set; }

        [MaxLength(50)] // Giới hạn độ dài của TrangThai tối đa là 50 ký tự
        public string? TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }

        public Guid IdNguoiDung { get; set; }

        [ForeignKey("IdNguoiDung")]
        public virtual NguoiDung? NguoiDung { get; set; }

        public virtual ICollection<GioHangCT> GioHangCTs { get; set; }
    }
}
