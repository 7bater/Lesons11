using System.Xml.Linq;
using static System.Console;

namespace Lessons11
{
public class Shark : SeaCreature
    {
        public double ToothLength { get; set; }

        public Shark(string name, int age, double toothLength) : base(name, age)
        {
            ToothLength = toothLength;
        }

        public override void MakeSound()
        {
            WriteLine($"{Name} (Акула): Мовчить і лякає своєю пащею...");
        }

        public override string ToString()
        {
            return $"{Name}, Акула, Вік: {Age}, довжина зубів: {ToothLength} см";
        }
    }
}