using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProject.Models
{
    public class Context : DbContext
    {
        public DbSet<UserModels> Users { get; set; }
        public DbSet<BeautyServices> BeautyServices { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<Records> Records { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder option) => option.UseSqlite(@"Data Source=C:\Temp\Data.db");
    }
}
