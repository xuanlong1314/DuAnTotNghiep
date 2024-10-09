using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class HoaDonCT
    {
        [Key]
        public Guid IdHoaDonCT { get; set; }

        public Guid IdSanPhamCT { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gia { get; set; }

        [NotMapped]
        public decimal TongTien
        {
            get { return Gia * SoLuong; }
        }

        public Guid IdHoaDon { get; set; }

        [ForeignKey("IdHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        [ForeignKey("IdSanPhamCT")]
        public virtual SanPhamCT SanPhamCT { get; set; }
    }

}
