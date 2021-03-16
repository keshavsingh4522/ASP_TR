using FirstMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstMvcApplication.DataAccess
{
    public class RouxAcademyDbContext:DbContext
    {
        public RouxAcademyDbContext() : base("RouxAcademyDatabase")
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}