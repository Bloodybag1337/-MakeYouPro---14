/*
Опишите класс животного, живущего в зоопарке, на основе следующего описания:
Животное в зоопарке описывается на основе следующих параметров:
    Общее описание животного:
        Имя (Петя, Симба, Матильда)
        Возраст (5, 1, 20)
        Название вида (Слон, Пингвин, Тигр)
        Необходимый биом (Тропики, Тундра, Пустыня)
        Необходимая площадь на особь (10 м^2)
        Что кушает (Рыба, Мясо, Сено) - Один тип животного может питаться несколькими продуктами
        Издаваемый звук (Ауф, Хрю, Рррр)
    Функционал животного (достаточно условно обозначить действие выводом в консоль):
        Есть
        Издать звук
        Играть
*/

using HomeworkClass;

Animal elephant = new Animal
{
    Name = "Петя",
    _age = 5,
    Species = "Слон",
    ClimateZone = "Тропики",
    Aerial = 10,
    Food = "рыба",
    _sound = "ауф"
};

Animal penguin = new Animal
{
    Name = "Симба",
    _age = 1,
    Species = "Пингвин",
    ClimateZone = "Тундра",
    Food = "мясо",
    _sound = "хрю",
};

Animal tiger = new Animal
{
    Name = "Матильда",
    _age = 20,
    Species = "Тигр",
    ClimateZone = "Пустыня",
    Food = "сено",
    _sound = "рррр",
};

elephant.Eat();
penguin.Eat();
tiger.Eat();
Console.WriteLine("\n");
elephant.MakeASound();
penguin.MakeASound();
tiger.MakeASound();
Console.WriteLine("\n");
elephant.Play();
penguin.Play();
tiger.Play();
Console.ReadKey();
