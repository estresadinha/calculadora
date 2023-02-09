using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0.0;
            double valor2 = 0.0;
            /*string opc ="";*/


            string opcao = "";

            while (opcao != "parar")
            {



                Console.WriteLine("digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("digite o segundo valor ");
                valor2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Qual operação que fazer? ");
                Console.WriteLine(" 1- soma ");
                Console.WriteLine(" 2 - subtração ");
                Console.WriteLine(" 3 - divisão ");
                Console.WriteLine(" 4 - multiplicação ");


                Console.WriteLine(" digite sua opção");
                switch (Console.ReadLine())
                {


                    case "1":
                        Console.WriteLine("o resultado é " + (valor1 + valor2));
                        break;

                    case "2":
                        Console.WriteLine("o resultado é " + (valor1 - valor2));
                        break;

                    case "3":
                        Console.WriteLine("o resultado é " + (valor1 / valor2));
                        break;

                    case "4":
                        if (valor1 >= valor2)
                        {
                            Console.WriteLine("o resultado é " + (valor1 * valor2));
                        }
                        else
                        {
                            Console.WriteLine("invalido ");
                        }
                        break;




                }
                Console.WriteLine("quer continuar ");
                

                opcao = Console.ReadLine();
            }
             

                
                 
                    
                
                
            



            
        }
    }
}
