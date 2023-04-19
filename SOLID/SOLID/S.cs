using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Каждый класс имеет только одну ответственность
namespace SOLID
{
    // Класс Customer отвечает только за данные клиента
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    // Класс CustomerRepository отвечает только за сохранение данных клиента
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            // код для сохранения данных клиента в базе данных
        }
    }

    // Класс EmailService отвечает только за отправку электронной почты
    public class EmailService
    {
        public void SendEmail(string to)
        {
            // код для отправки электронной почты
        }
    }

}