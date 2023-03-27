namespace Leave_Request_Application.Contracts
{
    //creating genaric interface
    public interface IGenaricRepository<T> where T : class //T has to me a class
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task <int> GetCountAsync();
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);

    }
}
