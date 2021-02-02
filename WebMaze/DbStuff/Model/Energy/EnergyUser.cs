using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMaze.DbStuff.Model.Energy
{
    public class EnergyUser : BaseModel
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }

        public virtual bool? IsDebtor { get; set; }

        public virtual double AmountOfDebt { get; set; }
    }
}
