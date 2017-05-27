namespace Yuvia.Domain.Core.Data
{
    public interface IRepository<T>
    {
        void Insert( T entity );
        T Get( object id );
        void Update( T entity );
    }
}
