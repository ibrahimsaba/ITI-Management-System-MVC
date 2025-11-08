using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        public string DeptName { get; set; }

        public int Capacity { get; set; }

        public bool Status { get; set; } = true;

        public List<Student>? students { get; set; } = new List<Student>();

        public List<Course> Courses { get; set; }
        public override string ToString()
        {
            return $"DeptID:{DeptId}-DeptName:{DeptName}-DeptCapacity:{Capacity}";
        }
    }
}
