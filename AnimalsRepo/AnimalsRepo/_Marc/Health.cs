using System;
using System.Diagnostics;

namespace AnimalsRepo
{
    /// <summary>
    /// Represent the health of any animal.
    /// </summary>
    public interface IHealth
    {
        bool IsHealthy { get; }

        IllnessBase Illness { get; }
    }


    [Obsolete("Es necesario implementar esta clase.")]
    public class IllnessBase
    {


        // Static constructor
        static IllnessBase()
        {
            _empty = new IllnessBase() { LeukocytesLevel = 23.5 };
            
        }









        private double _leukocytesLevel;

        public double LeukocytesLevel
        {
            get { return _leukocytesLevel; }
            set
            {
                if (value == _leukocytesLevel)
                    return;

                _leukocytesLevel = value;

                var message = String.Format("{0} leukocytes level changed.", this.GetType().Name);
                Debug.WriteLine(message);
                
                //this.LastMessage = message;
            }
        }


#warning deber => hacer evento que informa sobre el estado que define que ha cambiado en ni.lec. y cual es su nivel acual
#warning deber => a traves de EVENTOS hacer que el cerebro hace caminar







        public static IllnessBase Empty
        {
            get { return _empty; }
        }



        internal static IllnessBase _empty;
    }
}

