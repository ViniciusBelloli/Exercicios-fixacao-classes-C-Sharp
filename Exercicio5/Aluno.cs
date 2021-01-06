namespace Exercicio5
{
   class Aluno
   {
      public string Nome;
      public double nota1, nota2, nota3, notafinal;

      public void NotaFinal()
      {
         notafinal = nota1 + nota2 + nota3;
      }
   }
}