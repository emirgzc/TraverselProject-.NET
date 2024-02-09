using DaatAccessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaatAccessLayer.EntityFramework
{
	public class EfReservationRepository : GenericRepository<Reservation>, IReservationDal
	{
		public List<Reservation> GetReservationForAppUser(int id)
		{
			using (var c = new Context())
			{
				return c.Reservations.Include(x => x.Destination).Include(x => x.AppUser).Include(z => z.ReserStatus).Where(y=>y.AppUserId==id).ToList();
			}
		}

		public List<Reservation> GetResListByStatusWithDest(int userId, int statusId)
		{
			using (var c = new Context())
			{
				return c.Reservations.Include(x => x.ReserStatus).Include(y => y.Destination).Where(z => z.AppUserId == userId).Where(c => c.ReserStatusID == statusId).ToList();
			}
		}
	}
}
