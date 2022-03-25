namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        // get one record
        Task<T> GetAsync(int? id);
        /// get all the records      
        Task<List<T>> GetAllAsync();
        // http post/create/insert
        Task<T> AddAsync(T entity);
        // delete record
        Task DeleteAsync(int id);
        // http put/update
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
