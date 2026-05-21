using MessangerApp.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp.Observer
{
    public class UserObserver : IObserver
    {
        private string name;

        public UserObserver(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            MessageBox.Show(name + " получил уведомление: " + message);
        }
    }
}
