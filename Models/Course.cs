using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace oneworldcert.Models
{
    public class Course
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Catagory ID")]
        public string CatagoryID { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal StandardPrice { get; set; }


    }
}
