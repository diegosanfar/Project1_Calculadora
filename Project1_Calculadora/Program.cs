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

                      int j = 0;
                      char f = 'a';
                      while (f == 'a')
                      {
                          string w = Console.ReadLine();
                          try
                          {
                              j = int.Parse(w);
                              if (j > 10 || j < 1)
                              {
                                  Console.WriteLine("Informe uma opção válida");
                                  Console.WriteLine("Selecione uma opção:");
                              }
                              else
                              {
                                  f = 'b';
                              }
                          }
                          catch
                          {
                              Console.WriteLine("Informe uma opção válida");
                              Console.WriteLine("Selecione uma opção:");
                          }
                      }
                Menu opcao = (Menu)j;
 
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
                    case Menu.Binario:
                        Bin();
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
            Console.WriteLine($"O resultado da soma é: {Math.Round(soma, 2)}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Subtrai()
        {
            Console.WriteLine("Subtração de dois números: ");
            char z = 'a';
            float a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Digite o primeiro número: ");
                string k = Console.ReadLine();
                try
                {
                    a = float.Parse(k);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            float b = 0;
            char y = 'a';
            while (y == 'a')
            {
                    Console.WriteLine("Digite o segundo número: ");
                    string x = Console.ReadLine();
                try
                {
                    b = float.Parse(x);
                    y = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            
            float subtrai = a - b;
            Console.WriteLine($"O resultado da subtração é: {Math.Round(subtrai, 2 )}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            char z = 'a';
            float a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Digite o primeiro número: ");
                string k = Console.ReadLine();
                try
                {
                    a = float.Parse(k);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            Console.WriteLine("Digite o segundo número: ");
            char y = 'a';
            float b = 0;
            while (y == 'a')
            {
                string x = Console.ReadLine();
                try
                {
                    b = float.Parse(x);
                    y = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            float divisao = a / b;
            Console.WriteLine($"O resultado da divisão é: {Math.Round(divisao, 2)}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            char z = 'a';
            float a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Digite o primeiro número: ");
                string k = Console.ReadLine();
                try
                {
                    a = float.Parse(k);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            char y = 'a';
            float b = 0;
            while (y == a)
            {
                Console.WriteLine("Digite o segundo número: ");
                string x = Console.ReadLine();
                try
                {
                    b = float.Parse(x);
                    y = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            float multi = a * b; ;
            Console.WriteLine($"O resultado da multiplicação é: {Math.Round(multi, 2)}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de dois números: ");
            char z = 'a';
            float Base = 0;
            while (z == 'a')
            {
                Console.WriteLine("Digite a base: ");
                string k = Console.ReadLine();
                try
                {
                    Base = float.Parse(k);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe uma base válida.");
                }
            }
            char y = 'a';
            float Potencia = 0;
            while (y == 'a')
            {
                Console.WriteLine("Digite o expoente: ");
                string x = Console.ReadLine();
                try
                {
                    Potencia = float.Parse(x);
                    y = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um expoente válido.");
                }
            }
            double resultado = Math.Pow(Base,Potencia); 
            Console.WriteLine($"O resultado da potência é: {Math.Round(resultado, 2)}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz quadrada de um número: ");
            char z = 'a';
            float a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Informe o número: ");
                string k = Console.ReadLine();
                try
                {
                    a = float.Parse(k);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da raiz é: {Math.Round(resultado, 2)}");
            Console.WriteLine("Aperte qualquer tecla para voltar.");
            Console.ReadLine();
        }
        static void Fator()
        {
            Console.WriteLine("Fatorial de um número: ");
            char z = 'a';
            int a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Informe o número: ");
                string k = Console.ReadLine();
                try
                {
                    a = int.Parse(k);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                }
            }
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
            char z = 'a';
            int a = 0;
            while (z == 'a')
            {
                Console.WriteLine("Informe a posição da contagem: ");
                string k = Console.ReadLine();
                try
                {
                    a = int.Parse(k);                  
                    if (a == 0)
                    {
                        Console.WriteLine("Informe uma posição diferente de zero.");
                    }
                    else
                    {
                        z = 'b';
                    }
                }
                catch
                {
                    Console.WriteLine("Informe uma posição válida.");
                }
            }
            int[] resultado = new int[a];
            if (a == 1)
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
            string opcao;
            do
            {
                Console.WriteLine("Escolha a sua opção :");
                Console.WriteLine("\t1 - Converter Binário para Decimal");
                Console.WriteLine("\t2 - Converter Decimal para Binário");
                Console.WriteLine("\t3 - Encerra o programa");
                Console.Write("Sua opção ? ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        ConverteBinarioParaDecimal();
                        break;
                    case "2":
                        ConverteDecimalParaBinario();
                        break;
                    case "3":
                        Console.WriteLine("Aperte qualquer tecla para voltar para a calculadora.");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        break;
                }
                Console.ReadKey();
            } while (opcao != "3");
        }
        private static void ConverteDecimalParaBinario()
        {
            Console.WriteLine("Informe o número decimal a converter:");
            char z = 'a';
            string resultado = "";
            string valor = "";
            while (z == 'a')
            {
                valor = Console.ReadLine();
                
                try
                {
                    resultado = Conversor.DecimalBinario(valor);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                    Console.WriteLine("Informe o número decimal a converter");
                }
            }
            Console.WriteLine($" O número {valor} é igual a {resultado} ");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de conversão.");
        }
        private static void ConverteBinarioParaDecimal()
        {
            Console.WriteLine("Informe o número binário a converter:");
            char z = 'a';
            int resultado = 0;
            string valor = "";
            while (z == 'a')
            {
                valor = Console.ReadLine();

                try
                {
                    resultado = Conversor.BinarioDecimal(valor);
                    z = 'b';
                }
                catch
                {
                    Console.WriteLine("Informe um número válido.");
                    Console.WriteLine("Informe o número binário a converter:");
                }
            }
            Console.WriteLine($" O número {valor} é igual a {resultado} ");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de conversão.");
        }
    }
    
}
