using System;

class Program {
  public static void Main (string[] args) {

    while (true){
      Console.WriteLine("Enter Something: ");
      string input = Console.ReadLine();

      if (input.ToLower() == "exit")
      {
        Console.WriteLine("Closing program...");
        break;
      }
    }

  }
}