// IP-адрес и порт, на которых будет работать сервер
using System.Net;
using System.Net.Sockets;
using System.Text;

List<IPEndPoint> clients = new List<IPEndPoint>();

int port = 11000; // Можно заменить на любой свободный порт
string groupAddress = "239.0.0.1"; // Многоадресный IP-адрес для групповой рассылки

// Создание UDP сокета и привязка к многоадресному адресу и порту
UdpClient udpServer = new UdpClient();
udpServer.JoinMulticastGroup(IPAddress.Parse(groupAddress));
udpServer.Client.Bind(new IPEndPoint(IPAddress.Any, port));

Console.WriteLine("Сервер запущен. Ожидание сообщений...");

while (true)
{
    byte[] data;
    IPEndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
    data = udpServer.Receive(ref senderEndPoint); // Use 'ref' here

    string message = Encoding.UTF8.GetString(data);
    Console.WriteLine("Received message from client: " + message);

    // Add the sender's endpoint to the list of clients if it's not already there
    if (!clients.Contains(senderEndPoint))
    {
        clients.Add(senderEndPoint);
    }

    // Forward the message to all clients in the group (including the sender)
    foreach (var clientEndPoint in clients)
    {
        udpServer.Send(data, data.Length, clientEndPoint);
    }
}