using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace QuanLyGiaiDau.Models
{
    public class QuanLyGiaiDauContext : DbContext
    {
        public QuanLyGiaiDauContext(DbContextOptions<QuanLyGiaiDauContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MonTheThao> MonTheThaos { get; set; }
        public DbSet<LoaiGiaiDau> LoaiGiaiDau { get; set; }
        public DbSet<DoiDau> DoiDaus { get; set; }
        public DbSet<CT_DoiDau> CT_DoiDaus { get; set; }
        public DbSet<CT_TranDau> CT_TranDaus { get; set; }

        public DbSet<GiaiDau> GiaiDaus { get; set; }

        
    }
}