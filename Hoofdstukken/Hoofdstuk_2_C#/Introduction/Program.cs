using System;
using System.Net;

namespace Introduction {
    class Program { // class
        private static void Output1() {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        private static void Output2() {
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /___|");

            Console.ReadLine();
        }

        private static void Output3() {
            string charachterName = "George";
            int charachterAge = 70;

            Console.WriteLine("There once was a man named " + charachterName);
            Console.WriteLine("He was " + charachterAge + " years old");
            Console.WriteLine("He really liked the name " + charachterName);
            Console.WriteLine("But didn't like being " + charachterAge);

            Console.ReadLine();
        }

        private static void Output4() {
            string phrase = "Giraffe Acadamy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = false;

            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine(gpa);
            Console.WriteLine(isMale);

            Console.ReadLine();
        }

        private static void Output5() {
            string phrase = "Giraffe Acadamy";

            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length + " == 15");
            Console.WriteLine(phrase.ToUpper() + " == GIRAFFE ACADEMY");
            Console.WriteLine(phrase.Contains("Acadamy") + " == True");
            Console.WriteLine(phrase[0] + " == G");
            Console.WriteLine(phrase.IndexOf('f') + " == 4");
            Console.WriteLine(phrase.Substring(8, 3) + " == Ace");

            Console.ReadLine();
        }

        private static void Output6() {

            Console.WriteLine(Math.Abs(-10) + " == 10");
            Console.WriteLine(Math.Pow(8, 2) + " == 64");
            Console.WriteLine(Math.Sqrt(36) + " == 6");
            Console.WriteLine(Math.Max(4, 90) + " == 90");
            Console.WriteLine(Math.Round(3.2) + " == 3");

            Console.ReadLine(); // shows the output
        }

        static void Main(string[] args) { // main method
            Output6();
        }
    }
}
