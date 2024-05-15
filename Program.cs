using System;

class Program {
  public static void Main (string[] args) {
  int numeroDigitado;
  string op = "s";

    while(op.Equals("s")){
    Console.WriteLine("Digite um número: ");
  numeroDigitado = int.Parse(Console.ReadLine());
    
    if (numeroDigitado % 2 == 0){
      Console.WriteLine("número par!");
    }
    
    else {
      Console.WriteLine("número ímpar!");
      }
      
    Console.WriteLine("Deseja fazer outra operação? (s/n): ");
      op = Console.ReadLine();
      }
    }
  }
