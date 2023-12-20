using System;
namespace HomeworkClass
{
    public class Animal
    {
        public string Name {get; set;}
        public int _age;
		public string Species { get; set; }
        public string ClimateZone { get; set; }
        public int Aerial { get; set; }
        public string Food { get; private set; }
        public string _sound;

        public Animal(string species, string name, string food, string sound)
        {
            Species = species;
            Name = name;
            Food = food;
            _sound = sound;
        }

		public void Eat()
		{
			Console.WriteLine($"{Species} {Name} ест {Food}");
		}

        public void MakeASound()
        {
            Console.WriteLine($"{Species} {Name} говорит {_sound}");
        }

        public void Play()
        {
            Console.WriteLine($"{Species} {Name} играет: уиии");
        }
    }
}
