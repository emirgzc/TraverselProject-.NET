﻿using BusinessLayer.Abstract;
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
	public class AnnouncementManager: IAnnouncementService
	{
		private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public List<Announcement> GetByFilterList(Expression<Func<Announcement, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Announcement t)
		{
			_announcementDal.Insert(t);
		}

		public void TDelete(Announcement t)
		{
			_announcementDal.Delete(t);
		}

		public Announcement TGetByID(int id)
		{
			return _announcementDal.GetById(id);
		}

		public List<Announcement> TGetList()
		{
			return _announcementDal.GetList();
		}

		public void TUpdate(Announcement t)
		{
			_announcementDal.Update(t);
		}
	}
}