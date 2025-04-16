using PSZ.LMS.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PSZ.LMS.Web.Areas.Admin.Models
{
    public class AddCourseModel
    {
        public List<Lesson> Lessons { get; set; }
    }
}
