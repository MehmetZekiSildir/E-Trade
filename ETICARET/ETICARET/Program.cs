using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETICARET
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPanel());
        }
    }
}

/*
 
 **** Object Relation Mapping(ORM) ****
1-Proje büyüklüğüne göre ORM yapısını tanımlamak için ORM isimli bir klasör açılır. ORM klasörü altına database bağlantısını tanımlamak için Context isimli klasör, proje kullanılacak her yapıyı tanımlamak için ise ENtities klasörü açılır.
2-Entities altına kullanılacak entity ler tanımlanır.
3-Context altına veritabanı bağlantısını tanımlamak için bir class açılır.
4-NuGet Package Manager for Solution dan Entity Framework install yapılır. 
5-ProjectContext classına DbContext class miras alınır.
6-Tabloya dönüşmesini istediğimiz bütün classlar DbSet edilir.
7-Proje içerisinde veritabanı manipüle edildiğinde bütün DbSet<> yapısı database aktarılır.

 */
