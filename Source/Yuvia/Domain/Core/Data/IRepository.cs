using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuvia.Core.Data
{
    public interface IRepository<T>
    {
        void Insert( T entity );
        T Get( object id );
        void Update( T entity );
    }
}
