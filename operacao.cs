using System;

class Operacao 
    {
        public double somar(double num1, double num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            double result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }

        public double subtrair(double num1, double num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            double result = num1 - num2;
            Console.WriteLine(result);
            return result;
        }

        public double multiplicar(double num1, double num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            double result = num1 * num2;
            Console.WriteLine(result);
            return result;
        }

        public double dividir(double num1, double num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            double result = num1 / num2;
            Console.WriteLine(result);
            return result;
        }
    }