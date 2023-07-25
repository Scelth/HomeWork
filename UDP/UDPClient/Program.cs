using System.Net.Sockets;
using System.Net;
using System.Text;

int serverPort = 11000; // Replace with the server port
string serverAddress = "239.0.0.1"; // Replace with the multicast IP address of the server

// Create a UDP client and join the multicast group
UdpClient udpClient = new UdpClient();
IPAddress serverIpAddress = IPAddress.Parse(serverAddress);
udpClient.JoinMulticastGroup(serverIpAddress);

// Bind the client to a local address and a random available port
IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 0);
udpClient.Client.Bind(localEndPoint);

// Get the actual port used by the client
int localPort = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;
Console.WriteLine("Client connected with IP address: " + localEndPoint.Address + ", Port: " + localPort);

// Address and port of the server
IPEndPoint serverEndPoint = new IPEndPoint(serverIpAddress, serverPort);

// Start a separate thread to receive messages from the server and other clients
var receiveThread = new System.Threading.Thread(() =>
{
    while (true)
    {
        byte[] receivedData = udpClient.Receive(ref serverEndPoint); // Use 'ref' here as well
        string message = Encoding.UTF8.GetString(receivedData);
        Console.WriteLine("Received message from server or another client: " + message);
    }
});

receiveThread.Start();

while (true)
{
    string messageToSend = Console.ReadLine();

    // Convert the message to a byte array
    byte[] data = Encoding.UTF8.GetBytes(messageToSend);

    // Send the message to the multicast group
    udpClient.Send(data, data.Length, serverEndPoint);
}