
namespace DataAcecess
{


    interface IRepository<T> where T : class
    {
        List<T> Entities { get; }
        void CreateOne(T entity);
        void UpdateOne(int id, T entity);
        void DeleteOne(int id);
        void GetAlll();
        T GetOne(int id);
    }
}
