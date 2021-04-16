using System;

    class program
    {
        public static void Main(String[] args)
        {
            Operacao op = new Operacao();

            String escolha;
            double num1, num2, resultado;

            Console.Write("digite um numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite outro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("[+]somar \n[-]subtrair \n[*]multiplicar \n[/]dividir \n escolha a operaçao: ");
            escolha = Console.ReadLine();

            if(string.Equals(escolha, "+"))
            {
                resultado = op.somar(num1, num2);
            }

            else if(string.Equals(escolha, "-"))
            {
                resultado = op.subtrair(num1, num2);
            }

             else if(string.Equals(escolha, "*"))
            {
                resultado = op.multiplicar(num1, num2);
            }

             else
            {
                resultado = op.dividir(num1, num2);
            }
            Console.WriteLine("o resultado é igual a: "+ resultado);

        }
    }