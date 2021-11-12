using System; 

public class Program {

  public static void Main(string[] args) {

    double bas, altura, area, perimetro, diagonal;

    Console.WriteLine("Digite a base e a altura do retângulo");
    bas = double.Parse(Console.ReadLine());
    altura = double.Parse(Console.ReadLine());
    area = bas * altura;
    perimetro = bas * 2 + altura * 2;
    diagonal = (bas * bas) + (altura * altura);
    diagonal = Math.Sqrt(diagonal);
    Console.WriteLine($"Área = {area: 0.00} - Perímetro = {perimetro: 0.00} - Diagonal = {diagonal:  0.00}");
  }
}
