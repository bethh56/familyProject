using System;
using System.Collections.Generic;
using System.Linq;

namespace familyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Brandon" }, { "age", "30" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Tim" }, { "age", "55" } });

       
            foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"{ familyMember.Value["name"]} is my { familyMember.Key } and is { familyMember.Value["age"] }");
            }
        }
    }
}
