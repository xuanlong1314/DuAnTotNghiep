using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class Hang
    {
        [Key]
        public Guid IdHang { get; set; }

        [MaxLength(100)] 
        public string TenHang { get; set; }

        [MaxLength(50)] 
        public string? TrangThai { get; set; }

        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }
}
