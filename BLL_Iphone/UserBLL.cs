using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_IPhone;

namespace BLL_Iphone
{
    public class UserBLL
    {
        private List<User> users = new List<User>();
        public UserBLL()
        {
            users = new List<User>()
            {
                new User()
                {
                    UserName = "user1",
                    Password = "123456"
                },
                new User()
                {
                    UserName = "user2",
                    Password = "123456"
                }
            };
        }
        //method không hướng đến properties
        public string register(User user)
        {
            //insert db
            users.Add(user);

            return "guest";
        }

        //trả về ds user, lấy tất cả ds User
        public List<User> getAllUsers()
        {
            return users;
        }
        public bool RemoveUser(string userName)
        {
            foreach (User us in users)
            {
                if (us.UserName == userName)
                {
                    users.Remove(us);
                    return true;
                }
            }
            return false;
        }
        public void updatePassword(User u, string newPass)
        {
            //update db
            foreach (User us in users)
            {
                if (us.UserName == u.UserName)
                {
                    us.Password = newPass;
                    break;
                }
            }
        }

    }
}

