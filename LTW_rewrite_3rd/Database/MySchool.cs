using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTW_rewrite_3rd.Database
{
    public partial class MySchool : DbContext
    {
        public MySchool()
            : base("name=MySchool1")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
