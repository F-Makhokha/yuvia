using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuvia.Core
{
    public interface IRepository<T>
    {
        void Insert( T entity );
        void Get( object id );
        void Update( T entity );
    }
}
