﻿using System;

namespace LABA2
{
    public class Taylor
    {
        public double Pow(double x, int n)
        {
            if (n < 0)
            {
                return -1;
            }

            double result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= x;
            }

            return result;
        }

        public double Abs(double x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            return x;
        }
        public double Sqrt(double x, double epsilon = 1e-15)
        {
            if (x < 0)
            {
                return -1;
            }

            double guess = x / 2;
            while (Abs(guess * guess - x) > epsilon)
            {
                guess = (guess + x / guess) / 2;
            }

            return guess;
        }
        public long Factorial(long n)
        {
            if (n < 0 || n > 20)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
                return n * Factorial(n - 1);
        }

        public double Sin(double x)
        {
            if (x > 4 || x < -4)
            {
                return -1;
            }
            double result = 0;
            for (int n = 0; n < 10; n++)
            {
                double term = Pow(-1, n) * Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
                result += term;
            }
            return result;
        }


        public double Cos(double x)
        {
            if (x > 4 || x < -4)
            {
                return -1;
            }
            double result = 0;
            for (int n = 0; n < 10; n++)
            {
                double term = Pow(-1, n) * Pow(x, 2 * n) / Factorial(2 * n);
                result += term;
            }
            return result;
        }

        public double Log(double x)
        {
            if (x <= 0 || x >= 2)
            {
                return -1;
            }

            double result = 0;
            for (int n = 1; n <= 200; n++)
            {
                double term = Pow(-1, n - 1) * Pow(x - 1, n) / n;
                result += term;
            }
            return result;
        }

        public double firstStmt(double x)
        {
            if (x >= 0 || x < -4)
            {
                return -1;
            }
            double sin = Sin(x);
            double sin2 = Pow(Sin(x), 2);
            double cos2 = Pow(Cos(x), 2);
            double log = Log(sin);
            double fir = sin2 + cos2 + log;
            return fir;
        }

        public double secondStmt(double x)
        {
            if (x <= 0 || x > 5)
            {
                return -1;
            }
            double pow = Pow(x, 2);
            double sin = Sin(pow);
            double log = Log(pow);
            double cos = Cos(log);
            double underSqrt = sin + cos;
            if (underSqrt < 0)
            {
                return -2;
            }
            return Sqrt(underSqrt);
        }

        public double fX(double x)
        {
            if (x < 0)
            {
                return firstStmt(x);
            }
            return secondStmt(x);
        }
        static void Main()
        {

        }
    }
//proverka komita
}
