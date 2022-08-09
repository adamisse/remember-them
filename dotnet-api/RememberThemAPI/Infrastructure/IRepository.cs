namespace Api.Infrastructure
{
    public interface IRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAsync();

        public Task<TEntity> FindAsync(Guid id);

        public Task CreateAsync(TEntity entity);

        public Task UpdateAsync(TEntity entity);

        public Task DeleteAsync(TEntity entity);
    }
}