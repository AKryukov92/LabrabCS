using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.lab17
{
    public class DataMapper
    {
        public Dictionary<string, Client> LoadClientData(NpgsqlConnection connection)
        {
            Dictionary<String, Client> map = new Dictionary<string, Client>();
            String query =
                "SELECT" +
                " id" +
                ", checking_account" +
                ", inn" +
                ", name" +
                " FROM clients";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                String checkingAccount = reader.GetString(1);
                String inn = reader.GetString(2);
                String name = reader.GetString(3);
                Client client = new Client(id, checkingAccount, inn, name);
                map.Add(id, client);
            }
            reader.Close();
            return map;
        }
        public Dictionary<string, Product> LoadProductData(NpgsqlConnection connection)
        {
            Dictionary<String, Product> map = new Dictionary<string, Product>();
            String query =
                "SELECT" +
                " id" +
                ", description" +
                ", product_group_id" +
                ", unit_id" +
                ", weight" +
                ", cost" +
                ", quantity" +
                " FROM products";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String productid = reader.GetString(0);
                String description = reader.GetString(1);
                String productgroupid = reader.GetString(2);
                String unitid = reader.GetString(3);
                String weight;
                if (!reader.IsDBNull(4))
                {
                    weight = reader.GetString(4);
                }
                else
                {
                    weight = "0";
                }
                String cost = reader.GetString(5);
                String quantity = reader.GetString(6);
                Product product = new Product(productid, description, productgroupid, unitid, weight, cost, quantity);
                map.Add(productid, product);
            }
            reader.Close();
            return map;
        }
        public Dictionary<String, String> LoadGroupData(NpgsqlConnection connection)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            String query =
                "SELECT" +
                " id" +
                ", name" +
                " FROM product_groups";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                String name = reader.GetString(1);
                map.Add(id, name);
            }
            reader.Close();
            return map;
        }
        public Dictionary<String, List<Employee>> LoadEmployeeDataByPosition(NpgsqlConnection connection)
        {
            Dictionary<String, List<Employee>> map = new Dictionary<String, List<Employee>>();
            String query =
                "SELECT" +
                " id" +
                ", last_name" + 
                ", first_name" +
                ", father_name" +
                ", gender" +
                ", birth_date" +
                ", marriage" + 
                ", postal_index" +
                ", address" + 
                ", position" +
                ", hire_type" +
                ", notes" +
                " FROM employees";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                String last_name = reader.GetString(1);
                String first_name = reader.GetString(2);
                String father_name = reader.GetString(3);
                String gender = reader.GetString(4);
                DateTime birth_date = reader.GetDateTime(5);
                Boolean marriage = reader.GetBoolean(6);
                String postal_index = reader.GetString(7);
                String address = reader.GetString(8);
                String position = reader.GetString(9);
                String hire_type = reader.GetString(10);
                String notes = reader.GetString(11);
                Employee employee = new Employee(id, last_name, first_name, father_name, gender, birth_date, marriage, 
                    postal_index, address, position, hire_type, notes);
                
                if (!map.ContainsKey(employee.Position))
                {
                    List<Employee> Employees = new List<Employee>();
                    Employees.Add(employee);
                    map.Add(position, Employees);
                }
                else
                {
                    map[employee.Position].Add(employee);
                }
            }
            reader.Close();
            return map;
        }
        public Dictionary<String, String> LoadPositionsData(NpgsqlConnection connection)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            String query =
                "SELECT" +
                " id" +
                ", name" +
                //", manager_id" +
                " FROM positions";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                String name = reader.GetString(1);
                //String manager_id = reader.GetString(2);
                map.Add(id, name);
            }
            reader.Close();
            return map;
        }
        public Dictionary<String, Order> LoadOrdersByClientData(NpgsqlConnection connection)
        {
            Dictionary<String, Order> map = new Dictionary<string, Order>();
            String query =
                "SELECT" +
                " id" +
                ", order_date" +
                ", product_id" +
                ", quantity" +
                ", client_id" +
                ", employee_id" +
                ", finished" +
                " FROM orders";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                DateTime order_date = reader.GetDateTime(1);
                String productid = reader.GetString(2);
                String quantity = reader.GetString(3);
                String clientid = reader.GetString(4);
                String employeeid = reader.GetString(5);
                Boolean finished = reader.GetBoolean(6);
                Order order = new Order(id, order_date, productid, quantity, clientid, employeeid, finished);
                map.Add(id, order);
            }
            reader.Close();
            return map;
        }
        public List<Employee> LoadEmployeeList(NpgsqlConnection connection)
        {
            List<Employee> map = new List<Employee>();
            String query =
                "SELECT" +
                " id" +
                ", last_name" +
                ", first_name" +
                ", father_name" +
                ", gender" +
                ", birth_date" +
                ", marriage" +
                ", postal_index" +
                ", address" +
                ", position" +
                ", hire_type" +
                ", notes" +
                " FROM employees";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                String last_name = reader.GetString(1);
                String first_name = reader.GetString(2);
                String father_name = reader.GetString(3);
                String gender = reader.GetString(4);
                DateTime birth_date = reader.GetDateTime(5);
                Boolean marriage = reader.GetBoolean(6);
                String postal_index = reader.GetString(7);
                String address = reader.GetString(8);
                String position = reader.GetString(9);
                String hire_type = reader.GetString(10);
                String notes = reader.GetString(11);
                Employee employee = new Employee(id, last_name, first_name, father_name, gender, birth_date, marriage,
                    postal_index, address, position, hire_type, notes);

                if (!map.Contains(employee))
                {
                    map.Add(employee);
                }
            }
            reader.Close();
            return map;
        }

        public Dictionary<String, Order> LoadOrdersDataByEmployee(NpgsqlConnection connection)
        {
            Dictionary<String, Order> map = new Dictionary<string, Order>();
            String query =
                "SELECT" +
                " id" +
                ", order_date" +
                ", product_id" +
                ", quantity" +
                ", client_id" +
                ", employee_id" +
                ", finished" +
                " FROM orders";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String id = reader.GetString(0);
                DateTime order_date = reader.GetDateTime(1);
                String productid = reader.GetString(2);
                String quantity = reader.GetString(3);
                String clientid = reader.GetString(4);
                String employeeid = reader.GetString(5);
                Boolean finished = reader.GetBoolean(6);
                Order order = new Order(id, order_date, productid, quantity, clientid, employeeid, finished);
                map.Add(id, order);
            }
            reader.Close();
            return map;
        }
    }
}
