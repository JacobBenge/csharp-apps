using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class TempServer
    {
        // produce a random number
        Random rand = new Random();
        string[] jokes;
        string[] conspiracies;
        const string JOKE_FILE = "jokes.txt";
        const string CONSP_FILE = "conspiracies.txt";

        public TempServer()
        {

        }

        public void LoadFiles()
        {
            try
            {
                // Automatically populates the arrays
                jokes = File.ReadAllLines(JOKE_FILE);
                conspiracies = File.ReadAllLines(CONSP_FILE);
            }
            catch (Exception ex)
            {
                // print error to the console.
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Returns random joke from jokes array
        /// </summary>
        /// <returns></returns>
        public string GetRandomJoke()
        {
            return jokes[rand.Next(jokes.Length)];
        }

        /// <summary>
        /// Returns random conspiracy
        /// </summary>
        /// <returns></returns>
        public string GetRandomConspiracy()
        {
            return conspiracies[rand.Next(conspiracies.Length)];
        }
    }
}
