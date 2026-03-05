using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Lib
{
    public class UserModel
    {
        private FakeUserRepository userRepository = new FakeUserRepository();

        public List<string> getAllLogins()
        {
            List<User> allUsers = userRepository.getAllUser();
            List<string> allLogins = new List<string>();
            foreach (User user in allUsers)
            {
                allLogins.Add(user.login);
            }
            return allLogins;
        }
        public User Authorization(string login, string password)
        {
            User user = userRepository.getUserByLogin(login);
            if (user == null)
            {
                return null;
            }
            if (user.password == password)
            {
                return user;
            }
            return null;
        }
    }
}
