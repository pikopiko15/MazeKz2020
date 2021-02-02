using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.Models.Energy
{
    public class ConsumerProfileViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public bool IsDebtor { get; set; }

        public double AmountOfDebt { get; set; }
    }
}
