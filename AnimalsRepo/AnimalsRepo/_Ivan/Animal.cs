using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsRepo
{

    /// <summary>
    /// Represent abstract representation of any animal.
    /// </summary>
    public abstract partial class Animal
    {
        /// <summary>
        /// Describes if a animal is moving.
        /// </summary>
        bool InMovement { get; set; }
    }
}
