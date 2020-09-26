using System;
using System.Net;
using System.Transactions;

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

        private static void Output7() {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.ReadLine();
        }

        private static void Calculator1() {
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine(sum);

            Console.ReadLine();
        }

        private static void Output8() {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Elias";
            // { "Elias", "Inge", "Joell", "Geert" };

            Console.WriteLine(luckyNumbers[2] + " == 15");
            luckyNumbers[0] = 100;
            Console.WriteLine(luckyNumbers[0] + " == 100");
            Console.WriteLine(friends[0]);

            Console.ReadLine();
        }

        private static void Output9() { // if and else
            bool isMale = false;
            bool isFemale = false;

            if (isMale) {
                Console.WriteLine("You are male");
            } else {
                if (isFemale) {
                    Console.WriteLine("You are a female");
                } else {
                    Console.WriteLine("You are X");
                }
            }

            Console.ReadLine();
        }

        private static void Output10() {  // switch statement
            Console.WriteLine("Give a number (0 -> Monday, 6 -> Sunday)");
            int number = Convert.ToInt32(Console.ReadLine());

            String day;

            switch (number) {
                case 0:
                    day = "Monday";
                    break;
                case 1:
                    day = "Tuesday";
                    break;
                case 2:
                    day = "Wednesday";
                    break;
                case 3:
                    day = "Thursday";
                    break;
                case 4:
                    day = "Friday";
                    break;
                case 5:
                    day = "Saturday";
                    break;
                case 6:
                    day = "Sunday";
                    break;
                default:
                    day = String.Format("Not valid number (" + number + ")");
                    break;

            }

            Console.WriteLine(day);

            Console.ReadLine();
        }

        private static void Output11() { // while loop
            int index = 1;
            while (index <= 5) {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();

        }

        private static void Output12() { // for loop

            int[] numbers = { 1, 16, 12, 4, 9 };

            foreach (int el in numbers) {
                Console.WriteLine(el);
            }

            Console.ReadLine();
        }

        private static void Output13() { // 2D Array

            int[,] numberGrid = {
                {1, 2},
                {4, 5},
                { 9, 10}

            };

            Console.WriteLine(numberGrid[0, 1]);

            Console.ReadLine();
        }

        private static void Output14() { // constructor
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);


            /*
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;
            */

            Console.WriteLine(book1.author);
            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();

        }

        private static void Output15() { // methods
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHoners());
            Console.WriteLine(student2.HasHoners());

            Console.ReadLine();
        }

        private static void Output16() { // getter and setters 

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "dog");

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);

            Console.ReadLine();

        }

        static void Main(string[] args) { // main method
            Output16();
        }
    }
}
