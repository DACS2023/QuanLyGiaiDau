using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace QuanLyGiaiDau.Models
{
    [Keyless]
    public class CT_TranDau
    {
        public virtual GiaiDau GiaiDau { get; set; }
        public virtual DoiDau DoiDau { get; set; }


        [Column(TypeName = "DateTime")]
        public DateTime ThoiGianBatDau { get; set; }


        [Column(TypeName = "int")]
        public int VongDau { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string SanDau { get; set; }

        [Column(TypeName = "int")]
        public int TiSo { get; set; }

        [Column(TypeName = "varchar")]
        public string KetQua { get; set; }


    }
}