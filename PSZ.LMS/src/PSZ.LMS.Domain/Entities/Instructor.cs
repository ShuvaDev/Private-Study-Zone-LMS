using PSZ.LMS.Domain.Associations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Entities
{
    public class Instructor : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; } // i.e. CSE, DUET
        public string? Description { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
