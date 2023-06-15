using hearing_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternUOW.Core.interfaces
{
    public class BaseRepo<T>: IBaseRepo<T> where T:class
    {
        private readonly ApplicationDBContext _context;
        public BaseRepo(ApplicationDBContext context)
        {
            _context = context;
        }
        public T GEtById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
