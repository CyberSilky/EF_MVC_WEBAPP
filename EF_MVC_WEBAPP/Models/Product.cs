using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_MVC_WEBAPP.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }

    }
}