using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Questao07
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Coloque seu nome:");
            var nome = Console.ReadLine();
            
            if(nome.Length < 5)
            {

                do
                {
                    Console.WriteLine("Nome precisa Contém mais de 5 caracteres");
                    Console.WriteLine();
                    Console.WriteLine("Coloque seu nome:");

                    nome = Console.ReadLine();


                } while(nome.Length < 5);

            }
            Console.WriteLine();

            Console.WriteLine("Coloque seu CPF: ");
            var cpf = Console.ReadLine();

            if (cpf.Length < 11 || cpf.Length > 11 || cpf.Length <= 0 || !Regex.IsMatch(cpf, @"^[0-9]+$"))
            {

                do
                {
                    Console.WriteLine("CPF precisa contém exatamente 11 dígitos e apenas Números!");
                    Console.WriteLine();
                    Console.WriteLine("Coloque seu CPF: ");

                    cpf = Console.ReadLine();


                } while (cpf.Length < 11 || cpf.Length > 11 || cpf.Length <= 0 || !Regex.IsMatch(cpf, @"^[0-9]+$"));

            }
            Console.WriteLine();

            Console.WriteLine("Coloque sua Data de Nascimento: ");
            
            var data = Console.ReadLine();
            
            DateTime dataAtual;

            

            bool datavalida = DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataAtual);


            

            if (!datavalida)
            {

                do
                {


                
                   

                        Console.WriteLine("Coloque sua Data de Nascimento de acordo com esse exemplo 30/12/2020  ");
                        Console.WriteLine();
                        Console.WriteLine("Coloque sua Data de Nascimento: ");

                        data = Console.ReadLine();

                    

                     datavalida = DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataAtual);



                } while (!datavalida);

            }

            var dataNascimento = DateTime.ParseExact(data, "dd/MM/yyyy", null);

            var idade = Cliente.CalculaIdade(dataNascimento);


            if (idade < 18)
            {

                do
                {



                    Console.WriteLine("O cliente precisa Contém mais de 18 anos");
                    Console.WriteLine();
                    Console.WriteLine("Coloque sua Data de Nascimento: ");
                    data = Console.ReadLine();


                    dataNascimento = DateTime.ParseExact(data, "dd/MM/yyyy", null);

                    idade = Cliente.CalculaIdade(dataNascimento);


                } while (idade < 18);



            }
            Console.WriteLine();

            Console.WriteLine("Coloque sua Renda mensal:");
            var renda = Console.ReadLine();

            float rendaMensal;
            

            if (!float.TryParse(renda, NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out rendaMensal) || !renda.Contains(","))
            {

                do
                {
                    Console.WriteLine("Renda precisa ser colocada de acordo com esse exemplo 2,55");
                    Console.WriteLine();
                    Console.WriteLine("Coloque sua Renda mensal:");
                     renda = Console.ReadLine();


                } while (!float.TryParse(renda, NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out rendaMensal) || !renda.Contains(","));

            }




            Console.WriteLine();

            int valor = 1;
            StringComparer comparer = StringComparer.OrdinalIgnoreCase  ;
            Console.WriteLine("Coloque seu Estado Civil:");
            var estadoCivil = Console.ReadLine();

            do
                {


                if (comparer.Compare(estadoCivil.ToUpper(), "C") == 0  )
                {

                    valor = 0;

                }
                else if (comparer.Compare(estadoCivil.ToUpper(), "S") == 0)
                {

                    valor = 0;

                }
                else if(comparer.Compare(estadoCivil.ToUpper(), "D") == 0)
                {

                    valor = 0;

                }
                else if (comparer.Compare(estadoCivil.ToUpper(), "V") == 0)
   
                {

                    valor = 0;

                }
                else if(estadoCivil.Length > 1 || estadoCivil.Length < 1)
                 {
                    Console.WriteLine("Os estados civis permitidos C, S, V ou D (maiúsculo ou minúsculo)");
                    Console.WriteLine();
                    Console.WriteLine("Coloque seu Estado Civil:");
                    estadoCivil = Console.ReadLine();
                    valor = 1;


                }
                else
               
                {
                    Console.WriteLine("Os estados civis permitidos C, S, V ou D (maiúsculo ou minúsculo) ");
                    Console.WriteLine();
                    Console.WriteLine("Coloque seu Estado Civil:");
                    estadoCivil = Console.ReadLine();
                    valor = 1;


                }








            } while (valor !=0);

            Console.WriteLine();

            Console.WriteLine("Coloque a quantidade dos seus dependentes:");
            var dependentes = Console.ReadLine();

           var  dependentesInt = int.Parse(dependentes);

            if (dependentesInt < 0 || dependentesInt > 10)
            {

                do
                {
                    Console.WriteLine("Os dependentes precisa ser entre 0 a 10");
                    Console.WriteLine();

                    Console.WriteLine("Coloque a quantidade dos seus dependentes:");
                    dependentes = Console.ReadLine();
                    dependentesInt = int.Parse(dependentes);


                } while (dependentesInt < 0 || dependentesInt > 10);

            }




            Cliente cliente = new Cliente(nome, long.Parse(cpf), dataNascimento, rendaMensal, char.Parse(estadoCivil),dependentesInt );

            Console.WriteLine();
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine();
            

            Console.WriteLine(cliente);

        }
           
            



        }
    }

