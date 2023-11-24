using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main()
        {
            Figher[] fighers =
            {
                new Figher("Генадий", 70, 50, 30),
                new Figher("Роман", 100, 30, 30),
                new Figher("Виталий", 150, 10, 10),
                new Figher("Александр", 50, 70, 30)
            };

            int fighersNumber;

            for (int i = 0; i < fighers.Length; i++)
            {
                Console.Write(i + 1 + " ");
                fighers[i].ShowStats();
            }

            Fun("\nВыберите номер первого бойца ");
            Figher fristFight = fighers[fighersNumber - 1];

            Fun("\nВыберите номер второго бойца ");
            Figher secondFight = fighers[fighersNumber - 1];

            while (fristFight.Health > 0 && secondFight.Health > 0)
            {
                Fun2(fristFight, secondFight, fristFight);
                Fun2(secondFight, fristFight, secondFight);
            }
            if (fristFight.Health <= 0)
            {
                Console.WriteLine($"{fristFight.Name} побеждён");
            }
            else if (secondFight.Health <= 0)
            {
                Console.WriteLine($"{secondFight.Name} побеждён");
            }
            void Fun2(Figher a, Figher b, Figher c)
            {
                a.TakeDamage(b.Damage);
                c.ShowCurrentHealth();
            }
            void Fun(string text)
            {
                Console.WriteLine();
                Console.Write(text);
                fighersNumber = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class Figher
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;
        
        public int Health
        {
            get
            {
                return _health;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        public Figher(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Боец - {_name}, здоровье: {_health}," +
                              $"наносимый урон: {_damage}, броня: {_armor}");
        }
        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}");
        }
        public void TakeDamage(int _damage)
        {
            _health -= _damage - _armor;
        }
    }
}


