using System;
using System.Collections.Generic;
using System.IO;
using Common;
using EfDbContext;
using Newtonsoft.Json;
using Exception = System.Exception;

namespace MagicParserApp
{
    public class Program
    {
        private static readonly string _path = Directory.GetCurrentDirectory() + @"\text.txt";
        static void Main(string[] args)
        {
            string text;
            using (var sr = new StreamReader(_path))
            {
                text = sr.ReadToEnd();
            }

            var jsonData = JsonConvert.DeserializeObject<List<SpellModel>>(text);
            var context = new MsSqlController();

            try
            {
                foreach (var spell in jsonData)
                {
                    context.AddNewSpell(spell);
                    Console.WriteLine($"Added spell {spell.SpellName}");
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }

            Console.WriteLine("Work finished");
            Console.ReadLine();
        }
}
}
