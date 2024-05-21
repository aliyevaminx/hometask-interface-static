﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_interface_static
{
    internal interface ICalculator
    {
        double Sum(double x, double y);
        double Subtract(double x, double y);
        double Divide(double x, double y);
        double Multiply(double x, double y);
    }
}
