using AppBusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBusinessLogic.Controller
{
    public class UserController
    {
        // Defining a property that will work with a particular user
        public User User { get; }
        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("User cannot be equal Null", nameof(user));
        }
        // making it possible to save the data of user
        public bool Save()
        {

        }
    }
}
