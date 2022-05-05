using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Questao02
{
    public class Vertice : IEquatable<Vertice>
    {

        public double X { get ; private set; }

        public double Y { get ; private set; }



        public Vertice(double x, double y)
        {

            this.X = x;

            this.Y = y;

        }


        public static double Distancia(Vertice verticeOrigem, Vertice verticeDestino)
        {

            double distancia = Math.Sqrt( Math.Pow((verticeDestino.X - verticeOrigem.X),2) + Math.Pow((verticeDestino.Y - verticeOrigem.Y), 2));

            return distancia;

        }


        public void Move (double x , double y)
        {
            X = x;

            Y = y;


        }

        public static void Verificar(Vertice verticeA , Vertice verticeB)
        {
                
            if( verticeA.X == verticeB.X && verticeB.Y == verticeA.Y)
            {

                Console.WriteLine("Os vértices são iguais");

            }
            else 
            {
                Console.WriteLine("Os vértices não são iguais");


            }

            



        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Vertice);
        }


        public bool Equals(Vertice other)
        {
            if (other == null)
                return false;

            return this.X.Equals(other.X) &&
                (
                    object.ReferenceEquals(this.X, other.X) ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) &&
                (
                    object.ReferenceEquals(this.Y, other.Y) ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
                );
        }

    }
}
