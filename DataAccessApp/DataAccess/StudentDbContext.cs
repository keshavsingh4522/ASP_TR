using DataAccessApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAccessApp.DataAccess
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(): base("StudentDatabase")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}