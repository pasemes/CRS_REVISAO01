using System;
using System.Text.RegularExpressions;

namespace Questao05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque sua hora e  data  inicial de acordo com exemplo 20/15/2020 7:47:00");

            var dataInicial = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Coloque sua hora e  data  final  de acordo com exemplo 20/15/2020 7:47:00");

            var dataFinal = Console.ReadLine();

            var dataInicialTime = DateTime.Parse(dataInicial);

            var dataFinalTime =  DateTime.Parse(dataFinal);

            Intervalo intervalo = new Intervalo(dataInicialTime, dataFinalTime);



            Console.WriteLine();

            Console.WriteLine("Escolha uma opção o que deseja fazer");

            Console.WriteLine();


            Console.WriteLine("1 Verificar se intervalo tem interseção com outro intervalo");

            Console.WriteLine("2 Verificar se intervalo é semelhante a outro");

            Console.WriteLine("3 Duração de intervalo em dias");

            Console.WriteLine("4 Imprimir a data inicial e data final");

            Console.WriteLine("0 Sair");





            var valor = Console.ReadLine();




            do
            {
                if (valor == "1")

                {
                    Console.WriteLine();

                    Console.WriteLine("Coloque segundo Intervalo");

                    Console.WriteLine();

                    Console.WriteLine("Coloque sua hora e data  inicial de acordo com exemplo 20/12/2020 7:47:00");

                    var dataInicialB = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Coloque sua hora e data final  de acordo com exemplo 20/12/2027:47:00");

                    var dataFinalB = Console.ReadLine();

                    var dataInicialTimeB = DateTime.Parse(dataInicialB);

                    var dataFinalTimeB = DateTime.Parse(dataFinalB);

                    Intervalo intervaloB = new Intervalo(dataInicialTimeB, dataFinalTimeB);

                    bool verificar = Intervalo.TemIntersecao(intervalo, intervaloB);

                    if(verificar == true)
                    {
                        Console.WriteLine();

                        Console.WriteLine("Valores tem interseção entre eles");

                        Console.WriteLine();



                    }
                    else
                    {
                        Console.WriteLine();

                        Console.WriteLine("Valores não tem interseção entre eles");

                        Console.WriteLine();

                    }






                }
                else if (valor == "2")
                {
                   

                    Console.WriteLine();

                    Console.WriteLine();

                    Console.WriteLine("Coloque segundo Intervalo");

                    Console.WriteLine();

                    Console.WriteLine("Coloque sua hora e  data  inicial de acordo com exemplo 20/12/2020 7:47:00");

                    var dataInicialB = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine("Coloque sua hora e  data  final  de acordo com exemplo 20/12/2020 7:47:00");

                    var dataFinalB = Console.ReadLine();

                    var dataInicialTimeB = DateTime.Parse(dataInicialB);

                    var dataFinalTimeB = DateTime.Parse(dataFinalB);

                    Intervalo intervaloB = new Intervalo(dataInicialTimeB, dataFinalTimeB);

                    Console.WriteLine();

                    Intervalo.Verificar(intervalo, intervaloB);

                    Console.WriteLine();










                }
                else if (valor == "3")
                {

                    Console.WriteLine();

                    Console.WriteLine("Duração dos intervalos em dias: " + intervalo.Duracao.Days + " dias");





                }
                else if (valor == "4")
                {
                    Console.WriteLine();

                    Console.WriteLine(intervalo);

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


                Console.WriteLine("1 Verificar se intervalo têm interseção com outro intervalo");

                Console.WriteLine("2 Verificar se intervalo semelhante a outro");

                Console.WriteLine("3 Duração de intervalo em dias");

                Console.WriteLine("4 Imprimir a data inicial e data final");

                Console.WriteLine("0 Sair");

                valor = Console.ReadLine();




            } while (valor != "0");







        }
    }
}
