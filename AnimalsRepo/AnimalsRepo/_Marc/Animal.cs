using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsRepo
{

    /// <summary>
    /// Represent abstract representation of any animal.
    /// </summary>
    public abstract partial class Animal : Health
    {
        /// <summary>
        /// Describes if a animal is moving.
        /// </summary>
        bool InMovement { get; set; }
        /// <summary>
        /// Describes if a animal is feeded.
        /// </summary>
        bool IsFeeded { get; set; }

        /// <summary>
        /// Describes the weight of animal.
        /// </summary>
        float weight { get; set; }


        public void OnMovement()
        {
            if (this.InMovement)
            {
                Console.WriteLine("Animal is in movement");

            }
            else
            {
                Console.WriteLine("Animal is sleeping")
            }
        };

        public void isFeeded()
        {
            if (this.isFeeded)
            {
                Console.WriteLine("Animal is feeded");
                return true;
            }
            else
            {
                Console.WriteLine("Animal is hungry")
            }
        };
    }
}

