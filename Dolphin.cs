using System.Xml.Linq;
using static System.Console;

namespace Lessons11
{
    public class Dolphin : SeaCreature
    {
        public string FavoriteTrick { get; set; }

        public Dolphin(string name, int age, string favoriteTrick) : base(name, age)
        {
            FavoriteTrick = favoriteTrick;
        }

        public override void MakeSound()
        {
            WriteLine($"{Name} (Дельфін): Свистить і клацає!");
        }

        public override string ToString()
        {
            $"{Name}, Дельфін, Вік: {Age}, улюблений трюк: {FavoriteTrick}";
        }
    }
}