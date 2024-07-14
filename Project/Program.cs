using System;

namespace Cinemaa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies =
            {
                "Sing 2",
                "Moana",
                "Hello, Love, Goodbye!",
                "Parasite",
                "Despicable Me 4",
                "Harry Potter"
            };

            Console.WriteLine("Welcome to our Cinema"); 
            Console.WriteLine("Choose the movie you want to watch:");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {movies[i]}");
            }

            Console.Write("Enter a number (1 to 6) to choose a movie: ");
            int chosenmovie = Convert.ToInt32(Console.ReadLine()) - 1;

            if (chosenmovie >= 0 && chosenmovie < movies.Length)
            {
                string selectedMovie = movies[chosenmovie];
                Console.WriteLine($"You selected: {selectedMovie}");

                Console.WriteLine("Choose a time slot:");
                Console.WriteLine("1. 7-9 AM");
                Console.WriteLine("2. 9-11 AM");
                Console.WriteLine("3. 1-3 PM");
                Console.WriteLine("4. 3-4 PM");
                Console.WriteLine("5. 5-7 PM");
                Console.WriteLine("6. 7-9 PM");

                Console.Write("Enter a number (1 to 6) for the time slot: ");
                int time = Convert.ToInt32(Console.ReadLine());

                if (time >= 1 && time <= 6)
                {
                    int availableSlots = GetAvailableSlots(chosenmovie, time);

                    if (availableSlots > 0)
                    {
                        Console.WriteLine($"Available slots for '{selectedMovie}' at selected time: {availableSlots}");
                        
                        if (availableSlots > 2 && availableSlots <= 10)
                        {
                            Console.Write("how many slot you want?: ");
                            int slotyouwant = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("Are you sure you want to book this slot? (yes/no): ");
                        string confirmation = Console.ReadLine().ToLower();

                        if (confirmation == "yes")
                        {
                            Console.WriteLine("Slot booked successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Booking canceled.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, '{selectedMovie}' at selected time is fully booked.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please enter a number between 1 and 6 for the time slot.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a number between 1 and 6 to choose a movie.");
            }

            Console.WriteLine("Thank you for choosing our Cinema!");

        }

        static int GetAvailableSlots(int chosenmovie, int time)
        {
            Random slot = new Random();
            return slot.Next(0, 10);
        }

    }
}
