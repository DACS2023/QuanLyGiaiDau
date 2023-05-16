using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace QuanLyGiaiDau.Models
{
    public class LoaiGiaiDau 
    {
        [Key]
        
        [Column(TypeName = "int")]
        public int IdloaiGiaiDau { get; set; }

        [Column(TypeName = "bit")]
        public bool TrangThai { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string IdMonTheThao { get; set; }

        [ForeignKey("IdMonTheThao")]
        public virtual MonTheThao MonTheThao { get; set; }
    }
}