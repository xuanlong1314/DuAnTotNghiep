using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class HinhAnh
    {
        [Key]
        public Guid IdImage { get; set; } // Unique identifier for the image

        [MaxLength(255)] // Optional: Limit for file name length
        public string FileName { get; set; } // File name

        [MaxLength(50)] // Optional: Limit for file type length
        public string FileType { get; set; } // File type (jpg, png, etc.)

        public byte[] Data { get; set; } // Image data as byte array
        public virtual ICollection<SanPham> SanPhams { get; set; } // Navigation property to SanPham
    }
}
