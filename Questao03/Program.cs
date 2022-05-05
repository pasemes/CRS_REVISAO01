using Questao02;
using System;
using System.Text.RegularExpressions;

namespace Questao03
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Coloque as coordenadas de acordo com exemplo: 2,3");

            Console.WriteLine("Coloque as coordenadas do Primeiro vértice:");
            var coordenadas = Console.ReadLine().Split(",");

            double verticea = double.Parse(coordenadas[0]);
            double verticeb = double.Parse(coordenadas[1]);

            Vertice verticeInicio = new Vertice(verticea, verticeb);

            Console.WriteLine("Coloque as coordenadas do segundo vértice:");
            var coordenadasAA = Console.ReadLine().Split(",");

            double verticeAA = double.Parse(coordenadasAA[0]);
            double verticeBB = double.Parse(coordenadasAA[1]);

            Vertice verticeMeio = new Vertice(verticeAA, verticeBB);


            Console.WriteLine("Coloque as coordenadas do terceiro vértice:");
            var coordenadasBB = Console.ReadLine().Split(",");

            double verticeAAA = double.Parse(coordenadasBB[0]);
            double verticeBBB = double.Parse(coordenadasBB[1]);

            Vertice verticeFim = new Vertice(verticeAAA, verticeBBB);

            Triangulo trianguloA = new Triangulo(verticeInicio, verticeMeio, verticeFim);

            Console.WriteLine();

            Console.WriteLine("Escolha uma opção o que deseja fazer");

            Console.WriteLine();


            Console.WriteLine("1 Àrea do triângulo ");

            Console.WriteLine("2 Périmento do triângulo");

            Console.WriteLine("3 Tipo do triângulo");

            Console.WriteLine("4 verificar se dois Triângulos são iguais");


            Console.WriteLine("5 imprimir suas coodenadas");

            Console.WriteLine("0 Sair");


            var valor = Console.ReadLine();




            do
            {
                if (valor == "1")

                {
                    Console.WriteLine();
                    Console.WriteLine("Àrea do triângulo: " + trianguloA.Area);





                }
                else if (valor == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Périmento do triângulo: " + trianguloA.Perimetro);





                }
                else if (valor == "3")
                {

                    Console.WriteLine();
                    Console.WriteLine("Tipo do triângulo: " + trianguloA.Tipo);

                }
                else if (valor == "4")
                {
                    Console.WriteLine();

                    Console.WriteLine("Coloque as informações do segundo Triângulo");
                    Console.WriteLine();

                    Console.WriteLine("Coloque as coordenadas de acordo com exemplo: 2,3");
                    Console.WriteLine();

                    Console.WriteLine("Coloque as coordenadas do Primeiro vértice:");
                    Console.WriteLine();
                   var coordenadasB = Console.ReadLine().Split(",");

                    double verticeaB = double.Parse(coordenadasB[0]);
                    double verticebB = double.Parse(coordenadasB[1]);

                    Vertice verticeInicioB = new Vertice(verticeaB, verticebB);

                    Console.WriteLine("Coloque as coordenadas do segundo vértice:");
                    var coordenadasAAB = Console.ReadLine().Split(",");

                    double verticeAAB = double.Parse(coordenadasAAB[0]);
                    double verticeABBB = double.Parse(coordenadasAAB[1]);

                    Vertice verticeMeioB = new Vertice(verticeAAB, verticeABBB);


                    Console.WriteLine("Coloque as coordenadas do terceiro vértice:");
                    var coordenadasBBB = Console.ReadLine().Split(",");

                    double verticeAAAB = double.Parse(coordenadasBBB[0]);
                    double verticeBBBB = double.Parse(coordenadasBBB[1]);

                    Vertice verticeFimB = new Vertice(verticeAAAB, verticeBBBB);

                    Triangulo trianguloB = new Triangulo(verticeInicio, verticeMeio, verticeFim);

                    Console.WriteLine();
                    Triangulo.VerificarIgualdade(trianguloA, trianguloB);


                }
                else if (valor == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine(trianguloA);
                    Console.WriteLine();


                }

                else if (!Regex.IsMatch(valor, @"^[0-5]+$"))
                {
                    Console.WriteLine("Escolha uma opção válida");

                    Console.WriteLine();


                }





                else if (valor == "0")
                {

                    Console.WriteLine("Saída com sucesso");

                    Environment.Exit(0);


                }

                Console.WriteLine();

                Console.WriteLine("Escolha uma opção o que deseja fazer");

                Console.WriteLine();


                Console.WriteLine("1 Àrea do triângulo ");

                Console.WriteLine("2 Périmento do triângulo");

                Console.WriteLine("3 Tipo do triângulo");

                Console.WriteLine("4 verificar se dois Triângulos são iguais");


                Console.WriteLine("5 imprimir suas coodenadas");

                Console.WriteLine("0 Sair");

                valor = Console.ReadLine();




            } while (valor != "0");


             

        }
    }
}
