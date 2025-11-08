using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StdId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Range(18, 35)]
        public int Age { get; set; }
        [Required, StringLength(70, MinimumLength = 5)]
        [RegularExpression(@"[a-zA-Z0-9_]+@[a-zA-Z]+.[a-zA-Z]{2,4}")]
        [Remote("CheckEmail", "student")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        [NotMapped]
        public string CPassword { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        [ValidateNever]
        public Department Department { get; set; }

        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public override string ToString()
        {
            return $"StdId:{StdId}-StdName:{Name}-StdAge:{Age}";
        }
    }
}
