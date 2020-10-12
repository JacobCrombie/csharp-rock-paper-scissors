using System;
using rockpaperscissors.Controllers;
using System.Threading;

namespace rockpaperscissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine(@"
 (                        (                                (                                 
 )\ )              )      )\ )                             )\ )                              
(()/(           ( /(     (()/(    )           (   (       (()/(     (                (       
 /(_)) (    (   )\())     /(_))( /(  `  )    ))\  )(       /(_)) (  )\  (   (    (   )(   (  
(_))   )\   )\ ((_)\     (_))  )(_)) /(/(   /((_)(()\     (_))   )\((_) )\  )\   )\ (()\  )\ 
| _ \ ((_) ((_)| |(_) )  | _ \((_)_ ((_)_\ (_))   ((_) )  / __| ((_)(_)((_)((_) ((_) ((_)((_)
|   // _ \/ _| | / / /(  |  _// _` || '_ \)/ -_) | '_|/(  \__ \/ _| | |(_-<(_-</ _ \| '_|(_-<
|_|_\\___/\__| |_\_\(_)) |_|  \__,_|| .__/ \___| |_| (_)) |___/\__| |_|/__//__/\___/|_|  /__/
                                    |_|                                                      
      ");
      Thread.Sleep(1000);
      System.Console.WriteLine("Rock, Paper, or Scissors, choose wisely.");
      var choice = Console.ReadLine();
      GameController gc = new GameController();
      gc.Launch();
    }
  }
}
