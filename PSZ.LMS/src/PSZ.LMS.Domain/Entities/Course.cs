using PSZ.LMS.Domain.Associations;
using PSZ.LMS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Entities
{
    public class Course : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsPaid { get; set; }
        public int? Fee { get; set; }
        public int? Discount { get; set; }
        public string? Thumbnail { get; set; }
        public CourseType CourseType { get; set; } // ENUM : live, recorded, offline
        public DateTime? StartFrom { get; set; } // If live course
        public string? Duration { get; set; } // If live course i.e. 3 Months
        public Guid CategoryId { get; set; }
        public bool IsVisible { get; set; }

        public CourseDetails Details { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
        public CourseContent CourseContent { get; set; }

        // EnrolledStudents


    }
}
