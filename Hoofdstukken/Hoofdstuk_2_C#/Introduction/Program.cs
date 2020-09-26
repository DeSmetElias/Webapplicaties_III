using System;

namespace Introduction {
    class Program { // class
        static void Main(string[] args) { // main method
            Output4();
        }

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

            Console.ReadLine();
        }
    }
}
