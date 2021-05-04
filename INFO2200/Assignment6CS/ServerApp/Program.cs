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

            Console.WriteLine("Welcome to Jacob's UVUFact or UVUMajor Server");
            Console.WriteLine("-----------------------------------------");

            // Setup SSL connection
            SynchronousSocketListener ssl = new SynchronousSocketListener();
            ssl.StartListening();
        }
    }
}
