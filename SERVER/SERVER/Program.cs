using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
namespace SERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            int port1 = 2069;
            IPAddress ip1 = IPAddress.Any;
            IPEndPoint localEndpoint = new IPEndPoint(ip1, port1);
            TcpListener listener = new TcpListener(localEndpoint);
            listener.Start();
            Console.WriteLine("Awaiting Clients");
            TcpClient client1 = listener.AcceptTcpClient();
            NetworkStream stream1 = client1.GetStream();
            byte[] buffer1 = new byte[256];
            int numberOfBytesRead = stream1.Read(buffer1, 0, 256);
            string message = Encoding.UTF8.GetString(buffer1, 0, numberOfBytesRead);
            Console.WriteLine(message);
        }
    }
}
