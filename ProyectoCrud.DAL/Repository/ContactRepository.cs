using Microsoft.EntityFrameworkCore;
using ProyectoCrud.DAL.DataContext;
using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repository
{
    public class ContactRepository : IGenericRepository<Contacto>
    {
        private readonly DbcrudcoreContext _dbContext;
        public ContactRepository(DbcrudcoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Update(Contacto model)
        {
            _dbContext.Contactos.Update(model);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int idU)
        {
            Contacto model = _dbContext.Contactos.First(c => c.IdContacto == idU);
            _dbContext.Contactos.Remove(model);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insert(Contacto model)
        {
            _dbContext.Contactos.Add(model);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Contacto> Get(int idU)
        {
            //return await _dbContext.Contactos.FindAsync(idU);
            return await _dbContext.Contactos.FirstAsync(c => c.IdContacto == idU);
        }

        public async Task<IQueryable<Contacto>> GetAll()
        {
            IQueryable<Contacto> queryRequest = _dbContext.Contactos;
            return queryRequest;
        }
    }
}
