/*
User Story =>  http://ccd-school.de/coding-dojo/application-katas/tic-tac-toe/
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
  class Program
  {
    static void Main(string[] args)
    {
      string spielstein;
      string status = "weiter";                         //Mögliche Werte: ende = Spiel ist beendet, weiter = Spiel geht weiter
      bool spieler1 = false;                            //Entscheidet ob X oder 0
      string komando = "neu";                           //Voreinstellung für ein leeres Spielfeld
      Spielbrett Spielfeld = new Spielbrett();
      string cmd;                                      //Anwendereingabe in Kleinbuchstaben
      string[] a = new string[3] { " ", " ", " " };
      string[] b = new string[3] { " ", " ", " " };
      string[] c = new string[3] { " ", " ", " " };

      Spielfeld.ZeichneSpielfeld(komando, a, b, c);    //Erzeugt ein leeres Spielfeld

      // ******   Schleife   ******
      while (status == "weiter")
      {
        //ToDo: Evtl. problematisch, falls der Anwender eine ungültige Eingabe macht => Spielfeld wird neu gezeichnet
        spieler1 = !spieler1;                           //Bei der 1. Eingabe bekommt "spieler1" den Wert "true", bei der 2. Eigabe den Wert "False"

        Console.WriteLine("Komando: ");
        komando = Console.ReadLine();                   //Anwendereingabe (neu, ende, a0, ..., c2)
        cmd = komando.ToLower();

        if (spieler1)
          spielstein = "X";
        else
          spielstein = "0";

        switch (cmd)
        {
          case "neu":
            //Anwendung neu starten ???????
            break;
          case "ende":
            //Anwendung beenden
            Spielfeld.SpielEnde();
            break;
          case "a0":
            a[0] = spielstein;
            break;
          case "a1":
            a[1] = spielstein;
            break;
          case "a2":
            a[2] = spielstein;
            break;
          case "b0":
            b[0] = spielstein;
            break;
          case "b1":
            b[1] = spielstein;
            break;
          case "b2":
            b[2] = spielstein;
            break;
          case "c0":
            c[0] = spielstein;
            break;
          case "c1":
            c[1] = spielstein;
            break;
          case "c2":
            c[2] = spielstein;
            break;
          default:
            break;
        }

        Spielfeld.ZeichneSpielfeld(komando, a, b, c);   //Zeichne Spielfeld neu
      }

    }

  }

}


