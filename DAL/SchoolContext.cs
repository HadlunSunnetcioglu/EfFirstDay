using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Tom_DykstraAnd_Rick_Anderson.Models;

namespace Tom_DykstraAnd_Rick_Anderson.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Tom_DYKSTRA-Rick_ANDERSON")
        {
          
        }





        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();












        }
    }
}