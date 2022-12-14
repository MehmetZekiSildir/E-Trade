using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Entities
{
    internal class Address
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Distinct { get; set; }
        public string Street { get; set; }

        //1-N
        //Bir adres sadece bir kullanıcıya ait ise o kullanıcını ID eklenir.
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
