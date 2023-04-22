//Connecting to the Python server.
using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        IPAddress ip = IPAddress.Parse("192.168.1.33");
        int port = 3580;
        TcpClient client = new TcpClient();
        client.Connect(ip, port);
        Console.WriteLine("client connected!!");
        NetworkStream ns = client.GetStream();

        string message;
        while (true)
        {
            Console.Write(">>>");
            message = Console.ReadLine();
            var buffer = Encoding.UTF8.GetBytes(message);
            ns.Write(buffer, 0, buffer.Length);
            if (message == "bye")
            {
                break;
            }
            var receivedBytes = new byte[1024];
            //Console.WriteLine("1");
            var read = ns.Read(receivedBytes, 0, receivedBytes.Length);
            //var formated = new byte[byte_count];
            string data = Encoding.UTF8.GetString(receivedBytes, 0, read);
            Console.WriteLine(data);
        }
    }
}