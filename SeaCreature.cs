namespace Lessons11
{
    public abstract class SeaCreature
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected SeaCreature(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }
}