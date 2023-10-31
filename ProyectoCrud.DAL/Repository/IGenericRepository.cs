using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        Task<bool> Insert(T model);
        Task<bool> Update(T model);
        Task<T> Get(int idU);
        Task<bool> Delete(int idU);
        Task<IQueryable<T>> GetAll();

    }
}
