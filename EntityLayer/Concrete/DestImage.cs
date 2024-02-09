using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class DestImage
	{
		[Key]
        public int DestImageID { get; set; }		
		public string Image { get; set; }
        public bool Status { get; set; }
        public DateTime ImageDate { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
