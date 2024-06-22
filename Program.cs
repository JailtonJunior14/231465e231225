using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231465e231225
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0 , saque = 0, pag = 0, deposito = 0, saldof = 0;
            int ope;
            string rep;
            do 
            {
                Console.WriteLine("Qual operaçao deseja fazer : Depositar[1] // Saque[2] // Saldo[3] // Pagamento [4]");
                ope = int.Parse(Console.ReadLine());
                switch (ope)
                    {
                        case 1:
                            saldo = Depositar(saldo);
                            break;
                        case 2:
                            saldo = Saque(saldo);
                            break;
                        case 3:
                            Saldo(saldo);
                            break;
                        case 4:
                            saldo = Pag(saldo);
                            break;

                        default:
                            Console.WriteLine("Opção invalida");
                            break;

                    }
                Console.WriteLine("Deseja continuar");
                rep = Console.ReadLine();
            }
            while (rep == "s");
            Console.ReadKey();
            

        }
        static double Depositar(double  saldo)
        {
            
            Console.WriteLine("Valor: ");
            double deposito = double.Parse(Console.ReadLine());
            double saldof = saldo+deposito;
            return saldof;
            


        }
        static double Saque(double saldo)
        {
            Console.WriteLine("Valor: ");
            double saque = double.Parse(Console.ReadLine());
            if (saldo > saque) {


                saldo = saldo - saque;
                Console.WriteLine("Saldo apos saque: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo indisponivel");    
            }
            return saldo;
            

        }
        static void Saldo(double saldo)
        {
            //saldo = saldo + deposito - (saque + pag);
            Console.WriteLine("Seu Saldo é: " + saldo);
            
          

        }
        static double Pag(double saldo)
        {
            Console.WriteLine("Valor: ");
            double pag = double.Parse(Console.ReadLine());
            if (saldo > pag)
            {
                 

                saldo -= pag;
                Console.WriteLine("Saldo apos saque: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo indisponivel");
            }
            return saldo;

        }


    }
}
