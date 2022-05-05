using System;

namespace Questao01
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Coloque a quantidade de N: ");
            var nPiramides = int.Parse(Console.ReadLine());


            Piramide piramide = new Piramide(nPiramides);

            Console.WriteLine();

            Console.WriteLine("O desenho da sua pirâmide:");

            Console.WriteLine();
             
            piramide.Desenha();






        }
    }
}
