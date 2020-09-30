using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    public class EmpdbContext:DbContext
    {
        public EmpdbContext() : base("constr")
        {

        }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }
        
    }
}