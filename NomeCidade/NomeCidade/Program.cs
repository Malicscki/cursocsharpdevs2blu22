using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeCidade
{
    internal class Program
    {
        static void Main(string[] args)
         {
            string nomeUsuario, cidadeUsuario;

            Console.WriteLine("\nInforme seu nome: ");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("\nInforme sua cidade: ");
            cidadeUsuario = Console.ReadLine();

            Console.WriteLine($"\nOlá, Seja bem vindo {nomeUsuario} de {cidadeUsuario}.\n");

           

        }
    }
}
