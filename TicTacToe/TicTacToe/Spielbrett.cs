using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
  class Spielbrett
  {
    public void ZeichneSpielfeld(string komando, string[] a, string[] b, string[] c)
    {
      Console.WriteLine();
      Console.WriteLine("  A   B   C ");
      Console.WriteLine("0 {0} | {1} | {2} ", a[0], b[0], c[0]);
      Console.WriteLine("----+---+---");
      Console.WriteLine("1 {0} | {1} | {2} ", a[1], b[1], c[1]);
      Console.WriteLine("----+---+---");
      Console.WriteLine("2 {0} | {1} | {2} ", a[2], b[2], c[2]);
      Console.WriteLine("            ");
    }

    public void SpielEnde()
    {
      //Anwendung beenden
      Environment.Exit(0);
    }


  }
}

