using System;
using System.Collections.Generic;
using System.Text;

namespace AppBusinessLogic.Model
{
    class User
    {
        // I will only get; this property (I can only set the name once when creating an instance of this class)
        // get; - readonly property that allows to set it once in the constructor. In the future, I will not change it.
        public string Name { get; }
        // there is no way to change the gender and name in the future
        public Gender Gender { get;}
        public DateTime BirthDate { get; }
        // The user's weight will change
        public double Weight { get; set; }
        public double Height { get; set; }

        // creating a constructor for the user
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            // validation of input parameters
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name cannot be empty or null", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Gender cannot be null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900"))
            {
            }
            if (weight <= 0)
            {
            }
            if (height <= 0)
            {

            }

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }



    }
}
