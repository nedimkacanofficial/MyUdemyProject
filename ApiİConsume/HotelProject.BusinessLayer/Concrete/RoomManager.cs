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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            this._roomDal.Delete(t);
        }

        public Room TGetById(int id)
        {
            return this._roomDal.GetById(id);

        }

        public List<Room> TGetList()
        {
            return this._roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            this._roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            this._roomDal.Update(t);
        }
    }
}
