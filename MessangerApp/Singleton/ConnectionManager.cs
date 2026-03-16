using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp.Singleton
{
    public class WebSocketManager
    {
        private static WebSocketManager uniqueInstance;

        // singletonData
        private List<string> connections;

        // приватный конструктор (запрещает создание объекта извне)
        private WebSocketManager()
        {
            connections = new List<string>();
        }

        // static Instance()
        public static WebSocketManager Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new WebSocketManager();
            }

            return uniqueInstance;
        }

        // SingletonOperation()
        public void AddConnection(string user)
        {
            if (!connections.Contains(user))
                connections.Add(user);
        }

        // GetSingletonData()
        public List<string> GetConnections()
        {
            return connections;
        }
    }
}
