using System;
using System.Collections.Generic;
using System.Text;
using Questao02;

namespace Questao03
{
    public class Triangulo
    {

       public Vertice verticeA { get; private set; }

        public Vertice verticeB { get; private set; }

        public Vertice verticeC { get; private set; }




        public Triangulo(Vertice VerticeA , Vertice VerticeB , Vertice VerticeC)
        {
            
            double ladoA = Vertice.Distancia(VerticeA, VerticeB);

            double ladoB = Vertice.Distancia(VerticeB, VerticeC);

            double ladoC = Vertice.Distancia(VerticeC, VerticeA);

        if ((ladoB - ladoC) < ladoA && ladoA < (ladoB+ladoC) ||
           (ladoA - ladoC) < ladoB && ladoB < (ladoA + ladoC) || 
           (ladoA - ladoB) < ladoC && ladoC < (ladoA + ladoC) )
            {
                this.verticeA = VerticeA;

                this.verticeB = VerticeB;

                this.verticeC = VerticeC;

            }else
            {
                Console.WriteLine("Não é possivel fazer um triângulo com esses vertices");
                Environment.Exit(0);

            }

        }


        public static void VerificarIgualdade( Triangulo trianguloA , Triangulo trianguloB)
        {

            double ladoA = Vertice.Distancia(trianguloA.verticeA, trianguloA.verticeB);

            double ladoB = Vertice.Distancia(trianguloA.verticeB, trianguloA.verticeC);

            double ladoC = Vertice.Distancia(trianguloA.verticeC, trianguloA.verticeA);

            double ladoAa = Vertice.Distancia(trianguloB.verticeA, trianguloB.verticeB);

            double ladoBb = Vertice.Distancia(trianguloB.verticeB, trianguloB.verticeC);

            double ladoCc = Vertice.Distancia(trianguloB.verticeC, trianguloB.verticeA);

            if((ladoA/ladoAa) == (ladoB/ladoBb) && 
               (ladoB/ladoBb) == (ladoC/ladoCc))
            {
                Console.WriteLine("OS triângulos são semelhantes");

            }else
            {

                Console.WriteLine("OS triângulos não são semelhantes");


            }


        }
        

        public  double Perimetro
        {
            get
            {
                double ladoA = Vertice.Distancia(verticeA, verticeB);

                double ladoB = Vertice.Distancia(verticeB, verticeC);

                double ladoC = Vertice.Distancia(verticeC, verticeA);

                var retorno = ladoA + ladoB + ladoC;

                return retorno;

            }

            private set { }

        }


        public double Area
        {
            get
            {
                double ladoA = Vertice.Distancia(verticeA, verticeB);

                double ladoB = Vertice.Distancia(verticeB, verticeC);

                double ladoC = Vertice.Distancia(verticeC, verticeA);

                var S = (ladoA + ladoB + ladoC)/2;


                var retorno = Math.Sqrt(S * (S - ladoA) * (S - ladoB) * (S - ladoC)); 

                return retorno;

            }

            private set { }

        }

        public TipoTriangulo Tipo
        {
            get
            {
                double ladoA = Vertice.Distancia(verticeA, verticeB);

                double ladoB = Vertice.Distancia(verticeB, verticeC);

                double ladoC = Vertice.Distancia(verticeC, verticeA);

      
                if (ladoA == ladoC && ladoC == ladoB)
                {
                    return TipoTriangulo.Equilatero;
                }

                else if (ladoA == ladoC && ladoC != ladoB)
                {

                    return TipoTriangulo.Isosceles;

                }else 
                {
                    return TipoTriangulo.Escaleno;


                }
               




            }

            private set { }

        }


        public override string ToString()
        {
            return "(" + verticeA.X + "," + verticeA.Y + ")\n" +
                    "(" + verticeB.X + "," + verticeB.Y + ")\n" +
                     "(" + verticeC.X + "," + verticeC.Y + ")\n"
                ;
        }


    }



}

