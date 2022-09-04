using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Entities
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        //Bir kullanıcının 1den fazla adresi olacak ise adres listesi oluşturulur.
        public List<Address> Addresses { get; set; }

        public User()
        {
            Addresses = new List<Address>();
        }
    }
}
