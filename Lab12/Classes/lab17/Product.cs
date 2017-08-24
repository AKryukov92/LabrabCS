using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.lab17
{
    public class Product
    {
        public String Productid { private set; get; }
        public String Description { private set; get; }
        public String Productgroupid { private set; get;}
        public String Unitid { private set; get; }
        public String Weight { private set; get; }
        public String Cost { private set; get; }
        public String Quantity { private set; get; }
        public Product (String productid, String description, String productgroupid, String unitid, String weight, String cost, String quantity)
        {
        Productid = productid;
        Description = description;
        Productgroupid = productgroupid;
        Unitid = unitid;
        Weight = weight;
        Cost = cost;
        Quantity = quantity;
        }
    }
}
