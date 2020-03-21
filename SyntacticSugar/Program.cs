using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {

            var Bug1Preditors = new List<string> { "Cat", "Snake", "Ardvark" };
            var Bug1Prey = new List<string> { "dung", "shit", "crap" };
            var Bug2Prey = new List<string> { "Flies", "Wasps", "Camels" };

            var Bug1 = new Bug("Billy", "Dung Beetle", Bug1Preditors, Bug1Prey);
            var Bug2 = new Bug("Samson", "Spider", Bug1Preditors, Bug2Prey);

            Console.WriteLine(Bug1.Eat("shit"));
            Console.WriteLine(Bug2.Eat("chicken"));

            Console.ReadKey();
        }
    }
}
