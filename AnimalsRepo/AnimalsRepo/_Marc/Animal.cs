using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AnimalsRepo
{

    /// <summary>
    /// Represent abstract representation of any animal.
    /// </summary>
    public abstract partial class Animal : IHealth
    {


        
        /// <summary>
        /// Describes if a animal is moving.
        /// </summary>
        public bool InMovement { get; set; }


        private bool _isFeeded;


        /// <summary>
        /// Describes if a animal is feeded.
        /// </summary>        
        public bool IsFeeded
        {
            get { return _isFeeded; }
            set
            {
                if (value == _isFeeded)
                    return;

                _isFeeded = value;

                Debug.WriteLine("Animal is feeded property changed.");
            }
        }




        /// <summary>
        /// Dedscribes if a animas is hungry.
        /// </summary>
        public bool IsHungry { get; protected set; }




        /// <summary>
        /// Describes the weight of animal.
        /// </summary>
        public float Weight { get; set; }





        public bool IsHealthy
        {
            get
            {                
                return this.Illness != null && this.Illness == IllnessBase.Empty;
            }
        }

        
        public IllnessBase Illness { get; set; }        



        public void OnMovement()
        {
            if (this.InMovement)
            {
                Console.WriteLine("Animal is in movement");

            }
            else
            {
                Console.WriteLine("Animal is sleeping");
            }
        }


  
    }
}

