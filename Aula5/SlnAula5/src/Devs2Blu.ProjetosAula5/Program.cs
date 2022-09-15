using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicioSwitch03();
        }

        static void ExercicioSwitch03()
        {

            int optUsuario, optPC, numeroAleatorio;
            int resultUsuario, resultPC;

            Console.WriteLine("***** JOGO - 21 *****\n");
            Console.WriteLine("Seu adversário será a máquina, BOA SORTE!\n");
            Console.WriteLine("Escolha um numero de 1 a 20 para começar:");
            
            Int32.TryParse(Console.ReadLine(), out optUsuario);
            
            Random rd = new Random();
            optPC = rd.Next(1,20);

            numeroAleatorio = rd.Next(1, 20);

            switch (numeroAleatorio)
            {
                case int i when (i <= 6):
                    Console.WriteLine("Você ganhou 1 ponto");
                    optUsuario = 1;
                    break;
                case 7:
                    Console.WriteLine("Você ganhou 10 pontos");
                    optUsuario = 10;
                    break;
                case int i when (i >= 8 && i <= 13):
                    Console.WriteLine("Você ganhou 5 pontos");
                    optUsuario = 5;
                    break;
                case 14:
                    Console.WriteLine("Você ganhou 20 pontos");
                    optUsuario = 20;
                    break;
                case int i when (i >= 15 && i <= 20):
                    Console.WriteLine("Você ganhou 6 pontos");
                    optUsuario = 6;
                    break;
                case 21:
                    Console.WriteLine("Você ganhou 30 pontos");
                    optUsuario = 30;
                    break;
                default:
                    Console.WriteLine("Você passou dos 21 e perdeu!!");
                    optUsuario = 0;
                    break;

            }




        }
        static void ExercicioSwtich02()
        {

                    /* 2 - Um homem decidiu ir à uma revenda comprar um carro . Ele deseja comprar um carro hatch , e a
                     revenda possui , além de carros hatch , sedans , motocicletas e caminhonetes . Utilizando uma
                     estrutura switch / case , caso o comprador queira o hatch , retorne : " Compra efetuada com
                     sucesso " . Nas outras opções , retorne : " Tem certeza que não prefere este modelo ? " . Caso seja
                     especificado um modelo que não está disponível , retorne no console : " Não trabalhamos com este
                    tipo de automóvel aqui " .
                    */

            string veiculo;

            Console.WriteLine("Temos as opções abaixo de véiculos, qual voce levará hoje? \n");
            Console.WriteLine("Hatch");
            Console.WriteLine("Sedan");
            Console.WriteLine("Caminhonete");
            Console.WriteLine("Motocicleta");
            Console.WriteLine();


            veiculo = Console.ReadLine();
            Console.WriteLine();


            switch (veiculo.ToUpper())

            {
                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso\n");
                    break;
                case "SEDAN":
                case "CAMINHONETE":
                case "MOTICICLETA":
                    Console.WriteLine("Tem certeza que não prefere outro modelo ?\n");
                    break;                 

                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui!\n");
                    break;
            }
        }
        static void ExercicioSwtich01()
        {
            string fruta;

            Console.WriteLine("Qual fruta vamos levar hoje amigo? \n");
            Console.WriteLine("Maçã");
            Console.WriteLine("Kiwi");
            Console.WriteLine("Melancia");
            Console.WriteLine();


            fruta = Console.ReadLine();
            Console.WriteLine();


            switch (fruta.ToUpper())
            {
                case "MAÇÃ":
                    Console.WriteLine("Não vendemos essa fruta aqui\n");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis\n");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui estão, são R$ 3,00 reais o quilo\n");
                    break;

                default:
                    Console.WriteLine("Ops, hoje está em falta amigão!\n");
                    break;
            }
        }
        static void ExemploAula01()
        {
            /*
             *  - "A23" : Materiais
                - "A35": Produtos Perecíveis
                - "Z16": Produtos Químicos
             */
            string codigo;

            Console.WriteLine("Escolha um código para ver a descrição");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case "A21":
                case "A22":
                case "A23":
                case "A24":
                    Console.WriteLine("A23: Materiais.");
                    break;
                case "A35":
                    Console.WriteLine("A35: Produtos Perecíveis.");
                    break;
                case "Z16":
                    Console.WriteLine("Z16: Produtos Químicos.");
                    break;

                default:
                    Console.WriteLine("Produto Não Cadastrado.");
                    break;
            }
        }
    }
}
