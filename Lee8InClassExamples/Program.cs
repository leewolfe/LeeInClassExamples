using System;

namespace Lee8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Lee";
            char firstLetterOfFirstName = 'C';
            int favoriteNumber = 2;
            double pi = 3.14;
            bool isMarried = true;

            if (favoriteNumber == 0)
            {
                Console.WriteLine("Favorite number is equal to 0");
            }

            if (firstName != "Jimmy")
            {
                Console.WriteLine("First name is not Jimmy");
            }

            if (firstName != "lee")
            {
                Console.WriteLine("First name is not lee");
            }

            favoriteNumber = favoriteNumber + 5;
            favoriteNumber += 5; //favoriteNumber is 12

            favoriteNumber = favoriteNumber - 1;
            favoriteNumber -= 1;

            favoriteNumber = favoriteNumber + 1;
            favoriteNumber += 1;
            favoriteNumber++;

            Console.WriteLine(favoriteNumber);


        }
    }
}
