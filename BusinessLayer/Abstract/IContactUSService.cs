using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IContactUSService : IGenericService<ContactUS>
	{
		List<ContactUS> GetContactUSByID(int id);
	}
}
