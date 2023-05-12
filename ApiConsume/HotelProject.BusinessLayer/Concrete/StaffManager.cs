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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff t)
        {
            this._staffDal.Delete(t);
        }

        public Staff TGetById(int id)
        {
            return this._staffDal.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return this._staffDal.GetList();
        }

        public void TInsert(Staff t)
        {
            this._staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            this._staffDal.Update(t);
        }
    }
}
