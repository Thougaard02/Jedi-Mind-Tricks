using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPG 1
            Dictionary<string, int> persons = new Dictionary<string, int>();


            //OPG 3
            persons.Add("Rasmus", 18);

            persons["Peter"] = 20;

            foreach (KeyValuePair<string, int> person in persons)
            {
                Console.WriteLine($"My name is {person.Key}");
            }
            //OPG 3
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                 { "Luke", true },
                 { "Han", false },
                 { "Chewbacca", false }
            };

            if (characters.Remove("Han"))
            {
                Console.WriteLine("Removed Han");
            }
            else
            {
                Console.WriteLine("Couldn't find Han");
            }

            //OPG 4
            foreach (KeyValuePair<string, bool> character in characters)
            {
                Console.WriteLine($"{character.Key}, {character.Value}");
            }
        }
    }
}
