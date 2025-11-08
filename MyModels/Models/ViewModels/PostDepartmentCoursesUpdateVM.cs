using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models.ViewModels
{
    public class PostDepartmentCoursesUpdateVM
    {
        public int deptId { get; set; }

        public int[] coursetoremove { get; set; }

        public int[] coursetoadd
        {
            get; set;
        }
    }
}
