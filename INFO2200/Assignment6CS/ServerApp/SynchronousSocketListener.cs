using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApp
{
    public class SynchronousSocketListener
    {
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string UVUFACT = "UVUFACT";
        const string UVUMAJOR = "UVUMAJOR";
        string[] uvufacts;
        string[] uvumajor;
        const string FACTFILE = "UVUFacts.txt";
        const string MAJORFILE = "UVUCourseDescriptions.txt";
        TcpListener tcpListener;
        public SynchronousSocketListener()
        {
            try
            {
                // Automatically populates the arrays
                uvufacts = File.ReadAllLines(FACTFILE);
                uvumajor = File.ReadAllLines(MAJORFILE);
            }
            catch (Exception ex)
            {
                // print error to the console.
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Begin listening
        /// </summary>
        public void StartListening()
        {
            // Requires using System.Net.Sockets; and using System.Net;
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            tcpListener = new TcpListener(iPAddress, PORT);
            // Start listening
            tcpListener.Start();
            // Put on new thread to reduce workload
            Thread thread = new Thread(new ThreadStart(ProcessSocket));
            // stay in memory
            thread.Start();
        }
        public void ProcessSocket()
        {
            while (true)
            {
                try
                {
                    Socket socket = tcpListener.AcceptSocket();
                    // Allows us to listen through this stream
                    NetworkStream ns = new NetworkStream(socket);
                    // Read the responses when they come.
                    StreamReader reader = new StreamReader(ns);
                    // Use StreamWriter to write to the networkStream
                    StreamWriter writer = new StreamWriter(ns);
                    // Reduce buffering issues. No left over bits with request.
                    writer.AutoFlush = true;

                    // read client input
                    string clientInput = reader.ReadLine();
                    // write to console
                    Console.WriteLine($"Received from client: {clientInput}");

                    // Produce a random number
                    Random rand = new Random();
                    if (clientInput.ToUpper() == UVUFACT)
                    {
                        // grab a random fact from uvufacts array
                        string fact = uvufacts[rand.Next(uvufacts.Length)];
                        // write to console
                        Console.WriteLine(fact);
                        // write to client
                        writer.WriteLine(fact);
                    }
                    else if (clientInput.ToUpper() == UVUMAJOR)
                    {
                        // grab a random conspiracy from the uvumajor array
                        string major = uvumajor[rand.Next(uvumajor.Length)];
                        // write to console
                        Console.WriteLine(major);
                        // write to client
                        writer.WriteLine(major);
                    }
                    else
                    {
                        // default
                        writer.WriteLine($"Could not do anything with: {clientInput}");
                    }
                }
                catch (Exception ex)
                {
                    // oops an error
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }
    }
}
