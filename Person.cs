using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpielProjekt
{
    public class Person
    {
        public string Klasse; //Spieler oder Gegner
        public string Name;
        public int Staerke;
        public int Vitality;
        public int HP;
        //public int HP = 1 * Staerke + 3 * Vitality;


        public void Darstellung()
        {
            Console.WriteLine($"Der {Klasse} heißt {Name} und hat {HP} Lebenspunkte.");
        }
        public Person(string Klasse, string Name, int Staerke, int Vitality)
        {
            this.Klasse = Klasse;
            this.Name = Name;
            this.Staerke = Staerke;
            this.Vitality = Vitality;
            this.HP = 1 * Staerke + 3 * Vitality;
             
        }


    }
    
}
