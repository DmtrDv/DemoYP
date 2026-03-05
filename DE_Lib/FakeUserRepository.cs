using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Lib
{
    public class FakeUserRepository
    {
        private List<User> allUsers_ = new List<User>()
        {
            new User {role = UserRole.Администратор, fio = "Человек1", login = "chel@gmail.com", password = "12345"},
            new User {role = UserRole.Менеджер, fio = "Человек2", login = "chel2@gmail.com", password = "1234"},
            new User {role = UserRole.Клиент, fio = "Человек3", login = "chel3@gmail.com", password = "123"}
        };

        public List<User> getAllUser()
        {
            return allUsers_;
        }
        public User getUserByLogin(string login)
        {
            foreach (User user in allUsers_)
            {
                if (user.login == login)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
