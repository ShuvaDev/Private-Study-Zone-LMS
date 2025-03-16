using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSZ.LMS.Domain.Entities
{
    public class Chapter : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Topic>? Topics { get; set; }
    }
}
