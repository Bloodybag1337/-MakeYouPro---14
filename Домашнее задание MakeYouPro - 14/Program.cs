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

Animal elephant = new Animal();
elephant._name = "Петя";
elephant._age = 5;
elephant._species = "Слон";
elephant._climateZone = "Тропики";
elephant._aerial = 10;
elephant._food = "рыба";
elephant._sound = "ауф";

Animal penguin = new Animal();
penguin._name = "Симба";
penguin._age = 1;
penguin._species = "Пингвин";
penguin._climateZone = "Тундра";
penguin._food = "мясо";
penguin._sound = "хрю";

Animal tiger = new Animal();
tiger._name = "Матильда";
tiger._age = 20;
tiger._species = "Тигр";
tiger._climateZone = "Пустыня";
tiger._food = "сено";
tiger._sound = "рррр";

elephant.Eat();
penguin.Eat();
tiger.Eat();
Console.WriteLine("\n");
elephant.MakeA_sound();
penguin.MakeA_sound();
tiger.MakeA_sound();
Console.WriteLine("\n");
elephant.Play();
penguin.Play();
tiger.Play();
Console.ReadKey();