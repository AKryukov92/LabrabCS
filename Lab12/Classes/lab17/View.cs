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

        public Dictionary<String, Product> ProductData { set; get; }

        public Dictionary<String, Order> OrdersData { set; get; }

        public void PrintClientData(String clientId)
        {
            Client client = ClientData[clientId];
            Console.WriteLine("<h3>" + client.Name + "</h3>");
            Console.WriteLine("<div>Расчетный счет:" + client.CheckingAccount + "</div>");
            Console.WriteLine("<div>ИНН:" + client.Inn + "</div>");
        }
        public void PrintProductData(String productid)
        {
            Product product = ProductData[productid];
            Console.WriteLine("<h3>" + product.Description + "</h3>");
            Console.WriteLine("<div>Цена: " + product.Cost + "</div>");
            Console.WriteLine("<div>Масса: " + product.Weight + "</div>");
            Console.WriteLine("<div>Остаток на складе: " + product.Quantity + "</div>");
        }
        public void PrintProductData(String productid, Dictionary<String, String> productGroups)
        {
            Product product = ProductData[productid];
            Console.WriteLine("<h3>" + product.Description + "</h3>");
            Console.WriteLine("<div>Группа товара: " + productGroups[product.Productgroupid]);
            Console.WriteLine("<div>Цена: " + product.Cost + "</div>");
            Console.WriteLine("<div>Масса: " + product.Weight + "</div>");
            Console.WriteLine("<div>Остаток на складе: " + product.Quantity + "</div>");
        }
        public void PrintProductData(Dictionary<String, String> productGroups)
        {
            int i;
            foreach (var item in productGroups)
            {
                i = 0;
                Console.WriteLine("<div>" + item.Value + "</div>");
                foreach (var it in ProductData)
                {
                    if (it.Value.Productgroupid == item.Key)
                    {
                        Console.WriteLine(it.Value.Description + "\n");
                        i++;
                    }
                }
                Console.WriteLine(i + " наименований");
            }
        }
        public void PrintEmployeesByPosition(Dictionary<String, List<Employee>> employeesByPosition, Dictionary<String, String> PositionMap)
        {
            foreach (var position in PositionMap)
            {
                Console.WriteLine("<div>" + position.Value + "</div>");
                foreach (var employee in employeesByPosition[position.Key])
                {
                    //if(position.Value==employee.Position)
                    //{
                    Console.WriteLine(employee.Last_name + " " + employee.First_name + "\n");
                    //}
                }
            }
        }
        public void PrintOpenClientOrders()
        {
            foreach (var client in ClientData)
            {
                Console.WriteLine("<h3>" + client.Value.Name + "</h3>");
                Console.WriteLine("<div>" + "Расчетный счёт: " + client.Value.CheckingAccount + "</div>");
                Console.WriteLine("<div>" + "ИНН: " + client.Value.Inn + "</div>");
                Console.WriteLine("Заказы:");
                foreach (var order in OrdersData)
                {
                    if (client.Key == order.Value.Clientid && order.Value.Finished == false)
                    {
                        Console.WriteLine("<div>" + ProductData[order.Value.Productid].Description + " в количестве " + order.Value.Quantity + " единиц на дату " + order.Value.Order_date.ToString("yyyy-MM-dd") + "</div>");
                    }
                }
            }
        }
        public void PrintClosedClientOrders()
        {
            foreach (var client in ClientData)
            {
                Console.WriteLine("<h3>" + client.Value.Name + "</h3>");
                Console.WriteLine("<div>" + "Расчетный счёт: " + client.Value.CheckingAccount + "</div>");
                Console.WriteLine("<div>" + "ИНН: " + client.Value.Inn + "</div>");
                Console.WriteLine("Заказы:");
                foreach (var order in OrdersData)
                {
                    if (client.Key == order.Value.Clientid && order.Value.Finished == true)
                    {
                        Console.WriteLine("<div>" + ProductData[order.Value.Productid].Description + " в количестве " + order.Value.Quantity + " единиц на дату " + order.Value.Order_date.ToString("yyyy-MM-dd") + "</div>");
                    }
                }
            }
        }
        public void PrintEmployeesOrders(List<Employee> employeeList, Dictionary<String, Order> OrdersDataByEmployee, Dictionary<String, String> PositionMap)
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee.Last_name + " " + employee.First_name);
                Console.WriteLine(PositionMap[employee.Position]);
                foreach (var order in OrdersDataByEmployee)
                {
                    if (employee.Id == order.Value.Employeeid)
                    {
                        if (order.Value.Finished == true)
                        { Console.Write("(закрыт) "); }
                        Console.WriteLine("<div>" + ProductData[order.Value.Productid].Description + " в количестве " + order.Value.Quantity + " единиц на дату " + order.Value.Order_date.ToString("yyyy-MM-dd") + ". Заказчик - " + ClientData[order.Value.Clientid].Name + "</div>");
                    }
                }
            }
        }
    }
}

