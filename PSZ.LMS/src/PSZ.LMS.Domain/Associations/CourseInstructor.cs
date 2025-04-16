using PSZ.LMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Associations
{
    public class CourseInstructor
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }

    }
}
