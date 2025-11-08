using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrsId { get; set; }

        public string CrsName { get; set; }

        public int CrsDUeation { get; set; }

        public List<Department> Departments { get; set; }

        public List<StudentCourse> CourseStudents { get; set; } = new List<StudentCourse>();
    }
}
