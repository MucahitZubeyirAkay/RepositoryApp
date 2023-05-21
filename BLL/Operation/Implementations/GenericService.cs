using BLL.Operation.Interface;
using DAL.Interface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Operation.Implementations
{
    public class GenericService<T> : IGenericService<T>
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(T entity)
        {
          _repository.Add(entity);
        }

        public void Update(T entity)
        {
           _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }

}
