﻿using DaatAccessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaatAccessLayer.EntityFramework
{
	public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
	{
	}
}
