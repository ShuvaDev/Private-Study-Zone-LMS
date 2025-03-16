using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Entities
{
    public class Topic : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public string Duration { get; set; }
        public string? Description { get; set; }
        public string VideoLink { get; set; }
        public List<Comment>? Comments { get; set; }

    }
}
