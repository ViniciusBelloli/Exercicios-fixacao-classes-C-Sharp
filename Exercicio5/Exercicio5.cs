using System;
using System.Globalization;

namespace Exercicio5
{
   class Exercicio5
   {
      static void Main(string[] args)
      {
         Aluno a = new Aluno();
         Console.Write("Nome do aluno: ");
         a.Nome = Console.ReadLine();
         Console.WriteLine("Digite as três notas do aluno:");
         a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         a.NotaFinal();

         Console.WriteLine("NOTA FINAL = " + a.notafinal.ToString("F2", CultureInfo.InvariantCulture));
         if (a.notafinal < 60)
         {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + (60 - a.notafinal).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
         }
         else
         {
            Console.WriteLine("APROVADO");
         }
      }
   }
}