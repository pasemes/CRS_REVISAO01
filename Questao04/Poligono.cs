using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Questao02;

namespace Questao04
{
    public class Poligono
    {

        List<Vertice> Vertices = new List<Vertice>();


        public Poligono(List<Vertice> vertices)
        {

            if (vertices.Count < 3)
            {
                Console.WriteLine("Poligono precisa possuir 3 vertices");
                Environment.Exit(0);


            }else
            {
                this.Vertices = vertices;
            }



        }

        public bool AddVertice(Vertice vertice)
        {
      
            var existe = Vertices.Contains(vertice);

            if (existe == true)
            {
                return false;

            }
            else
            {
                Vertices.Add(vertice);

                return true;

            }

        }


        public void RemoveVertice()
        {
            if(Vertices.Count == 3)
            {
                Console.WriteLine("Não pode  remover nenhum vértices");
                Environment.Exit(1);

            }
            
            else
            {
                Vertices.Remove(Vertices[0]);
                Console.WriteLine("Um Vértices Removido");


            }



        }

        public long Quantidade
        {
            get
            {
                return Vertices.Count;

            }

            private set { }

        }


        public double PerimetroPoligono()
        {
            double perimetro = 0.0;

            var pontoAnterior = Vertices[Vertices.Count - 1];

        

          foreach(var verticesPerimento in Vertices)
            {
                perimetro = Vertice.Distancia(pontoAnterior, verticesPerimento) + perimetro;

                pontoAnterior = verticesPerimento;

            }
            


            return perimetro;
        }


        public void imprimir ()
        {
            foreach(var lista in Vertices)
            {

                Console.WriteLine(lista); 
            }
        }

      
    }
}
