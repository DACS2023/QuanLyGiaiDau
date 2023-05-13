using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace QuanLyGiaiDau.Models
{

    public class DoiDau
    {
        [Key]
        [DisplayName("Id Doi Dau")]
        [Column(TypeName = "varchar(10)")]
        public string IdTranDau { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string TenDoiDau { get; set; }


        [Column(TypeName = "nvarchar(256)")]
        public string Logo { get; set; }


    }
}
