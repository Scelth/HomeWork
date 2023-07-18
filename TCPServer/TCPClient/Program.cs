using System.Net.Sockets;
using System.Text;

string serverIP = "127.0.0.1";
int serverPort = 8080;

try
{
    // Создание объекта TcpClient и подключение к серверу
    TcpClient client = new(serverIP, serverPort);
    Console.WriteLine("Подключение к серверу {0}:{1} выполнено.", serverIP, serverPort);

    // Получение сетевого потока для чтения и записи
    NetworkStream stream = client.GetStream();

    // Отправка запроса на сервер
    string requestMessage = "Привет от клиента!";
    byte[] requestBuffer = Encoding.Unicode.GetBytes(requestMessage);
    stream.Write(requestBuffer, 0, requestBuffer.Length);
    Console.WriteLine("Запрос отправлен: " + requestMessage);

    // Получение ответа от сервера
    byte[] responseBuffer = new byte[client.ReceiveBufferSize];
    int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
    string responseMessage = Encoding.Unicode.GetString(responseBuffer, 0, bytesRead);
    Console.WriteLine("Получен ответ от сервера: " + responseMessage);

    // Закрытие соединения
    client.Close();
}

catch (Exception ex)
{
    Console.WriteLine("Ошибка при подключении к серверу: " + ex.Message);
}