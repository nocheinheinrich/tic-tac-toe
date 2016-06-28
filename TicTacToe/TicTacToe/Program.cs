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
    static string cmd;                                              //Anwendereingabe in Kleinbuchstaben

    static string[] a = new string[3] { " ", " ", " " };
    static string[] b = new string[3] { " ", " ", " " };
    static string[] c = new string[3] { " ", " ", " " };
    static string spielstein;

    static void Main(string[] args)
    {
      string status1 = "weiter";                                     //Mögliche Werte: ende = Spiel ist beendet, weiter = Spiel geht weiter
      string status2 = "weiter";                                     //Mögliche Werte: ende = Spiel ist beendet, weiter = Spiel geht weiter
      bool spieler1 = false;                                        //Entscheidet ob X oder 0
      string komando = "neu";                                       //Voreinstellung für ein leeres Spielfeld
      int zahl = 2;                                                 //1 oder 2 (für die Ausgabe des Gewinners)

      // ****************************   Äußere Schleife Start   ***************************************
      while ((komando.ToLower() != "ende") && ((status1 == "weiter") && (status2 == "weiter")))
      {
        Spielbrett Spielfeld = new Spielbrett();
        Spielfeld.ZeichneSpielfeld(komando, a, b, c);                 //Erzeugt ein leeres Spielfeld

        // ****************************   Innere Schleife Start   ***********************************
        while (status1 == "weiter" && status2 == "weiter")
        {
          //ToDo: Evtl. problematisch, falls der Anwender eine ungültige Eingabe macht => Wahrheitswert darf nicht geändert werden
          spieler1 = !spieler1;                                                 //Bei der 1. Eingabe bekommt "spieler1" den Wert "true", 
                                                                                //    bei der 2. Eigabe bekommt "spieler1" den Wert "False"
          komando = Console.ReadLine();//.ToLower();                                         //Anwendereingabe (neu, ende, a0, ..., c2)
          //Console.WriteLine(komando);
          cmd = komando.ToLower();                                              //Alles in Kleinbuchstaben
          spielstein = SpielsteinBestimmen(spieler1);                           //Welcher Spieler setzt den Stein
          AntwortAuswerten();                                                   //Auswerten der Eingabe
          Spielfeld.ZeichneSpielfeld(komando, a, b, c);                         //Spielfeld neu zeichnen
          status1 = Spielfeld.IstSpielGewonnen(spieler1, a, b, c, zahl);         //Prüfe: Ist das Spiel gewonnen, falls ja => status1 = "ende"
          status2 = Spielfeld.IstSpielUnentschieden(status1, a, b, c);                    //Prüfe: Ist das Spiel unentschieden, falls ja => status2 = "ende"
        }
        // ****************************   Innere Schleife Ende   ***********************************
      }
      // ****************************   Äußere Schleife Ende   *****************************************
    }
    static string SpielsteinBestimmen(bool spieler1)
    {
      //Hier wird festgelegt welcher Stein als nächster gesetzt wird     
      if (spieler1)
        spielstein = "X";
      else
        spielstein = "0";
      return spielstein;
    }

    static void AntwortAuswerten()
    {
      switch (cmd)
      {
        //case "neu":
        //  Spiel neu starten ???????
        //  break;
        //case "ende":
        //  Spiel beenden ???????
        //  break;
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
    }
  }
}


