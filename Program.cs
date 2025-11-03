    using System;
    using atneevkin17;

    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "Герой";
            int value2 = 100;
            int value3 = 10;
            int value4 = 20;
            int value5 = 15;
            float value6 = 2.0f;
            bool value7 = false;
            Player player = new Player(value2, value1, value3, value4, value5, value6, value7);
            string mvalue1 = "Гоблин";
            int mvalue2 = 120;
            int mvalue3 = 8;
            int mvalue4 = 18;
            Monster monster = new Monster(mvalue2, mvalue1, mvalue3, mvalue4);
            Game game = new Game(player, monster);
            Console.WriteLine(game.Starting());
            bool gameOver = false;
            bool surrendered = false;
            while (gameOver == false)
            {
                Console.WriteLine();
                string playerAction = game.PlayerTurn();
                Console.WriteLine(playerAction);
                if (playerAction.Contains("сдался"))
                {
                    surrendered = true;
                    gameOver = true;
                    break;
                }
                if (monster.Health > 0 && player.Health > 0)
                {
                    Console.WriteLine(game.MonsterTurn());
                }
                if (player.Health <= 0 || monster.Health <= 0)
                {
                    gameOver = true;
                }
            }
            Console.WriteLine();
            if (surrendered == true)
            {
              
            }
            else if (player.Health <= 0)
            {
                Console.WriteLine("Игрок пал! Победил монстр!");
            }
            else if (monster.Health <= 0) //взаимоисключающие условия 
            {
                Console.WriteLine("Монстр пал! Победил игрок!");
            }

            Console.WriteLine("\nИгра окончена!");
            Console.WriteLine(game.ShowGameLog());
        }
    }
