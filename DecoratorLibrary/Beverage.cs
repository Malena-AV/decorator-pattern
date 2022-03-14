﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public abstract class Beverage
    {
        public string description;
        public abstract double Cost();
        public virtual string GetDescription()
        {
            return description + " " + Cost();
        }

    }   
}
