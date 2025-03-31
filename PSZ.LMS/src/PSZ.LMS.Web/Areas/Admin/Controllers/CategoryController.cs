using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PSZ.LMS.Domain.Entities;
using PSZ.LMS.Domain.ServiceContracts;
using PSZ.LMS.Infrastructure;
using PSZ.LMS.Web.Areas.Admin.Models;
using Serilog;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Web;

namespace PSZ.LMS.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCategoryJsonData([FromBody] CategoryListModel model)
        {
            var (data, total, totalDisplay) = _categoryService.GetCategories(model.PageIndex, model.PageSize, model.FormatSortExpression("Name", "IsActive"), model.Search);
            
            var categories = new
            {
                recordsTotal = total,
                recordsFiltered = totalDisplay,
                data = (from record in data
                        select new string[]
                        {
                                HttpUtility.HtmlEncode(record.Name),
                                record.IsActive.ToString(),
                                record.Id.ToString()
                        }).ToArray()
            };
            return Json(categories);
        }
        public IActionResult Add()
        {
            return View(new AddCategoryModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Add(AddCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var category = _mapper.Map<Category>(model);
                    _categoryService.AddCategory(category);

                    TempData.Put("ResponseMessage", new ResponseModel
                    {
                        Message = "Category Added Successfully",
                        Type = ResponseTypes.Success
                    });
                }
                catch(Exception ex)
                {
                    Log.Error(ex, "failed to add category");

                    TempData.Put("ResponseMessage", new ResponseModel
                    {
                        Message = "Failed to Add Category",
                        Type = ResponseTypes.Danger
                    });
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
