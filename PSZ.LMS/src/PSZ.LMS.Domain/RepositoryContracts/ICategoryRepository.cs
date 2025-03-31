using PSZ.LMS.Domain.Entities;

namespace PSZ.LMS.Domain.RepositoryContracts
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
        (IList<Category> data, int total, int totalDisplay) GetPagedCategories(int pageIndex, int pageSize, string? order, DataTablesSearch search);
    }
}
