using SamiFitnessBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiFitnessBL.Controller
{
    public class UserController
    {
        public User user { get; }
        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен Null", nameof(user));
        }
        public bool Save()
        {

        }
    }
}
