using System;
using System.Text.RegularExpressions;
using Questao05;
namespace Questao06
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            ListaIntervalo listaIntervalo = new ListaIntervalo();


            Console.WriteLine("Escolha uma opção o que deseja fazer");

            Console.WriteLine();


            Console.WriteLine("1 adicionar um intervalo");

            Console.WriteLine("2 imprimir a lista de intervalos salvos");


            Console.WriteLine("0 Sair");





            var valor = Console.ReadLine();




            do
            {
                if (valor == "1")

                {
                    Console.WriteLine();

                    Console.WriteLine("Coloque seu Intervalo");

                    Console.WriteLine();

                    Console.WriteLine("Coloque sua hora e data  inicial de acordo com exemplo 20/12/2020 7:47:00");

                    var dataInicialB = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Coloque sua hora e data final  de acordo com exemplo 20/12/2020 7:47:00");

                    var dataFinalB = Console.ReadLine();

                    var dataInicialTimeB = DateTime.Parse(dataInicialB);

                    var dataFinalTimeB = DateTime.Parse(dataFinalB);

                    Intervalo intervaloB = new Intervalo(dataInicialTimeB, dataFinalTimeB);

                    Console.WriteLine();

                    listaIntervalo.Add(intervaloB);
                    
                    Console.WriteLine();






                }
                else if (valor == "2")
                {


                    Console.WriteLine();
                    Console.WriteLine("lISTA DE INTERVALOS");
                    Console.WriteLine();
                    listaIntervalo.Imprime();










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


                Console.WriteLine("1 adicionar um intervalo");

                Console.WriteLine("2 imprimir a lista de intervalos salvos");


                Console.WriteLine("0 Sair");

                valor = Console.ReadLine();




            } while (valor != "0");



        }
    }
}
