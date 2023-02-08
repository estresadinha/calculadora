using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0.0;
            double valor2 = 0.0;
            string opc ="";
            

            Console.WriteLine("digite o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o segundo valor ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Qual operação que fazer? ");
           //Console.WriteLine(" 1- soma ");
            //Console.WriteLine(" 2 - subtração ");
          //Console.WriteLine(" 3 - divisão ");
           // Console.WriteLine(" 4 - multiplicação ");
           
            Console.WriteLine(" digite sua opção");
            opc = Console.ReadLine();
            if (opc == "1")
            {
                Console.WriteLine("o resultado é " + (valor1 + valor2));
                Console.WriteLine();
                
            }
            if (opc == "2")
            {
                Console.WriteLine("o resultado é " + (valor1 - valor2));
                Console.WriteLine();
            }
            if (opc == "3")
            {
               
                Console.WriteLine("o resultado é " + (valor1 * valor2));
                Console.WriteLine();

                

            }
            if (opc == "4")
            {
                if (valor1 >= valor2)
                {

                    Console.WriteLine("o resultado é " + (valor1 / valor2));
                }


                else
                {
                    Console.WriteLine("divisão invalida ");
                }

            }
                
                
                
                 
                    
                
                
            



            
        }
    }
}
