using System;

namespace lab4 {

    class Program {

        static void Main(string[] args) {

            Console.WriteLine("If you would like a full pyramid, type 'Full'. \nIf you would like a partial pyramid, type 'Partial'!");
            string input = Console.ReadLine();

            Random rnd = new Random();
            int rows = rnd.Next(2, 10);

            if (input == "Full" || input == "full") {
                getFull(rows);
            }
            else if (input == "Partial" || input == "partial") {
                getPartial(rows);
            }

        }

        static void getFull(int rows) {

            for (int i = 0; i < rows; i++) {
                for (int k = 0; k < i; k++) {
                    Console.Write("o");
                }
                Console.Write("\n");
            }

        }

        static void getPartial(int rows) {

            Random rnd = new Random();
            int choice = 0;
            
            for (int i = 0; i < rows; i++) {
                for (int k = 0; k < i; k++) {
                    choice = rnd.Next(2);
                    if (choice == 0) {
                        Console.Write("o");
                    }
                    else {
                        Console.Write(" ");
                    }
                    
                }
                Console.Write("\n");
            }

        }












    }






}
