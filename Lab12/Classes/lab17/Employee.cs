using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.lab17
{
    public class Employee
    {
        public String Id { private set; get; }
        public String Last_name { private set; get; }
        public String First_name { private set; get; }
        public String Father_name { private set; get; }
        public String Gender { private set; get; }
        public DateTime Birth_date { private set; get; }
        public Boolean Marriage { private set; get; }
        public String Postal_index { private set; get; }
        public String Address { private set; get; }
        public String Position { private set; get; }
        public String Hire_type { private set; get; }
        public String Notes { private set; get; }

        public Employee(String id, String last_name, String first_name, String father_name, String gender, 
            DateTime birth_date, Boolean marriage, String postal_index, String address, String position, 
            String hire_type, String notes)
        {
            Id = id;
            Last_name = last_name;
            First_name = first_name;
            Father_name = father_name;
            Gender = gender;
            Birth_date = birth_date;
            Marriage = marriage;
            Postal_index = postal_index;
            Address = address;
            Position = position;
            Hire_type = hire_type;
            Notes = notes;
        }
    }
}
