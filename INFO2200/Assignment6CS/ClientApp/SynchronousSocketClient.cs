using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class SynchronousSocketClient
    {
        // Port we are listening on
        const int SERVER_PORT = 11000;
        // Ip address. Using local host for development.
        const string IP_ADDRESS = "127.0.0.1";

        // Constructor method
        public SynchronousSocketClient()
        {

        }

        public string ContactServer(string request)
        {
            string responseString = "";
            try
            {
                // Requires using System.Net.Sockets; and using System.Net;
                TcpClient tcpClient = new TcpClient();
                // Connect using the given ip and port
                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), SERVER_PORT);
                // Allows us to listen through this stream
                NetworkStream networkStream = tcpClient.GetStream();
                // Read the responses when they come.
                StreamReader streamReader = new StreamReader(networkStream);
                // Use StreamWriter to write to the networkStream
                StreamWriter streamWriter = new StreamWriter(networkStream);
                // Reduce buffering issues. No left over bits with request.
                streamWriter.AutoFlush = true;
                // Pass in user input
                streamWriter.WriteLine(request);
                // Grab the response
                responseString = streamReader.ReadLine();
                // Close the stream and client
                networkStream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                // Grab the error message
                responseString = ex.Message;
            }
            // Returns either the error message or the actual response.
            return responseString;
        }
    }
}
