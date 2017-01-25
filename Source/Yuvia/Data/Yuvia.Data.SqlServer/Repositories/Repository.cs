using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuvia.Data.SqlServer.EntityFramework;

namespace Yuvia.Data.SqlServer.Repositories
{
    public class Repository
    {
        protected readonly YuviaDataConnection dataContext;

        public Repository()
        {
            dataContext = new YuviaDataConnection();
        }

        ~Repository()
        {
            
            dataContext.Dispose();
        }
    }
}
