using PSZ.LMS.Domain;
using PSZ.LMS.Domain.Entities;
using PSZ.LMS.Domain.ServiceContracts;

namespace PSZ.LMS.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public CategoryService(IApplicationUnitOfWork applicationUnitOfWork) 
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }

        public (IList<Category> data, int total, int totalDisplay) GetCategories(int pageIndex, int pageSize, string? order, DataTablesSearch search)
        {
            return _applicationUnitOfWork.CategoryRepository.GetPagedCategories(pageIndex, pageSize, order, search);
        }
        public void AddCategory(Category category)
        {
            _applicationUnitOfWork.CategoryRepository.Add(category);
            _applicationUnitOfWork.Save();
        }

    }
}
