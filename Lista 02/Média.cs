using System; 

public class Program {

  public static void Main(string[] args) {

    double nota1, nota2, media;

    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    nota2 = double.Parse(Console.ReadLine());
    media = (nota1 * 2 + nota2 * 3)/5;
    Console.WriteLine($"Média parcial = {media}");
  }
}
