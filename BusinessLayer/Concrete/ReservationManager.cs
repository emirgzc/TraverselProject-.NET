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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetByFilterList(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListStatusReservation(int userId, int statusId)
        {
            return _reservationDal.GetResListByStatusWithDest(userId,statusId);
        }

		public List<Reservation> GetReservationForAppUser(int id)
		{
            return _reservationDal.GetReservationForAppUser(id);
		}

		public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
