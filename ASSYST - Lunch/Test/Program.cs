using Domain.Concrete;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EFUserRepository efUser = new EFUserRepository();

                IList<User> users = efUser.Users.ToList();

                Console.WriteLine(users.Count);

                foreach(User u in users)
                {
                    Console.WriteLine(u.Firstname);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
