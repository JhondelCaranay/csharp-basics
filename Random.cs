namespace Basics;
using System;


public class Random
{
    public void Sample()
    {
        // Instantiate random number generator using system-supplied value as seed.
        var rand = new System.Random();

        // Generate and display 5 random byte (integer) values.
        var bytes = new byte[5];
        rand.NextBytes(bytes);
        Console.WriteLine("Five random byte values:");
        foreach (byte byteValue in bytes)
            Console.Write("{0, 5}", byteValue);
        Console.WriteLine();

        // Generate and display 5 random integers.
        Console.WriteLine("Five random integer values:");
        for (int ctr = 0; ctr <= 4; ctr++)
            Console.Write("{0,15:N0}", rand.Next());
        Console.WriteLine();

        // Generate and display 5 random integers between 0 and 100.
        Console.WriteLine("Five random integers between 0 and 100:");
        for (int ctr = 0; ctr <= 4; ctr++)
            Console.Write("{0,8:N0}", rand.Next(101));
        Console.WriteLine();

        // Generate and display 5 random integers from 50 to 100.
        Console.WriteLine("Five random integers between 50 and 100:");
        for (int ctr = 0; ctr <= 4; ctr++)
            Console.Write("{0,8:N0}", rand.Next(50, 101));
        Console.WriteLine();

        // Generate and display 5 random floating point values from 0 to 1.
        Console.WriteLine("Five Doubles.");
        for (int ctr = 0; ctr <= 4; ctr++)
            Console.Write("{0,8:N3}", rand.NextDouble());
        Console.WriteLine();

        // Generate and display 5 random floating point values from 0 to 5.
        Console.WriteLine("Five Doubles between 0 and 5.");
        for (int ctr = 0; ctr <= 4; ctr++)
            Console.Write("{0,8:N3}", rand.NextDouble() * 5);

        // The example displays output like the following:
        //    Five random byte values:
        //      194  185  239   54  116
        //    Five random integer values:
        //        507,353,531  1,509,532,693  2,125,074,958  1,409,512,757    652,767,128
        //    Five random integers between 0 and 100:
        //          16      78      94      79      52
        //    Five random integers between 50 and 100:
        //          56      66      96      60      65
        //    Five Doubles.
        //       0.943   0.108   0.744   0.563   0.415
        //    Five Doubles between 0 and 5.
        //       2.934   3.130   0.292   1.432   4.369


        // Generate a random number between 1 and 100
        int randomNumber1To100 = rand.Next(1, 101);

        // Generate a random number between 0 and 1 // zero and one only and intiger
        double randomNumber0To1 = rand.NextDouble();
        double roundedRandomNumber0To1 = Math.Round(randomNumber0To1, 0);

        // Generate a random boolean
        bool randomBoolean = rand.Next(0, 2) == 0;
        Console.WriteLine();
        Console.WriteLine("\nRandom Number between 1 and 100: " + randomNumber1To100);
        Console.WriteLine("Random Number between 0 and 1: " + roundedRandomNumber0To1);
        Console.WriteLine("Random Boolean: " + randomBoolean);



        int secretNumber = rand.Next(1, 7); // Generate a random number between 1 and 6
        int attempts = 3;
        int currentAttempt = 0;

        Console.WriteLine("Welcome to the Guessing Game! {0}", secretNumber);
        Console.WriteLine("I've selected a random number between 1 and 6.");
        Console.WriteLine("You have 3 attempts to guess it.");

        do
        {
            currentAttempt++;

            Console.Write($"Attempt {currentAttempt}: Enter your guess: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                break;
            }
            else
            {
                Console.WriteLine($"Sorry, that's not the correct number. Attempts left: {attempts - currentAttempt}");
            }

        } while (currentAttempt < attempts);

        if (currentAttempt >= attempts)
        {
            Console.WriteLine($"You're out of attempts. The correct number was {secretNumber}.");
        }
    }
}
