using AppBusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace AppBusinessLogic.Controller
{
    /// <summary>
    /// User controller
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Application User
        /// </summary>
        // Defining a property that will work with a particular user
        public User User { get; }
        /// <summary>
        /// Creating a New User Controller
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            // TODO: Check
            var gender = new Gender(genderName);
            var user = new User(userName, gender, birthDay, weight, height);
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                // The construction allows us to get a deserialized object into a variable
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                // TODO: What to do if can't read user?
            }
        }
        // making it possible to save the data of user
        // Additional check whether it was saved or not
        // serialization
        /// <summary>
        /// Save user data
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        // deserialization
        /// <summary>
        /// Get user data
        /// </summary>
        /// <returns> Application User </returns>
    }
}
