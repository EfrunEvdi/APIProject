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
        private readonly ITestimonialDal _testimanialDal;

        public TestimonialManager(ITestimonialDal testimanialDal)
        {
            _testimanialDal = testimanialDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimanialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimanialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimanialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimanialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimanialDal.Update(t);
        }
    }
}
