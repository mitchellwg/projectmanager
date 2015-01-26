namespace Dapper.Repositories {
    public interface IRepository<T> where T : IEntity
    {
        T Get(int id);
        bool Update(T item);
        bool Delete(T item);
        T Insert(T item);
    }
}