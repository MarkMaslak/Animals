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
        /// Informs if blood pump is working.
        /// </summary>
        public bool IsHeartWorking { get; set; }
    }
}
