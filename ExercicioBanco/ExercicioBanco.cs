using System;
using System.Globalization;

namespace ExercicioBanco
{
   class ExercicioBanco
   {
      static void Main(string[] args)
      {
         ContaBancaria conta;

         Console.Write("Entre o número da conta: ");
         int numero = int.Parse(Console.ReadLine());
         Console.Write("Entre o titular da conta: ");
         String titular = Console.ReadLine();
         Console.Write("Haverá depósito inicial (s/n)? ");
         char resp = char.Parse(Console.ReadLine());

         if (resp == 's' || resp == 'S')
         {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = new ContaBancaria(numero, titular, depositoInicial);
         }
         else
         {
            conta = new ContaBancaria(numero, titular);
         }

         Console.WriteLine("Dados da conta:");
         Console.WriteLine(conta);
         Console.Write("Entre um valor para depósito: ");
         double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         conta.Depositar(deposito);
         Console.WriteLine("Dados da conta atualizados:");
         Console.WriteLine(conta);

         Console.Write("Entre um valor para saque: ");
         double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         conta.Saque(saque);
         Console.WriteLine("Dados da conta atualizados:");
         Console.WriteLine(conta);
      }
   }
}
