using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace udpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            //循环发送消息
            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("192.168.1.114"), 7788));
                if (message.Equals("exit"))
                    break;
            }

            client.Close();

            Console.ReadKey();
        }
    }
}
