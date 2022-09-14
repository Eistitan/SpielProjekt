using System;
using System.Collections.Specialized;
using System.Xml.Linq;
//using SpielProjekt.Person;





namespace SpielProjekt
{
	 public class Game
	{
		public static void Main()
		{
            //Gegner();
            Console.WriteLine("");
            //Spieler();
            Person Pla = Spieler();
            Person Geg =Gegner();
            Dice();
            Schlag(Pla,Geg);
            Console.WriteLine($"Das Leben von {Geg.Name} beträgt {Geg.HP}");
        }

        static Person Gegner()
        {
            Console.WriteLine("Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Stärke");
            int Staerke = int.Parse(Console.ReadLine());
            Console.WriteLine("Vitality");
            int Vitality = int.Parse(Console.ReadLine());
            string Klasse = "Gegner";

            Person Opponent = new Person(Klasse, Name, Staerke, Vitality);
            Opponent.Darstellung();

            return Opponent;

        }
        static Person Spieler()
        {
            Console.WriteLine("Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Stärke");
            int Staerke = int.Parse(Console.ReadLine());
            Console.WriteLine("Vitality");
            int Vitality = int.Parse(Console.ReadLine());
            string Klasse = "Spieler";

            Person Player = new Person(Klasse, Name, Staerke, Vitality);
            Player.Darstellung();

            return Player;

        }

        public static void Schlag(Person Ang, Person Ver)
        {
            int Schaden = (5* Ang.Staerke -2 * Ver.Vitality);
            if (Schaden<0)
            {
                Schaden = 0;
            }
            
            Ver.HP = Ver.HP - Schaden;

            //Richtung Opponent oder Spieler

            //Schaden = 1,5*Staerke - 0,3*Vitality des Gegners

            }
        public static int Dice()
        {
            Random rnd = new Random();
            int Dice = rnd.Next(1);
            if (Dice ==1)
            {
                Console.WriteLine("Kopf " +Dice);
            }
            else
            {
                
                Console.WriteLine("Zahl " +Dice);
            }
            return Dice;

        }


    }
}