using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao de variaveis
            string formatacaoDados = "\nInicialização de Variável...\n"; //contra barra n serve para concatenar a string
            string nomeUsuario, cidadeUsuario;

            
            // Entrada de Dados
                //Nome
            Console.WriteLine("\nInforme seu nome: ");
            nomeUsuario = Console.ReadLine();

                //Cidade
            Console.WriteLine("\nInforme sua cidade: ");
            cidadeUsuario = Console.ReadLine();

            // Processamento
            //Boas Vindas (nome)
            formatacaoDados += "\nSeja vem vindo, " + nomeUsuario + "!\n\n";

            //Cidade do usuário
            formatacaoDados += $"\nLocalidade: {cidadeUsuario} \n";


            // Apresentaçao dos dados
            Console.WriteLine(formatacaoDados);
           
            // Pausa antes de encerrar aplicaçao 
            Console.WriteLine("Pressione qualquer tecla para sair...");
            var input = Console.ReadLine();
        }
    }
}
