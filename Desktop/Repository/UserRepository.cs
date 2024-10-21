using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Desktop.Repository
{
   internal class UserRepository
    {
        private List<UserModel> _users = new List<UserModel>()
        {
        new UserModel {Name = "Lukoshko", Email = "", Password = ""}
        };
    }
}
