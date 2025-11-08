using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models.ViewModels
{
    public class GetEditDepartmentCoursesVM
    {
        public Department Department { get; set; }

        public List<Course> CoursesAlreadyExistInDepartment { get; set; }
        public List<Course> CoursesDoesNotExistInDepartment { get; set; }
    }
}
