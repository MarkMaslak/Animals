﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsRepo
{
    public abstract partial class Vertebrate : Animal
    {
        public Heart Heart { get; set; }

    }
}
