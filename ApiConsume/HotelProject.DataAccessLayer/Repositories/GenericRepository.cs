using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            this._context = context;
        }

        public void Delete(T t)
        {
            this._context.Remove(t);
            this._context.SaveChanges();
        }

        public T GetById(int id)
        {
            return this._context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return this._context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            this._context.Add(t);
            this._context.SaveChanges();
        }

        public void Update(T t)
        {
            this._context.Update(t);
            this._context.SaveChanges();
        }
    }
}
