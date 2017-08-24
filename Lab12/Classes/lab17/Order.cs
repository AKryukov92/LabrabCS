using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.lab17
{
    public class Order
    {
        public String Id { private set; get; }
        public DateTime Order_date { private set; get; }
        public String Productid { private set; get; }
        public String Quantity { private set; get; }
        public String Clientid { private set; get; }
        public String Employeeid { private set; get; }
        public Boolean Finished { private set; get; }

        public Order(String id, DateTime order_date, String productid, String quantity, String clientid, String employeeid, Boolean finished)
        {
            Id = id;
            Order_date = order_date;
            Productid = productid;
            Quantity = quantity;
            Clientid = clientid;
            Employeeid = employeeid;
            Finished = finished;
        }
    }
}
