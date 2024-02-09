    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ReserStatus
    {
        [Key]
        public int ReserStatusID { get; set; }
        public string ReserStatusName { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
