using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Entities
{
    public class Note : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsPrivate { get; set; }
        public string? Link { get; set; }
    }
}
