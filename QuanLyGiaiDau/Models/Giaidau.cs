using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace QuanLyGiaiDau.Models
{
    public class GiaiDau
    {
        [Key]
        [DisplayName("Id giải đấu")]
        [Column(TypeName = "int")]
        public int IdGiaiDau { get; set; }

        [DisplayName("Tên giải đấu")]
        [Column(TypeName ="nvarchar(150)")]
        public string TenGiaiDau { get; set; }

        [DisplayName("Ngày bắt đầu")]
        [Column(TypeName = "Datetime")]
        public DateTime NgayBatDau { get; set; }

        [DisplayName("Mô tả")]
        [Column(TypeName = "nvarchar(150)")]
        public string MoTa { get; set; }

        [DisplayName("Địa điểm")]
        [Column(TypeName = "nvarchar(150)")]
        public string DiaDiem { get; set; }

        [DisplayName("Trạng Thái")]
        [Column(TypeName = "bit")]
        public bool TrangThai { get; set; }

        public virtual LoaiGiaiDau LoaiGiaiDau { get; set; }

    }
}
