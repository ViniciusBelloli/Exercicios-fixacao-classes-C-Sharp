using System;
using System.Globalization;

namespace Exercicio4
{
   class Exercicio4
   {
      static void Main(string[] args)
      {
         Funcionario f = new Funcionario();
         Console.Write("Nome: ");
         f.Nome = Console.ReadLine();
         Console.Write("Salário bruto: ");
         f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         Console.Write("Imposto: ");
         f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         Console.WriteLine("Funcionário: " + f);
         Console.Write("Digite a porcentagem para aumentar o salário: ");
         f.AumentarSalario(double.Parse(Console.ReadLine()));
         Console.WriteLine("Dados atualizados: " + f);
      }
   }
}
