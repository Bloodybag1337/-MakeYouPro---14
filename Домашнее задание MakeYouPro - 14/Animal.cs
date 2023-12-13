using System;
namespace HomeworkClass
{
	public class Animal
	{
		public string _name;
        public int _age;
		public string _species;
		public string _climateZone;
        public int _aerial;
        public string _food;
        public string _sound;

		public void Eat()
		{
			Console.WriteLine($"{_species} {_name} ест {_food}");
		}

        public void MakeA_sound()
        {
            Console.WriteLine($"{_species} {_name} говорит {_sound}");
        }

        public void Play()
        {
            Console.WriteLine($"{_species} {_name} играет: уиии");
        }
    }
}

