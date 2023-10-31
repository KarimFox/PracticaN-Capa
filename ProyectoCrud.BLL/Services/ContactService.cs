using ProyectoCrud.DAL.Repository;
using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.BLL.Services
{
    internal class ContactService: IContactService
    {
        private readonly IGenericRepository<Contacto> _genericRepository;
        public ContactService(IGenericRepository<Contacto> foxy)
        {
            _genericRepository = foxy;
        }

        public async Task<bool> Update(Contacto model)
        {
            return await _genericRepository.Update(model);
        }
        public async Task<bool> Delete(int idU)
        {
            return await _genericRepository.Delete(idU);
        }
        public async Task<bool> Insert(Contacto model)
        {
            return await _genericRepository.Insert(model);
        }
        public async Task<Contacto> Get(int idU)
        {
            return await _genericRepository.Get(idU);
        }
        public async Task<IQueryable<Contacto>> GetAll()
        {
            return await _genericRepository.GetAll();
        }


        public async Task<Contacto> GetByName(string name)
        {
            IQueryable<Contacto> queryRequest = await _genericRepository.GetAll();
            Contacto fox = queryRequest.Where(c=>c.Nombre == name).FirstOrDefault();
            return fox;
        }

    }
}
