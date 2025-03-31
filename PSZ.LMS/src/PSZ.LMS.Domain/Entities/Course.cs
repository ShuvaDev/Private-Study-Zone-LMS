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


        public string? ShortDescription { get; set; } // Short description for Course Details Page
        public string? Description { get; set; } // Long Description for Course Details Page
        public string? IntroVideoLink { get; set; } // Youtube Video for Course Details Page
        public double? AccessDuration { get; set; } // If live and recorded (For Card in Course Details Page)
        public AccessDurationUnit? AccessDurationUnit { get; set; } // ENUM : Day, Week, Month, Year, LifeTime
        public int? TotalNotes { get;set; } // for card in course details page
        public int? TotalVideos { get; set; } // If online course (for card in course details page)
        public List<Review>? Reviews { get; set; } // For Course Details Page

        public CourseContent? CourseContent { get; set; }

        // Instructor
        // EnrolledStudents


    }
}
