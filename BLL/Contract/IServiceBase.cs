using Provider.DAL.Entities;

namespace Provider.BLL.Contract
{
    public interface IServiceBase<T>
        where T : EntityBase
    {
        void Create(T entity);
        void Delete(long id);
        T Get(long id);
        void Update(T entity);
    }

}
