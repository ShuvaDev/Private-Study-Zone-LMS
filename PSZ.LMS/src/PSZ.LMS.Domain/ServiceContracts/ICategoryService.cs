using PSZ.LMS.Domain.Entities;

namespace PSZ.LMS.Domain.ServiceContracts
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        (IList<Category> data, int total, int totalDisplay) GetCategories(int pageIndex, int pageSize, string? order, DataTablesSearch search);
    }
}
