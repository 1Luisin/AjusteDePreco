using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AjusteDePreco
{
    internal class Program
    {
        enum opcoes { start = 1, about = 2, stop = 3}

        static void Main(string[] args)
        {
            
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Ajustador de preços!");
                Console.WriteLine("\n1 - Começar\n2 - Sobre\n3 - Sair");
                opcoes valorusuario = (opcoes)int.Parse(Console.ReadLine());
                switch (valorusuario)
                {
                    case opcoes.start:
                        Console.Clear();
                        int resultadofinal = precofinal();
                        break;

                    case opcoes.about:
                        Console.Clear();
                        Console.WriteLine("Este programa ajusta todos os valores que o usúario fornece, em 25% a mais que o próprio valor inserido\n\nExemplo: 25% de 32 é 8, sendo assim: 4");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao ínicio :D");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    
                    case opcoes.stop:
                        exit = true;
                        Console.Clear();
                        Console.WriteLine("Encerrando programa...\nPressione qualquer tecla para fechar");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida, tente novamente");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }       
            }
        }

        static int precofinal()
        {  
            Console.Clear();
            Console.WriteLine("Digite o número que você deseja ajustar em 25%");
            int ValueUser = int.Parse(Console.ReadLine());
            Console.Clear();
            int FinalValue = ValueUser + ValueUser / 4;
            Console.WriteLine($"25% do valor inserido é: { ValueUser / 4 }\nSeu valor reajustado é de: { FinalValue }");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao ínicio. . .");
            Console.ReadLine();
            Console.Clear();
            return FinalValue;
 
        }

    }

}