using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_IPhone
{
    public class User
    {
        //khai niem properties
        public string UserName { get; set; }
        public string Password { get; set; }

        //constructor(có tên giống tên class)
        public User()
        {

        }
        public User(string name, string pass)
        {
            UserName = name;
            Password = pass;
        }
    }
}
