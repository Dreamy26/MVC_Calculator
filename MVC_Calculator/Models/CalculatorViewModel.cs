using System;
namespace MVC_Calculator.Models
{
   
    public class CalculatorViewModel
    {
        // creating properties for Num1, Num2, & operation 
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public string Operation { get; set; }

        // creating methods within the CalculatorViewModel Class-- refrenceing Operations Values: Plus, Minus, Multiply, Divide

        public double Add()
        {
            return Num1 + Num2;
        }

        public double Minus()
        {
            return Num1 - Num2;
        }

        public double Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            return Num1 / Num2;
        }


    }
}
