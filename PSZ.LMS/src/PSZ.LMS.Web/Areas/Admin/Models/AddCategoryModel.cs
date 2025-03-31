using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PSZ.LMS.Web.Areas.Admin.Models
{
    public class AddCategoryModel
    {
        [Required(ErrorMessage = "Category Name Can't Be Empty")]
        [DisplayName("Category Name")]
        [MaxLength(200, ErrorMessage = "Category Name Can't Be More Than 200 Characters")]
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
