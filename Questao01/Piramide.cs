using System;
using System.Collections.Generic;
using System.Text;

namespace Questao01
{
    public  class Piramide
    {

        public int N { get; set; }



        public Piramide(int n)
        {

            if (n < 1)
            {

 
                Console.WriteLine("O valor de N não pode ser menor que zero");

            } 
            else
            {

                N = n;
            }


           
        }


        public void Desenha()
        {

            for (int i = 1; i <= N; i++)
            {

                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");


                }

                for (int contador = 1; contador <= i; contador++)
                {
                    Console.Write(contador);


                }
              
                for (int contador = i - 1; contador >= 1; contador--)
                {

                    Console.Write(contador);

                }

                Console.WriteLine();



            }




        }

    }
}



