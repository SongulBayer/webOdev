using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.data
{
    public class KediDbContext : DbContext
    {
        public KediDbContext()
        {

        }
        public KediDbContext(DbContextOptions<KediDbContext> options) : base(options)
        {

        }
        public  DbSet<Kedi> Kedi { get; set; }
        public DbSet<Kopek> Kopek { get; set; }
        public DbSet<Balik> Balik { get; set; }
        public DbSet<Kus> Kus { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}
