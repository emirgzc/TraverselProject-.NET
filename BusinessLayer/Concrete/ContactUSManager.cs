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
	public class ContactUSManager : IContactUSService
	{
		IContactUSDal _contactUSDal;

		public ContactUSManager(IContactUSDal contactUSDal)
		{
			_contactUSDal = contactUSDal;
		}

		public List<ContactUS> GetByFilterList(Expression<Func<ContactUS, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<ContactUS> GetContactUSByID(int id)
		{
			return _contactUSDal.GetListByFilter(x=>x.ContactUSID == id);
		}

		public void TAdd(ContactUS t)
		{
			_contactUSDal.Insert(t);
		}

		public void TDelete(ContactUS t)
		{
			_contactUSDal.Delete(t);
		}

		public ContactUS TGetByID(int id)
		{
			return _contactUSDal.GetById(id);
		}

		public List<ContactUS> TGetList()
		{
			return _contactUSDal.GetList();
		}

		public void TUpdate(ContactUS t)
		{
			_contactUSDal.Update(t);
		}
	}
}
