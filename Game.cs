using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atneevkin17
{
    internal class Game
    {
        private Player player;
        private Monster monster;

        public Game(Player player, Monster monster)
        {
            this.player = player;
            this.monster = monster;
        }
        private List<string> gameLog = new List<string>();
        public string ShowGameLog()
        {
            string result = "Журнал битвы:\n";
            foreach (string log in gameLog)
            {
                result += log + "\n";
            }
            return result;
        }
        public string Starting()
        {

            string result = $"Новая битва началась!\n\n" +
                            $"Герой: {player.Name}\n" +
                            $"HP: {player.Health}\n" +
                            $"Сила атаки: от {player.MinHit} до {player.MaxHit}\n\n" +
                            $"Монстр: {monster.Name}\n" +
                            $"HP: {monster.Health}\n" +
                            $"Сила атаки: от {monster.MinHit} до {monster.MaxHit}";
            return result;

        }
        public string Ending()
        {
            if (player.Health == 0)
            {
                return "монстр победил";
            }
            if (monster.Health == 0)
            {
                return "игрок победил";
            }
            return ""; 
        }
        public string MonsterTurn()
        {
            int damage = monster.GetAttackDamage(); // атака монстра 
            player.TakeDamage(damage); // игрок получает урон           

                string result = $"Монстр атакует и наносит {damage} урона! HP игрока: {player.Health}";
                gameLog.Add(result);    
                return result; 
        }
        public string PlayerAttack()
        {
            int damage = player.GetAttackDamage();  // игрок наносит урон
            monster.TakeDamage(damage);             // монстр получает урон

            string result = $"Игрок атакует и наносит {damage} урона! HP монстра: {monster.Health}";
            gameLog.Add(result);
            return result;
        }
        public string PlayerSpecialAttack()
        {
            float damage = player.SpecialAtack();  // игрок наносит урон
            monster.TakeDamage((int)damage);            // монстр получает урон

            string result = $"Игрок атакует и наносит {damage} урона! HP монстра: {monster.Health}";
            gameLog.Add(result);
            return result;
        }
        public string PlayerHeal()
        {
            Console.WriteLine("введите на сколько вы хотите изличиться");
            int getheal = int.Parse(Console.ReadLine());
            int heal  = player.Heal(getheal); 
            string result = $" HP игрока после хила: {player.Health}";
            gameLog.Add(result);
            return result;
        }
        public string PlayerSurrender()
        {
            player.TakeDamage(player.Health);
            string result = $"Игрок сдался! Монстр побеждает! HP игрока: {player.Health}";
            gameLog.Add(result);
            return result;
        }
        public string PlayerTurn()
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1 - Обычная атака");
            Console.WriteLine("2 - Специальная атака");
            Console.WriteLine("3 - Лечение");
            Console.WriteLine("4 - Сдаться");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return PlayerAttack();
                case "2":
                    return PlayerSpecialAttack();
                case "3":
                    return PlayerHeal();
                case "4":
                    return PlayerSurrender();
                default:
                    return "Некорректный выбор. Попробуйте снова.";
            }
        }
    }
}


