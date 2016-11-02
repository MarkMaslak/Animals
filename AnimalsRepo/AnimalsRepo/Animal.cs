using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsRepo
{

    /// <summary>
    /// Represent abstract representation of any animal.
    /// </summary>
    public abstract class Animal
    {

        /// <summary>
        /// Represents heart - internal organ.
        /// </summary>
        public Heart Heart { get; set; }
    }
}
