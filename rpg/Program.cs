using RpgLogicProject;
using System;



//Инициализировать классы. И начать битву  

var rand = new Random();

Console.WriteLine("Добро пожаловать на арену!");

Console.WriteLine("Ваше имя?");

Console.Write("Меня зовут:");

string name = Convert.ToString(Console.ReadLine());

var Hero = new Hero(name, 1, 100);


var Weapon = new Weapon("Нож", 11);

Console.WriteLine($"Твоим оружием будет: {Weapon.Name}");

var Enemy = new Enemy(Arrays.monsters[rand.Next(0, 10)], Hero.Level + rand.Next(0, 1), rand.Next(0, 100), rand.Next(0, 50));

Console.WriteLine($"Твой враг: {Enemy.Name}");


Console.WriteLine("Готов?");

Console.WriteLine("1-Да/2-Нет");

int answer = int.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------");

if (answer == 1)

{



    Console.WriteLine("Да начнётся бой!");

    var BattleArena = new BattleArena(Enemy, Hero, Weapon);

    var BackPack = new BackPack(10);

    BackPack.Looting(BattleArena.Battle());

}

else if (answer == 2)

{

    Console.WriteLine("Уходишь?");

    Console.WriteLine("Вот тебе два варианта:");

    Console.WriteLine("1-Уйти,2-Выйти на поле боя.");

res:

    Console.WriteLine("Я выбираю:");

    int answer1 = int.Parse(Console.ReadLine());

    if (answer1 == 1)

    {

        Console.WriteLine($"{Hero.Name} У тебя был шанс стать великим бойцом");

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Игра окончена...");

    }

    if (answer1 == 2)

    {

        Console.WriteLine($"Хорошо {Hero.Name}");

        Console.WriteLine("Бой начинается прямо сейчас!");

        var BattleArena = new BattleArena(Enemy, Hero, Weapon);

        var BackPack = new BackPack(10);

        BackPack.Looting(BattleArena.Battle());



    }


}



