using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW01.Data.ISW01Repository
{
    public interface IPersonReository : IGenericRepository<Person>,IDisposable
    {
    }
}
