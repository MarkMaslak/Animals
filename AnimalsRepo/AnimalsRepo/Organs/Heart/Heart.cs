using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsRepo
{
    public abstract class Heart : IBloodPompeable
    {
        public Heart()
        {
            throw new NotImplementedException();
        }


        public bool IsPumping
        {
            get
            {
                return _isPumping;
            }
        }


        #region Fields

        bool _isPumping;

        #endregion

    }
}
