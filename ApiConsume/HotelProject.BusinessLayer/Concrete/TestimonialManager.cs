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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            this._testimonialDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return this._testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return this._testimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            this._testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            this._testimonialDal.Update(t);
        }
    }
}
