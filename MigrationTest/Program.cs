using Microsoft.EntityFrameworkCore;
using MigrationTest.Data;
using MigrationTest.Data.Entities;
using MigrationTest.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MigrationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context DnDContext = new Context();
            //AddHill(DnDContext);

            //DnDContext.Classes.Add(new Class { Name = "Плут", DiceHits = Dice.D8 });
            //DnDContext.SaveChanges();

            //var adventurer = DnDContext
            //                .Adventurers
            //                .FirstOrDefault();

            //var @class = DnDContext
            //             .Classes
            //             .Where(c => c.Name == "Плут")
            //             .FirstOrDefault();


            //adventurer.Classes = new List<Class>() { @class };

            //DnDContext.SaveChanges();

            Test2(DnDContext);

        }

        private static void Test2(Context DnDContext)
        {
            var test = DnDContext.Adventurers.ToList().FirstOrDefault();


        }

        private static void Print(DbSet<Class> classes)
        {
            Console.WriteLine("{0,10} | {1,10}", "Имя", "Класс");
            foreach (var @class in classes)
            {
                Console.WriteLine("{0,10} | {1,10}", @class.Name, "класс");
            }
        }

        private static void Print(List<Adventurer> adventures)
        {
            Console.WriteLine("{0,10} | {1,10}", "Имя", "Класс");
            foreach (var adventurer in adventures)
            {
                Console.WriteLine("{0,10} | {1,10}", adventurer.Name, "класс");
            }
        }

        private static void AddHill(Context DnDContext)
        {
            DnDContext.Adventurers.Add(new Adventurer()
            {
                Name = "Хил",
                HitPoints = 30,
                Race = new Race()
                {
                    Name = "Ork",
                    Speed = 30
                },
                Classes = new List<Class>()
                {
                    new Class()
                    {
                        Name = "Паладин",
                        DiceHits = Dice.D10
                    }
                }
            });
        }
    }
}
