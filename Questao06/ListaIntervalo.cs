using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Questao05;

namespace Questao06
{
    public class ListaIntervalo
    {
        List<Intervalo> Intervalos = new List<Intervalo>();



        public void Add(Intervalo intervalo)
        {
            
            if (Intervalos.Count == 0)
            {

                Intervalos.Add(intervalo);


            }

            else
            {
                var limite = Intervalos.Count;



                for (int i = 0; i < limite; i++)

                {
                   
                   var valor = Intervalo.TemIntersecao(intervalo, Intervalos[i]);
                    if ( valor == false)
                    {
                        Intervalos.Add(intervalo);


                    }
                    else 
                    {
                        Console.WriteLine("Esse intervalo existe uma interseção com outro intervalo");
                    }

                 

                }





            }
        }

       
        public void Imprime()
            {
                var listaIntervalos = Intervalos.OrderBy(x => x.DahoraInicial);


                foreach(var listaIntervalosimpresao in listaIntervalos )
            {


                Console.WriteLine(listaIntervalosimpresao.ToString());
            }



            }


        }
    }
