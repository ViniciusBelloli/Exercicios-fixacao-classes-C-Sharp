namespace Exercicio6
{
   class ConversorMoeda
   {
      public static double Iof = 0.06; //6%
      public static double ConversorDolar(double valordolar, double dolarcomprar)
      {
         double totaldolar = valordolar * dolarcomprar;
         return totaldolar + (totaldolar * Iof);
      }
   }
}