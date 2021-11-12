using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite seu primeiro nome:");
    string nome = Console.ReadLine();
    string[] nomes = nome.Split(' ');
    Console.WriteLine($"Bem-vindo ao C#, {nomes[0]}");
  }
}
