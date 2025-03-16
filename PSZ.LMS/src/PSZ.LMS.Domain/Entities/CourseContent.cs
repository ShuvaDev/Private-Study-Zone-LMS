using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Entities
{
    public class CourseContent : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public List<Chapter>? Chapters { get; set; }
        public string? CourseOverview { get; set; } // Description
        public List<Note>? Notes { get; set; }

    }
}
