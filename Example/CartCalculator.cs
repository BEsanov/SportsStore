﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example;
namespace Example
{
  public  class CartCalculator
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }
      

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
