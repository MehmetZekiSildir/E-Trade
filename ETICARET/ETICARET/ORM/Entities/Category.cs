using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Entities
{
    internal class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Mapping 1-N bir kategorinin birden fazla ürünü vardır.
        public List<Product> Products { get; set; }
    }
}
