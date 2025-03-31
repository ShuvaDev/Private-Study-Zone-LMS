using PSZ.LMS.Domain;
using PSZ.LMS.Domain.Entities;
using PSZ.LMS.Domain.RepositoryContracts;

namespace PSZ.LMS.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public (IList<Category> data, int total, int totalDisplay) GetPagedCategories(int pageIndex, int pageSize, string? order, DataTablesSearch search)
        {
            if(String.IsNullOrWhiteSpace(search.Value))
            {
                return GetDynamic(null, order, null, pageIndex, pageSize, true);
            }
            else
            {
                return GetDynamic(category => category.Name.Contains(search.Value), order, null, pageIndex, pageSize, true);
            }
        }
    }
}
