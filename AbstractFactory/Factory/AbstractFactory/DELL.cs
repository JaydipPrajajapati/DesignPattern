﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory.AbstractFactory
{
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.DELL.ToString();
        }
    }
}
