using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Für welche Zahl möchtest du testen, ob es eine Primzahl ist?");
            int zahl=0; 
            bool fehler = false;
            try    //try/ catch falls jemand zum Beispiel einen buchstaben eingibt
            {
                zahl = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); //fehlermeldung wenn jemand etwas falsches eingibt
                fehler = true;
            }

            if (fehler == false)    //if damit am ende nicht steht eine der folgenden Möglichkeiten steht, wenn jemand einen Fehler beim eigeben hat
            {
                bool Prim = PrimTest(zahl); 
                if (zahl == 0)
                {
                    Console.WriteLine("0 ist keine Primzahl");
                }
                else if (zahl == 0)
                {
                    Console.WriteLine("0 ist keine Primzahl");
                }
                else if (Prim)
                {
                    Console.WriteLine(zahl + " ist eine Primzahl.");
                }
                else if (zahl == -1)
                {
                }
                else
                {
                    Console.WriteLine(zahl + " ist keine Primzahl");
                }
            }
            Console.ReadLine();
        }
            
        
        static bool PrimTest(int testzahl)
        {
            bool istPrim =true;
            for(int zähler = 2; zähler <testzahl; zähler++)
            {
                if(testzahl%zähler == 0) //mit dem for loop wird getestet ob die Zahl durch eine Zahl, die kleiner ist als die Zahl selbst und größer als 1 teilbar ist
                {
                    istPrim = false; //wenn dies der Fall ist wird der bool auf false umgestellt
                }                    //ursprünglich hab ich nach dem Prinzip vom Sieb des Erasathenes getestet (https://de.wikipedia.org/wiki/Sieb_des_Eratosthenes)
                                     //Wen man wie von dir gefragt bis 1.000.000 primzahlen überprüfen will geht das auch leicht, da man
                                     //nur die Primzahlen bis 10.000 in einen Array bringen muss und man dann den Array abfragen kann
                                     //bis zur Math.Sqrt(testzahl). Das hat auch funktioniert, ist mir dann der Weg eingefallen, der 
                                     //mit Zahlen auch über 1.000.000 hinaus funktioniert. 
            }

            return istPrim;
        } 
    }
}
