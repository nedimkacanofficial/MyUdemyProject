using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public void TDelete(Service t)
        {
            this.serviceDal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return this.serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return this.serviceDal.GetList();
        }

        public void TInsert(Service t)
        {
            this.serviceDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            this.serviceDal.Update(t);
        }
    }
}
