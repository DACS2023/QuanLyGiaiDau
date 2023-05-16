﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace QuanLyGiaiDau.Models
{
    [Keyless]
    public class CT_TranDau
    {
        
        [Column(TypeName = "int")]
        public int IdGiaiDau { get; set; }
        [ForeignKey("IdGiaiDau")]
        public virtual GiaiDau GiaiDau { get; set; }


        
        [Column(TypeName = "varchar(10)")]
        public string IdDoiDau { get; set; }
        [ForeignKey("IdDoiDau")]
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