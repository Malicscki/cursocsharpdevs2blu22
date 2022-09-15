using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula7Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.Programa em Java que calcula a média das notas de uma turma
            Escreva um programa que pergunte ao usuário quantos alunos tem na sala dele.
            Em seguida, através de um laço while, pede ao usuário para que entre com as notas de todos os alunos da sala, um por vez.
            Por fim, o programa mostra a média, aritmética, da turma.*/

            string alunos;
            int notaAlunos = 0;
            int contador = 1;

            Console.WriteLine("Insira a quantidade de alunos");
            alunos = Console.ReadLine();

            Random rd = new Random();

            while (contador <= alunos)
            {
                int valor = rd.Next(5, 10);
            }


            Console.WriteLine($"quantidade de alunos é: {alunos}");



        }
    }
}
