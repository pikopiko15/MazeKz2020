using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMaze.DbStuff.Model.Energy;

namespace WebMaze.DbStuff.Repository
{
    public class EnergyUserRepository : BaseRepository<EnergyUser>
    {
        public EnergyUserRepository(WebMazeContext context) : base(context) { }

        public EnergyUser FindExistingEnergyUser(string name)
        {
            return dbSet.SingleOrDefault(x => x.FirstName == name);
        }

        public IEnumerable<EnergyUser> GetUserWithHome()
        {
            return dbSet.Where(x => x.Address.Count() > 0);
        }

        public EnergyUser GetUserByLastName(string name)
        {
            return dbSet.FirstOrDefault(x => x.LastName == name);
        }

        public EnergyUser GetUserByPhoneNumberAndDebt(string number, bool hasDebt)
        {
            return dbSet.SingleOrDefault(x => x.PhoneNumber == number && x.IsDebtor == hasDebt);
        }
    }
}
