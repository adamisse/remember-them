using Api.Infrastructure;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        //Entity Framework -> ORM
        //Dapper -> Micro ORM
        //Sequelize/Prisma -> ORM

        public virtual DbSet<TEntity> DbSet => DbContext.Set<TEntity>();

        protected DatabaseContext DbContext { get; set; }

        public EfRepository(DatabaseContext context)
        {
            DbContext = context;
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity?> FindAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task CreateAsync(TEntity entity)
        {
            DbSet.Add(entity);
            await DbContext.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await DbContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}