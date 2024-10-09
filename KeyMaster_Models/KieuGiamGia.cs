using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class KieuGiamGia
    {
        [Key]
        public Guid IdKieuGiamGia { get; set; } // Khóa chính cho kiểu giảm giá

        [MaxLength(100)] // Giới hạn độ dài tối đa cho TenKieuGiamGia
        public string TenKieuGiamGia { get; set; } // Tên kiểu giảm giá

        // Giá trị giảm giá (có thể là số dương)
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GiaTriGiamGia { get; set; } // Giá trị giảm giá

        // Danh sách các phiếu giảm giá liên quan đến kiểu giảm giá này
        public virtual ICollection<PhieuGiamGia> PhieuGiamGias { get; set; } = new List<PhieuGiamGia>(); // Khởi tạo danh sách
    }
}
