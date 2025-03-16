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
        public string? Title { get; set; } // Short title
        public string? Description { get; set; }
        public bool IsPaid { get; set; }
        public int? Fee { get; set; }
        public int? Discount { get; set; }
        public string? Thumbnail { get; set; }
        public string? IntroVideoLink { get; set; } // Youtube Video
        public CourseType CourseType { get; set; } // ENUM : live, recorded, offline
        public DateTime? StartFrom { get; set; } // If live course
        public string? Duration { get; set; } // If live course i.e. 3 Months
        public double? AccessDuration { get; set; } // If live and recorded
        public AccessDurationUnit? AccessDurationUnit { get; set; } // ENUM : Day, Week, Month, Year, LifeTime
        public Guid CategoryId { get; set; }
        public int? TotalNotes { get;set; }
        public int? TotalVideos { get; set; } // If online course

        public bool IsVisible { get; set; }
        public List<Review>? Reviews { get; set; }

        public CourseContent? CourseContent { get; set; }

        // Teacher
        // EnrolledStudents


    }
}
