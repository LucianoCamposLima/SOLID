using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Utils
{
    class Notify
    {

        public Notify(Client c)
        {
            Console.WriteLine($"Notificando o cliente: {c.Nome}");
        }
    }
}
