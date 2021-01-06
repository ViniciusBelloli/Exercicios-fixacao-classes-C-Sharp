using System;
using System.Globalization;

namespace Exercicio6
{
   class Exercicio6
   {
      static void Main(string[] args)
      {
         Console.Write("Qual é a cotação do dólar? ");
         double valordolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         Console.Write("Quantos dólares você vai comprar ? ");
         double dolarcomprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         Console.WriteLine("Valor a ser pago em reais = " + ConversorMoeda.ConversorDolar(valordolar, dolarcomprar).ToString("F2", CultureInfo.InvariantCulture));
      }
   }
}