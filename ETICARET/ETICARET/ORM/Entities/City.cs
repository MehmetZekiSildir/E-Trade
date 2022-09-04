using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Entities
{
   
    internal class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<District> Districts { get; set; }
    }
        
}
