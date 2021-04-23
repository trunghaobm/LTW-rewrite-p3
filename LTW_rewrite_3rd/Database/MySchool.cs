using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTW_rewrite_3rd.Database
{
    public partial class MySchool : DbContext
    {
        public MySchool()
            : base("name=MySchool")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
