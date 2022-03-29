using System;
using System.Collections.Generic;
using System.Text;

namespace AppBusinessLogic.Model
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        #region Properties hidden by #region
        /// <summary>
        /// Name
        /// </summary>
        // I will only get; this property (I can only set the name once when creating an instance of this class)
        // get; - readonly property that allows to set it once in the constructor. In the future, I will not change it.
        public string Name { get; }
        /// <summary>
        /// Gender
        /// </summary>
        // there is no way to change the gender and name in the future
        public Gender Gender { get;}
        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Weight
        /// </summary>
        // The user's weight will change
        public double Weight { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        public double Height { get; set; }
        #endregion

        // creating a constructor for the user
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="name"> Name </param>
        /// <param name="gender"> Gender </param>
        /// <param name="birthDate"> Date of Birth </param>
        /// <param name="weight"> Weight </param>
        /// <param name="height"> Height </param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            #region Checking conditions using #region
            // validation of input parameters
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name cannot be empty or null.", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Gender cannot be null.", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Invalid date of birth.", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentNullException("Weight cannot be less than or equal to zero.", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentNullException("Height cannot be less than or equal to zero.", nameof(height));
            }
            #endregion
           
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        // Redefining "ToString"
        public override string ToString()
        {
            return Name;
        }



    }
}
