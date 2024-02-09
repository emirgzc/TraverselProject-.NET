using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class TestimonialsManager : ITestimonialService
	{
		ITestimonialDal _testimonialDal;

		public TestimonialsManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

        public List<Testimonial> GetByFilterList(Expression<Func<Testimonial, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial t)
		{
			_testimonialDal.Insert(t);
		}

		public void TDelete(Testimonial t)
		{
			_testimonialDal.Delete(t);
		}

		public Testimonial TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Testimonial> TGetList()
		{
			return _testimonialDal.GetList();
		}

		public void TUpdate(Testimonial t)
		{
			_testimonialDal.Update(t);
		}
	}
}
