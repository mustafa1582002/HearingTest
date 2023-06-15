using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.Core.interfaces
{
    public interface IBaseRepo<T> where T : class
    {
        T GEtById(int id);

    }
}
