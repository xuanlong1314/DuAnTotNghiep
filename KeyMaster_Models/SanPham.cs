using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class SanPham
    {
        [Key]
        public Guid IdSanPham { get; set; } // Khóa chính cho sản phẩm

        [MaxLength(200)] // Giới hạn độ dài tối đa cho TenSanPham
        public string TenSanPham { get; set; }

        [MaxLength(1000)] // Giới hạn độ dài tối đa cho MoTa
        public string? MoTa { get; set; } // Nullable nếu mô tả không bắt buộc

        [MaxLength(50)] // Giới hạn độ dài tối đa cho TrangThai
        public string? TrangThai { get; set; } // Nullable nếu trạng thái không bắt buộc

        public Guid IdImage { get; set; } // Khóa ngoại đến hình ảnh

        [ForeignKey("IdImage")]
        public virtual HinhAnh HinhAnh { get; set; } // Navigation property đến HinhAnh

        public Guid IdLoaiSP { get; set; } // Khóa ngoại đến loại sản phẩm

        [ForeignKey("IdLoaiSP")]
        public virtual LoaiSP LoaiSP { get; set; } // Navigation property đến LoaiSanPham

        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; } = new List<SanPhamCT>(); // Khởi tạo danh sách cho sản phẩm chi tiết

        public virtual ICollection<SanPhamKM> SanPhamKMs { get; set; } = new List<SanPhamKM>(); // Khởi tạo danh sách cho sản phẩm khuyến mãi
    }

}
