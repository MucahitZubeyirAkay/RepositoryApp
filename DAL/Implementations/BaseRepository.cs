using DAL.Context;
using DAL.Interface.Abstract;
using Microsoft.EntityFrameworkCore;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class BaseRepository<T> : IGenericRepository<T> where T : class, new()
    {

        public T GetById(int id)
        {
            using (var repositoryDbContext = new RepositoryDbContext())
            {
                return repositoryDbContext.Set<T>().Find(id);
            }
        }

        public List<T> GetAll()
        {
            using (var repositoryDbContext = new RepositoryDbContext())
            {
                return repositoryDbContext.Set<T>().ToList();
            }
        }

        public void Add(T entity)
        {
            using (var repositoryDbContext = new RepositoryDbContext())
            {
                repositoryDbContext.Set<T>().Add(entity);
                repositoryDbContext.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var repositoryDbContext = new RepositoryDbContext())
            {
                repositoryDbContext.Entry(entity).State = EntityState.Modified;
                repositoryDbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var repositoryDbContext = new RepositoryDbContext())
            {
                var delete = GetById(id);
                repositoryDbContext.Remove<T>(delete);
                repositoryDbContext.SaveChanges();
            }
        }
    }

}
    

