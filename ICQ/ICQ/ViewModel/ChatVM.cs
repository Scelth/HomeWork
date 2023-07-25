using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICQ.Services.Inerfaces;
using ICQ.Messages;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Security.RightsManagement;
using ICQ.Model;

namespace ICQ.ViewModel
{
    class ChatVM : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigateService _navigateService;
        UserModel User;

        string Messages { get; set; }

        int serverPort = 11000; // Replace with the server port
        string serverAddress = "127.0.0.1"; // Replace with the multicast IP address of the server


        public ChatVM(IMessenger messenger, INavigateService navigateService)
        {
            _messenger = messenger;
            _navigateService = navigateService;

            UdpClient udpClient = new UdpClient();
            IPAddress serverIpAddress = IPAddress.Parse(serverAddress);
            udpClient.JoinMulticastGroup(serverIpAddress);

            // Bind the client to a local address and a random available port
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 0);
            udpClient.Client.Bind(localEndPoint);

            // Get the actual port used by the client
            int localPort = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;

            // Address and port of the server
            IPEndPoint serverEndPoint = new IPEndPoint(serverIpAddress, serverPort);

            var receiveThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    byte[] receivedData = udpClient.Receive(ref serverEndPoint); // Use 'ref' here as well
                    string message = Encoding.UTF8.GetString(receivedData);
                    Messages = User.Username + ": sdas" + message;
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
        }

    }
}
