using System.Net;
using System.Net.Sockets;
using System.Text;

List<IPEndPoint> clients = new List<IPEndPoint>();

int port = 11000;
string groupAddress = "127.0.0.1";

UdpClient udpServer = new UdpClient();
udpServer.JoinMulticastGroup(IPAddress.Parse(groupAddress));
udpServer.Client.Bind(new IPEndPoint(IPAddress.Any, port));

Console.WriteLine("Сервер запущен. Ожидание сообщений...");

while (true)
{
    byte[] data;
    IPEndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
    data = udpServer.Receive(ref senderEndPoint);

    string message = Encoding.UTF8.GetString(data);
    Console.WriteLine("Received message from client: " + message);

    if (!clients.Contains(senderEndPoint))
    {
        clients.Add(senderEndPoint);
    }

    foreach (var clientEndPoint in clients)
    {
        udpServer.Send(data, data.Length, clientEndPoint);
    }
}