using System; 

public class Program {

  public static void Main(string[] args) {

    long hora, min, segundo, distancia;
    
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    string[] horario = Console.ReadLine().Split(':');
    hora = int.Parse(horario[0]) * 3600;
    min = int.Parse(horario[1]) * 60;
    segundo = int.Parse(horario[2]);
    distancia = (hora + min + segundo) * 300000;
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}
