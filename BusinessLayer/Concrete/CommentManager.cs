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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

        public List<Comment> GetByFilterList(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

		public List<Comment> GetCommentForAppUser(int id)
		{
			return _commentDal.GetCommentForAppUser(id);
		}

        public List<Comment> GetCommentForAppUserWithDestination(int id)
        {
            return _commentDal.GetCommentForAppUserWithDestination(id);
        }

        public List<Comment> GetCommentListByID(int id)
		{
			return _commentDal.GetListByFilter(x=>x.DestinationID==id);
		}

		public void TAdd(Comment t)
		{
			_commentDal.Insert(t);
		}

		public void TDelete(Comment t)
		{
			_commentDal.Delete(t);
		}

		public Comment TGetByID(int id)
		{
			return _commentDal.GetById(id);
		}

		public List<Comment> TGetList()
		{
			return _commentDal.GetCommentForDestination();
		}

		public void TUpdate(Comment t)
		{
			_commentDal.Update(t);
		}
	}
}
