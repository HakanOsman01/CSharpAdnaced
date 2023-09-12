using System;
using System.Collections;

namespace _01._ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] array = Console.ReadLine().Split().Skip(1).ToArray();
          ListyIterator<string> iterator = new ListyIterator<string>(array);
          string command=Console.ReadLine();
          while(command!= "END")
          {
                switch(command)
                {
                    case "HasNext":
                    Console.WriteLine(iterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            iterator.Print();
                        }
                        catch(Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        
                        break;
                    case "PrintAll":
                        foreach (var item in iterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("No such operation");
                        break;
                }
                command = Console.ReadLine();
          }


        }
    }
    
    
    
}