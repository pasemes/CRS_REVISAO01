using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Questao02;
namespace Questao04
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Coloque a quantidade de vértices");


            var Nquantidades = int.Parse(Console.ReadLine());

            List<Vertice> Vertices = new List<Vertice>();

            Console.WriteLine();
            for ( int i = 0; i < Nquantidades; i++)
            {


                Console.WriteLine("Coloque as coordenadas de acordo com exemplo: 2,3");

                Console.WriteLine("Coloque as coordenadas do vértice " + (i+1) + ":");
                var coordenadas = Console.ReadLine().Split(",");
                ;
                double verticea = double.Parse(coordenadas[0]);
                double verticeb = double.Parse(coordenadas[1]);

                Vertice verticeInicio = new Vertice(verticea, verticeb);


                Vertices.Add(verticeInicio);


            }

            Poligono poligono = new Poligono(Vertices);


            Console.WriteLine();

            Console.WriteLine("Escolha uma opção o que deseja fazer");

            Console.WriteLine();


            Console.WriteLine("1 Périmento do Polígono");

            Console.WriteLine("2 adicionar novo vértice");

            Console.WriteLine("3 Remover o vértice");

            Console.WriteLine("4 Quantidade de vértices do polígono");

            Console.WriteLine("5 Imprimir as coodernadas de vértices do polígono");


            Console.WriteLine("0 Sair");


            var valor = Console.ReadLine();




            do
            {
                if (valor == "1")

                {
                    Console.WriteLine();
                    Console.WriteLine("Périmento do Polígono: " + poligono.PerimetroPoligono()) ;







                }
                else if (valor == "2")
                {
                    Console.WriteLine();

                    Console.WriteLine("Coloque a quantidade de vértices");


                     Nquantidades = int.Parse(Console.ReadLine());
             

                    Console.WriteLine();
                    for (int i = 0; i < Nquantidades; i++)
                    {


                        Console.WriteLine("Coloque as coordenadas de acordo com exemplo: 2,3");

                        Console.WriteLine("Coloque as coordenadas do vértice " + (i + 1) + ":");
                        var coordenadasA = Console.ReadLine().Split(",");
                        ;
                        double verticeaA = double.Parse(coordenadasA[0]);
                        double verticebA= double.Parse(coordenadasA[1]);

                        Vertice verticeInicioA = new Vertice(verticeaA, verticebA);


                       bool valida =  poligono.AddVertice(verticeInicioA);
                        Console.WriteLine(valida);
                        if(valida == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Vértice adicionado com sucesso!");

                        }
                        else 
                        {
                            Console.WriteLine();
                            Console.WriteLine("Vértice não adicionado devido está duplicado");


                        }


                    }





                }
                else if (valor == "3")
                {

                    Console.WriteLine();

                    poligono.RemoveVertice();

                    Console.WriteLine("Removido com sucesso!");
                    Console.WriteLine();





                }
                else if (valor == "4")
                {
                    Console.WriteLine();

                    Console.WriteLine("Quantidade de vértices: " + poligono.Quantidade);



                }
                else if(valor == "5")
                {
                   

                    Console.WriteLine();

                    poligono.imprimir();

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


                Console.WriteLine("1 Périmento do Polígono");

                Console.WriteLine("2 adicionar novo vértice");

                Console.WriteLine("3 Remover o vértice");

                Console.WriteLine("4 Quantidade de vértices do polígono");

                Console.WriteLine("5 Imprimir as coodernadas de vértices do polígono");

                Console.WriteLine("0 Sair");

                valor = Console.ReadLine();




            } while (valor != "0");





        }
    }
}
