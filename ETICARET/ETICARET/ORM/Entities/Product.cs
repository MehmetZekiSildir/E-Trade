using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Entities
{
    internal class Product
    {
        //Entity Framework bir propertyde 'ID,id,Id,vb' kelimeleri görürse o property direk PRIMARYKEY ve IDENTIFIER özellikleri atar.
       
        public int ID { get; set; }

        [MaxLength(30)]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        //Mapping her ürün bir kategoriye aittir.
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return ProductName +" "+Price;
        }
    }
}
