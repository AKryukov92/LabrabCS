using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.lab17
{
    public class View
    {
        public Dictionary<String, Client> ClientData { set; get; }

        public void PrintClientData(String clientId)
        {
            Client client = ClientData[clientId];
            Console.WriteLine("<h3>" + client.Name + "</h3>");
            Console.WriteLine("<div>Расчетный счет:" + client.CheckingAccount + "</div>");
            Console.WriteLine("<div>ИНН:" + client.Inn + "</div>");
        }
    }
}
