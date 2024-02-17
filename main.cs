using System;

class Program {
  public static void Main (string[] args) {
    string input = "";

    while (input != "exit")
    {
      Console.WriteLine("Enter something: ");
      input = Console.ReadLine();
      Console.WriteLine("You put " + input);
    }
      Console.WriteLine("Terminating Program.....");
  }
}