using System;
using Azure;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDbMvc.Models
{
	public class Context : DbContext
	{

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("Host=localhost; Database=postgres; Username=postgres; Password=123");

       }
        public DbSet<Departmanlar> Departmanlars { get; set; }
		public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {   

            builder.Entity<Departmanlar>()
            .HasKey(hk => new { hk.Id });

            builder.Entity<Departmanlar>().Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Entity<Personel>()
            .HasKey(hk => new { hk.Id });
            builder.Entity<Personel>().Property(p => p.Id).ValueGeneratedOnAdd();


            builder.Entity<Personel>()
            .HasOne<Departmanlar>(s => s.Depart)
            .WithMany(g => g.Personels)
            .HasForeignKey(s => s.DepartId);


            base.OnModelCreating(builder);
        }

    }
}

