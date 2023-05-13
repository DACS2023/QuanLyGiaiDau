using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuanLyGiaiDau.Models
{
    public class MonTheThao
    {
        [Key]
        [DisplayName("Id Môn Thể Thao")]
        [Column(TypeName = "varchar(10)")]
        public string IdMonTheThao { get; set; }

        [DisplayName("Tên Môn Thể Thao")]
        [Column(TypeName = "nvarchar(100)")]
        public string TenMonTheThao { get; set; }
    }
}