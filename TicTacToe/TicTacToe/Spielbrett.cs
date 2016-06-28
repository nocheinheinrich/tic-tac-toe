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
      Console.WriteLine("Komando: ");
    }

    public void SpielEnde()
    {
      //Anwendung beenden
      Environment.Exit(0);
    }

    public string IstSpielGewonnen(bool spieler1, string[] a, string[] b, string[] c, int zahl)
    {
      if (spieler1)
        zahl = 1;

      if (a[0] == a[1] && a[1] == a[2] && a[0] != " ")                //Drei gleiche Steine in einer Spalte
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (b[0] == b[1] && b[1] == b[2] && b[0] != " ")           //Drei gleiche Steine in einer Spalte
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (c[0] == c[1] && c[1] == c[2] && c[0] != " ")           //Drei gleiche Steine in einer Spalte
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (a[0] == b[0] && b[0] == c[0] && b[0] != " ")           //Drei gleiche Steine in einer Zeile
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (a[1] == b[1] && b[1] == c[1] && b[1] != " ")           //Drei gleiche Steine in einer Zeile
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (a[2] == b[2] && b[2] == c[2] && b[2] != " ")           //Drei gleiche Steine in einer Zeile
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (a[0] == b[1] && b[1] == c[2] && b[1] != " ")           //Drei gleiche Steine in einer Diagonale
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else if (a[2] == b[1] && b[1] == c[0] && b[1] != " ")           //Drei gleiche Steine in einer Diagonale
      {
        Console.WriteLine("Spieler {0} hat gewonnen! ", zahl);
        Console.ReadLine();
        return "ende";
      }
      else
        return "weiter";
    }

    public string IstSpielUnentschieden(string status1, string[] a, string[] b, string[] c)
    {
      //Solange mindestens ein Feld leer ist, ist geht das Spiel noch weiter sofern keiner gewonnen hat (status1 = "ende")
      //ToDo: Kann man abfragen ob sich der Wert einer Variablen geändert hat?
      if (status1 == "ende")
      {
        return "weiter";
      }
      else if ((a[0] == " " || a[1] == " " || a[2] == " " || b[0] == " " || b[1] == " " || b[2] == " " || c[0] == " " || c[1] == " " || c[2] == " "))
      {
        return "weiter";
      }
      else
      {
        Console.WriteLine("Das Spiel endete unentschieden!");
        Console.ReadLine();
        return "ende";
      }

    }

  }
}


