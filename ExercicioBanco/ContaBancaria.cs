using System.Globalization;

namespace ExercicioBanco
{
   class ContaBancaria
   {
      public int Numero { get; private set; }
      public string Titular { get; set; }
      public double Saldo { get; private set; }

      public ContaBancaria()
      {
      }

      public ContaBancaria(int numero, string titular)
      {
         Numero = numero;
         Titular = titular;
      }

      public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
      {
         Depositar(depositoInicial);
      }

      public void Depositar(double valor)
      {
         Saldo += valor;
      }

      public void Saque(double valor)
      {
         Saldo -= (valor + 5);
      }

      public override string ToString()
      {
         return "Conta " + Numero + 
                ", Titular: " + Titular + 
                ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
      }
   }
}