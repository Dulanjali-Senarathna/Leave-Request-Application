namespace Leave_Request_Application.Contracts
{
    //creating generic interface
    public interface IGenericRepository<T> where T : class //T has to me a class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task <T> AddAsync(T entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

    }
}
