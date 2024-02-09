using BusinessLayer.Abstract;
using DaatAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AdminManager : IAdminService
	{
		IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public List<Admin> GetByFilterList(Expression<Func<Admin, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Admin t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Admin t)
		{
			throw new NotImplementedException();
		}

		public Admin TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Admin> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Admin t)
		{
			throw new NotImplementedException();
		}
	}
}
