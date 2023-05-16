using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGiaiDau.Models
{
    
    [Keyless]
    public class CT_DoiDau
    {

        [DisplayName("Id Doi Dau")]
        [Column(TypeName = "varchar(10)")]
        public string IdTranDau { get; set; }
        [ForeignKey("IdDoiDau")]
        public virtual DoiDau DoiDau { get; set; }


        [Column(TypeName = "varchar(10)")]
        public string IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        [Column(TypeName = "bit")]
        public bool TrangThaiTV { get; set; }
    }
}