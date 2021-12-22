using System;

    class program
    {
        public static void Main(String[] args)
        {
            char simbolo;
            double num1, num2, resultado = 0;

            Console.Write("digite um numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite outro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("[+]somar \n[-]subtrair \n[*]multiplicar \n[/]dividir \nsimbolo a operaçao: ");
            simbolo = Convert.ToChar(Console.ReadLine());

            switch(simbolo)
            {
                case '+':
                    resultado = num1 + num2;
                break;

                case '-':
                    resultado = num1 - num2;
                break;

                case '*':
                    resultado = num1 * num2;
                break;

                case '/':
                    resultado = num1 / num2;
                break;

                default:
                    Console.WriteLine("voce digitou errado. Por favor, reinicie o programa e tente novamente.");
                break;
            }

            Console.WriteLine($"{num1} {simbolo} {num2} = {resultado} ");
        }
    }
