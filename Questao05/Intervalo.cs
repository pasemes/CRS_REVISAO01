using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Questao05
{
    public class Intervalo : IEquatable<Intervalo>
    {

        public DateTime DahoraInicial { get; private set; }

        public DateTime DahoraFinal { get; private set; }



        public Intervalo(DateTime dahoraInicial, DateTime dahoraFinal)
        {

            if (dahoraInicial > dahoraFinal)
            {
                Console.WriteLine("Não pode esses valores");

                Environment.Exit(0);


            }
            else
            {
                this.DahoraInicial = dahoraInicial;

                this.DahoraFinal = dahoraFinal;


            }


        }


        public TimeSpan Duracao
        {
            get
            {
                TimeSpan intervalo = DahoraFinal - DahoraInicial;


                return intervalo;

            }

            private set { }

        }

        public static void Verificar (Intervalo Intervaloa, Intervalo Intervalob)
        {
            bool iguais = Intervaloa.Equals(Intervalob);


            if(iguais == true)
            {
                Console.WriteLine("Os intervalos são iguais");
            }
            else
            {
                Console.WriteLine("Os intervalos não são iguais");


            }



        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Intervalo);
        }

        public bool Equals(Intervalo other)
        {
            if (other == null)
                return false;

            return this.DahoraInicial.Equals(other.DahoraInicial) &&
                (
                    object.ReferenceEquals(this.DahoraInicial, other.DahoraInicial) ||
                    this.DahoraInicial != null &&
                    this.DahoraInicial.Equals(other.DahoraInicial)
                ) &&
                (
                    object.ReferenceEquals(this.DahoraFinal, other.DahoraFinal) ||
                    this.DahoraFinal != null &&
                    this.DahoraFinal.Equals(other.DahoraFinal)
                );
        }



        public static bool TemIntersecao(Intervalo intervaloa, Intervalo intervalob)
        {

            if ((intervaloa.DahoraInicial <= intervalob.DahoraInicial &&
               intervalob.DahoraInicial <= intervaloa.DahoraFinal) ||
              (intervaloa.DahoraInicial <= intervalob.DahoraFinal &&
                intervalob.DahoraFinal <= intervaloa.DahoraFinal) ||

                (intervalob.DahoraInicial <= intervaloa.DahoraInicial &&
               intervaloa.DahoraInicial <= intervalob.DahoraFinal) ||
              (intervalob.DahoraInicial <= intervaloa.DahoraFinal &&
                intervaloa.DahoraFinal <= intervalob.DahoraFinal)

                ) 
            { 


                return true;

             }else
                {
                  
                return false; 

                }
                  



         }


        public override string ToString()
        {
            return "Data inicial:" + " " + DahoraInicial + " " +
                   "Data Final:" + " " + DahoraFinal;
                
                }




    }
}
