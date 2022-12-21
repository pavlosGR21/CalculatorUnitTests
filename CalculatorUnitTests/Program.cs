﻿using Calculator.Models;
using CalculatorUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticCalculations arithmeticCaclulations = new ArithmeticCalculations(new NumberValidator());

            //NumberValidator.Precision = 1;
            //Console.WriteLine(arithmeticCaclulations.Add(-int.MaxValue, -int.MaxValue));
            arithmeticCaclulations.Subtract(1, 1);
            arithmeticCaclulations.Multiply(1, 1);
            arithmeticCaclulations.Divide(22, 0);
            //arithmeticCaclulations.DoOperation(1, 2, ArithmeticOperations.ADD);
        }
    }
}
