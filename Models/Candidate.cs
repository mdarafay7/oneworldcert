using oneworldcert.misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace oneworldcert.Models
{
    public class Candidate
    {

        public int ID { get; set; }
        [Required]
        public String OwnerID { get; set; }

        [Required]

        public String LName { get; set; }
        [Required]

        public String Fname { get; set; }

        public String MInit { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        [Required]
        public Address Address { get; set; }

    }
}
