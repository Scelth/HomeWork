using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using System.Text;
using ICQ.Services.Inerfaces;
using System.Net.Sockets;
using System.Net;
using ICQ.Model;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace ICQ.ViewModel
{
    class ChatVM : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigateService _navigateService;
        UserModel User;

        private IPEndPoint serverEndPoint;
        UdpClient udpClient;

        private string _messages;
        public string Messages
        {
            get => _messages;
            set
            {
                Set(ref _messages, value);
            }
        }

        private string _currentMessage;
        public string CurrentMessage
        {
            get => _currentMessage;
            set
            {
                Set(ref _currentMessage, value);
            }
        }

        int serverPort = 11000;
        string serverAddress = "239.0.0.1";


        public ChatVM(IMessenger messenger, INavigateService navigateService, UserModel user)
        {
            _messenger = messenger;
            _navigateService = navigateService;
            User = user;

            udpClient = new UdpClient();
            IPAddress serverIpAddress = IPAddress.Parse(serverAddress);
            udpClient.JoinMulticastGroup(serverIpAddress);

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 0);
            udpClient.Client.Bind(localEndPoint);

            int localPort = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;

            serverEndPoint = new(serverIpAddress, serverPort);

            var receiveThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    byte[] receivedData = udpClient.Receive(ref serverEndPoint);
                    string message = Encoding.UTF8.GetString(receivedData);

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        Messages += message + "\n";
                    });
                }
            });

            receiveThread.Start();
        }

        public RelayCommand SendCommand
        {
            get => new(() =>
            {
                if (CurrentMessage != null)
                {
                    Messages += $"[{User}]: {CurrentMessage}\n";

                    byte[] data = Encoding.UTF8.GetBytes(Messages);
                    udpClient.Send(data, data.Length, serverEndPoint);

                    CurrentMessage = "";
                }
            });
        }
    }
}
