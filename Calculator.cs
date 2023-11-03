using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_
{
    class Calculator
    {
        private double a = 0;
        private double memory = 0;

        public void PutA(double a)
        {
            this.a = a;
        }

        public void ClearA()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b)
        {
            return a - b;
        }

        public double Sqrt(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double Pow(double b)
        {
            return Math.Pow(a, b);
        }

        public double DivisionModule(double b)
        {
            return a % b;
        }

        public double Fraction()
        {
            return 1 / a;
        }

        public double Abs()
        {
            return Math.Abs(a);
        }

        public double Int()
        {
            return Math.Round(a);
        }

        public double CInt()
        {
            return Math.Ceiling(a);

        }

        public double Factorial()
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }

        public double MemoryShow()
        {
            return memory;
        }

        public void Memory_Clear()
        {
            memory = 0.0;
        }

        public void M_Multiplication(double b)
        {
            memory *= b;
        }

        public void M_Division(double b)
        {
            memory /= b;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }
    }
}
