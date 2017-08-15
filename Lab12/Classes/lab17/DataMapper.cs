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
    }
}
