using System;

    class program
    {
        public static void Main(String[] args)
        {
            char escolha;
            double num1, num2;

            Console.Write("digite um numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite outro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("[+]somar \n[-]subtrair \n[*]multiplicar \n[/]dividir \n escolha a operaçao: ");
            escolha = Convert.ToChar(Console.ReadLine());

            switch(escolha)
            {
                case '+':
                    Console.WriteLine("a soma é igual a: "+ (num1 + num2));
                break;

                case '-':
                    Console.WriteLine("a subtração é igual a: "+ (num1 - num2));
                break;

                case '*':
                    Console.WriteLine("a multiplicação é igual a: "+ (num1 * num2));
                break;

                case '/':
                    Console.WriteLine("a divisão é igual a: "+ (num1 / num2));
                break;

                default:
                    Console.WriteLine("voce digitou errado. Por favor, reinicie o programa e tente novamente.");
                break;
            }
        }
    }
