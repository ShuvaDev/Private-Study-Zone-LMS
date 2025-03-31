using Microsoft.EntityFrameworkCore;
using PSZ.LMS.Domain;
using PSZ.LMS.Domain.RepositoryContracts;

namespace PSZ.LMS.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; private set; }
        public ApplicationUnitOfWork(ICategoryRepository categoryRepository, ApplicationDbContext dbContext) : base(dbContext)
        {
            CategoryRepository = categoryRepository;
        }

    }
}
