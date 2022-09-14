using System;
using System.Xml.Linq;




namespace SpielProjekt
{
	 public class Game
	{
		public static void Main()
		{
            Gegner();
            Console.WriteLine("");
            Spieler();
            
        }

        public static Person Gegner()
        {
            Console.WriteLine("Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Stärke");
            int Staerke = int.Parse(Console.ReadLine());
            Console.WriteLine("Vitality");
            int Vitality = int.Parse(Console.ReadLine());
            //Opponent.HP = Opponent.Staerke + 3 * Opponent.Vitality;
            string Klasse = "Gegner";

            Person Opponent = new Person(Klasse, Name, Staerke, Vitality);
            Opponent.Darstellung();

            return Opponent;

        }
        public static Person Spieler()
        {
            Console.WriteLine("Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Stärke");
            int Staerke = int.Parse(Console.ReadLine());
            Console.WriteLine("Vitality");
            int Vitality = int.Parse(Console.ReadLine());
            //Opponent.HP = Opponent.Staerke + 3 * Opponent.Vitality;
            string Klasse = "Spieler";

            Person Player = new Person(Klasse, Name, Staerke, Vitality);
            Player.Darstellung();
            
            return Player;

        }
        
        //public static int Schlag()
        //{
        //    int dmg;
            
        //    //Richtung Opponent oder Spieler
        //    if (true)
        //    {

        //    }
        //    //Schaden = 1,5*Staerke - 0,3*Vitality des Gegners

        //    return dmg;
        //}


    }
}