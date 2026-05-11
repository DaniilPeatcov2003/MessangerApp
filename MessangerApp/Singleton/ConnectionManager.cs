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

        private List<string> connections;

        private WebSocketManager()
        {
            connections = new List<string>();
        }

        public static WebSocketManager Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new WebSocketManager();
            }

            return uniqueInstance;
        }

        public void AddConnection(string user)
        {
            if (!connections.Contains(user))
                connections.Add(user);
        }

        public List<string> GetConnections()
        {
            return connections;
        }
    }
}
