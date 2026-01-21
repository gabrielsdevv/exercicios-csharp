using System.Xml.Serialization;

namespace exercicios_csharp;

class Program
{
    static void Main(string[] args)
    {
      String[] valores = Console.ReadLine().Split(' ');
      int A = int.Parse(valores[0]);
      int B = int.Parse(valores[1]);

      if (A % B == 0 || B % A == 0)
        {
            System.Console.WriteLine("Sao Multiplos");
        }
        else
        {
            System.Console.WriteLine("Nao sao multiplos");
        }
       
    }
}
