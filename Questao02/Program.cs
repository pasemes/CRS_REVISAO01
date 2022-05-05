using System;
using System.Text.RegularExpressions;

namespace Questao02
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Coloque as coordenadas de acordo com exemplo: 2,3");
            var coordenadas = Console.ReadLine().Split(",");

            double verticea = double.Parse(coordenadas[0]);
            double verticeb = double.Parse(coordenadas[1]);

            Vertice verticeorigem = new Vertice(verticea, verticeb);
            
            Console.WriteLine();

            Console.WriteLine("Escolha uma opção o que deseja fazer");

            Console.WriteLine();


            Console.WriteLine("1 Calcular a distância euclidiana");

            Console.WriteLine("2 Move vértice para outra posição");

            Console.WriteLine("3 Verificar se dois vértices são iguais");

            Console.WriteLine("4 imprimir suas coodenadas");

            Console.WriteLine("0 Sair");


            var valor = Console.ReadLine();




            do
            {
                if (valor == "1")

                {
                    Console.WriteLine("Coloque as Informações do segundo vértice para fazer o cálculo");
                    Console.WriteLine("Coloque  as coordenadas de acordo com exemplo: 2,3");

                    var coordenadasB = Console.ReadLine().Split(",");

                    double verticeaa = double.Parse(coordenadasB[0]);
                    double verticebb = double.Parse(coordenadasB[1]);

                    Vertice verticeDestino = new Vertice(verticeaa, verticebb);

                    Console.WriteLine(verticeorigem.ToString());

                    var distancia = Vertice.Distancia(verticeorigem, verticeDestino);


                    Console.WriteLine("A distância do pontos é : " + distancia);





                }
                else if (valor == "2")
                {

                    Console.WriteLine("Coloque as Informações da nova coodernadas do vértice");
                    Console.WriteLine("Coloque  as coordenadas de acordo com exemplo: 2,3");

                    var coordenadasNovas = Console.ReadLine().Split(",");

                    double verticeNovoA = double.Parse(coordenadasNovas[0]);
                    double verticeNovoB = double.Parse(coordenadasNovas[1]);

                    verticeorigem.Move(verticeNovoA, verticeNovoB);
                    Console.WriteLine();
                    Console.WriteLine("vértice com a nova posição realizado com sucesso");





                }
                else if (valor == "3")
                {

                    Console.WriteLine("Coloque as Informações do segundo vértice para fazer o comparação");
                    Console.WriteLine("Coloque  as coordenadas de acordo com exemplo: 2,3");

                    var coordenadasB = Console.ReadLine().Split(",");

                    double verticeaa = double.Parse(coordenadasB[0]);
                    double verticebb = double.Parse(coordenadasB[1]);

                    Vertice verticeDestino = new Vertice(verticeaa, verticebb);

                    Console.WriteLine();

                    Vertice.Verificar(verticeorigem, verticeDestino);

                }
                else if (valor == "4")
                {

                    Console.WriteLine("As coodenadas do seu vértice");

                    Console.WriteLine(verticeorigem);

                    Console.WriteLine();



                }

                else if (!Regex.IsMatch(valor, @"^[0-4]+$"))
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


                Console.WriteLine("1 Calcular a distância euclidiana");

                Console.WriteLine("2 Move vértice para outra posição");

                Console.WriteLine("3 Verificar se dois vértices são iguais");

                Console.WriteLine("4 imprimir suas coodenadas");


                Console.WriteLine("0 Sair");


                 valor = Console.ReadLine();




            } while (valor != "0");






            






        }
    }
}
