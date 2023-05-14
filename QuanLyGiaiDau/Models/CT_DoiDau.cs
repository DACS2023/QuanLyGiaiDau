using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGiaiDau.Models
{
    
    [Keyless]
    public class CT_DoiDau
    {

        public virtual DoiDau DoiDau { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName = "bit")]
        public bool TrangThaiTV { get; set; }
    }
}