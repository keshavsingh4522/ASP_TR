using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Course { get; set; }
        public String RollNo { get; set; }
        public String Mobile { get; set; }
    }
}