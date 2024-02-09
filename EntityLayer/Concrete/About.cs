using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string TitleOne { get; set; }
        public string TitleTWo { get; set; }
        public string Description { get; set; }
        public string DescriptionTwo { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        public bool Status { get; set; }
    }
}
