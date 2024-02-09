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
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
		public List<Comment> GetCommentForAppUser(int id)
		{
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.AppUser).Include(y => y.Destination).Where(z => z.AppUserId == id).ToList();
            }
		}

        public List<Comment> GetCommentForAppUserWithDestination(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.AppUser).Where(z => z.DestinationID == id).ToList();
            }
        }

        public List<Comment> GetCommentForDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }
    }
}
