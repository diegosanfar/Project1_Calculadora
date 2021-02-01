using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Fatorial, Fibonacci, Binario, Sair}
        static void Main(string[] args)
        {
            bool finalizar = false;
            while (!finalizar)
            {
                Console.WriteLine("Bem-vindo a calculadora. Selecione uma opção: ");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Fatorial\n8-Fibonacci\n9-Binário\n10-Sair");

                
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtrai();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multi();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Fatorial:
                        Fator();
                        break;
                    case Menu.Fibonacci:
                        Fibo();
                        break;
                    case Menu.Sair:
                        finalizar = true;
                        break;
                    

                }

                Console.Clear();

            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            char z = 'a';
            float a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Digite o primeiro número: ");
                string x = Console.ReadLine();
                try
                {
                    a = float.Parse(x);
                    z = 'b';
                }
                catch (FormatException)
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            char y = 'a';
            float b = 0;
            while (y == 'a')
            {
                Console.WriteLine("Digite o segundo número: ");
                string k = Console.ReadLine();
                try
                {
                    b = float.Parse(k);
                    y = 'b';
                }
                catch (FormatException)
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
        
            float soma = a + b;
            Console.WriteLine($"O resultado da soma é: {soma}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Subtrai()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float subtrai = a - b;
            Console.WriteLine($"O resultado da subtração é: {subtrai}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float divisao = a / b;
            Console.WriteLine($"O resultado da divisão é: {divisao}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());
            float multi = a * b; ;
            Console.WriteLine($"O resultado da multiplicação é: {multi}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de dois números: ");
            Console.WriteLine("Digite a base: ");
            float Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            float Potencia = float.Parse(Console.ReadLine());
            double resultado = Math.Pow(Base,Potencia); 
            Console.WriteLine($"O resultado da potência é: {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz quadrada de um número: ");
            Console.WriteLine("Informe o número: ");
            float a = float.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da raiz é: {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Fator()
        {
            Console.WriteLine("Fatorial de um número: ");
            Console.WriteLine("Informe o número: ");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int resultado = 1;
            for (b = 1; b <= a; b++)
            {
               resultado *= b;
            }
            Console.WriteLine($"O resultado do fatorial de {a} é: {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }

        static void Fibo()
        {
            Console.WriteLine("Sequência de Fibonacci: ");
            Console.WriteLine("Informe a posição da contagem: ");
            int a = int.Parse(Console.ReadLine());
            int[] resultado = new int[a];
            if (a == 0)
            {
                Console.WriteLine("Posição inválida.");
                Console.ReadLine();
            }
            else if (a == 1)
            {
                Console.WriteLine("O número fibonacci dessa posição é: 0");
                Console.WriteLine("Aperte qualquer tecla para voltar.");
                Console.ReadLine();
            }
            else if (a == 2)
            {
                Console.WriteLine("O número fibonacci dessa posição é: 1");
                Console.WriteLine("Aperte qualquer tecla para voltar.");
                Console.ReadLine();
            }
            else
            {
                int b = 0;
                for (b = 2; b < a; b++)
                {
                    resultado[0] = 0;
                    resultado[1] = 1;
                    resultado[b] = resultado[b - 1] + resultado[b- 2];

                }
                Console.WriteLine($"O número fibonacci dessa posição é: {resultado[b-1]}");
                Console.WriteLine("Aperte qualquer tecla para voltar.");
                Console.ReadLine();
            }
        }
        static void Bin()
        {

        }
    }
}
