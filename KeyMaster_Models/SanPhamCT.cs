using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class SanPhamCT
    {
        [Key]
        public Guid IdSanPhamCT { get; set; } // Khóa chính cho sản phẩm chi tiết

        public Guid IdSanPham { get; set; } // Khóa ngoại đến SanPham

        public Guid IdMau { get; set; } // Khóa ngoại đến Mau

        public Guid IdLed { get; set; } // Khóa ngoại đến Led

        public Guid IdLoaiKN { get; set; } // Khóa ngoại đến LoaiKN

        public Guid IdHang { get; set; } // Khóa ngoại đến Hang

        public Guid IdKeyCap { get; set; } // Khóa ngoại đến KeyCap

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; } // Giá sản phẩm chi tiết

        public int Soluong { get; set; } // Số lượng sản phẩm

        public string? ThongTinThem { get; set; } // Thông tin thêm về sản phẩm

        // Navigation properties
        [ForeignKey("IdSanPham")]
        public virtual SanPham SanPham { get; set; } // Kết nối với SanPham

        [ForeignKey("IdMau")]
        public virtual Mau Mau { get; set; } // Kết nối với Mau

        [ForeignKey("IdLed")]
        public virtual Led Led { get; set; } // Kết nối với Led

        [ForeignKey("IdLoaiKN")]
        public virtual LoaiKN LoaiKN { get; set; } // Kết nối với LoaiKN

        [ForeignKey("IdHang")]
        public virtual Hang Hang { get; set; } // Kết nối với Hang

        [ForeignKey("IdKeyCap")]
        public virtual KeyCap KeyCap { get; set; } // Kết nối với KeyCap
    }


}
