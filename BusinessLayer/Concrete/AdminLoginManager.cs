﻿using BusinessLayer.Abstract;
using DaatAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AdminLoginManager : IAdminLoginService
	{
		IAdminDal _adminDal;

		public AdminLoginManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public Admin GetAdmin(string username, string password)
		{
			return _adminDal.Get(x => x.Username == username && x.Password == password);
		}
	}
}
