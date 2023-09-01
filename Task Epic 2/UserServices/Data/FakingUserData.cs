using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMe.Data
{
    public class FakingUserData
    {
        public List<User> Users = new List<User>();

        public FakingUserData()
        {
            Users.Add(new User("Beer", "password"));
        }
    }
}
