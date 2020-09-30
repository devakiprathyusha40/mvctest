using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvctest.Models
{
    [Table("Employeenew")]
    public class Emp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public virtual int Did { get; set; }
        public virtual Dept Dept { get; set; }
    }
}