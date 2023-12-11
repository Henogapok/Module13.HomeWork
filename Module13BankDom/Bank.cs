using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13.HomeWork
{
    public class Bank
    {
        private Queue<Client> queue = new Queue<Client>();
        private List<Service> serviceTypes = new List<Service>();

        public void Enqueue(Client client)
        {
            queue.Enqueue(client);
            Console.WriteLine($"Клиент {client.ShortName} добавлен в очередь. Текущее количество клиентов в очереди: {queue.Count}");
        }

        public Client Dequeue()
        {
            if (queue.Count > 0)
            {
                var nextClient = queue.Dequeue();
                var serviceType = serviceTypes.FirstOrDefault(st => st.ServiceTypeId == nextClient.ServiceID);

                Console.WriteLine($"Клиент {nextClient.ShortName} ({serviceType?.Name}) обслужен за {serviceType?.ServiceTime.TotalMinutes} минут. Текущее количество клиентов в очереди: {queue.Count}");
                return nextClient;
            }
            else
            {
                Console.WriteLine("Очередь пуста. Нет клиентов для обслуживания.");
                return null;
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Текущая очередь:");
            foreach (var client in queue)
            {
                Console.WriteLine($"Клиент {client.ShortName} ({client.Age} лет)");
            }
        }
    }
}
