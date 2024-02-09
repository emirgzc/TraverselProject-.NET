using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
		List<Comment> GetCommentListByID(int id);
		List<Comment> GetCommentForAppUser(int id);
		List<Comment> GetCommentForAppUserWithDestination(int id);

    }
}
