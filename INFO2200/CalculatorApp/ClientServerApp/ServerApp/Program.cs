using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Instantiate the server
            //TempServer tempServer = new TempServer();
            //// Tell the server to load the files
            //tempServer.LoadFiles();

            Console.WriteLine("Welcome to Jacob's Joke/Conspiracy Server");
            Console.WriteLine("-----------------------------------------");
            //while (true)
            //{
            //    Console.WriteLine("Type q to quit");
            //    string userInput = Console.ReadLine();
            //    // continue to run the console app until q is pressed
            //    if(userInput == "q")
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"Joke: {tempServer.GetRandomJoke()}");
            //    Console.WriteLine($"Conspiracy: {tempServer.GetRandomConspiracy()}");
            //}

            SynchronousSocketListener ssl = new SynchronousSocketListener();
            ssl.StartListening();
        }
    }
}
