using System;
using System.Collections.Generic;
using System.Text;

namespace AppBusinessLogic.Model
{
    /// <summary>
    /// Gender
    /// </summary>\
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Creating a new gender
        /// </summary>
        /// <param name="name"> Name of Gender </param>
        //for gender I create a constructor
        public Gender(string name)
        {
            // check input arguments(conditions)
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The gender name cannot be empty or null", nameof(name));
            }

            // Making an assignment
            Name = name;
        }
        // redefine method to string

        public override string ToString()
        {
            return Name;
        }

    }
}
