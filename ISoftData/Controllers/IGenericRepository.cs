using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISoftData.Controllers
{
    public interface IGenericRepository<T>
    {
         IQueryable<T> GetAll();
         T GetAllbyID(int ID);

        bool Create(T models);

        bool Update(T models);
        bool Update(T models, int ID);

        bool Delete(T Models);

    }
}
