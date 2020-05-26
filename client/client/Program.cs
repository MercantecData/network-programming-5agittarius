using System;
using System.Net.Sockets;
using System.Net;
using System.Text;




,,,
namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();

            int port = 2069;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(ip, port);

            client.Connect(endPoint);

            NetworkStream stream = client.GetStream();

            string text = Console.ReadLine();
            byte[] buffer = Encoding.UTF8.GetBytes(text);

            stream.Write(buffer, 0, buffer.Length);
            client.Close();
        }
    }
}
