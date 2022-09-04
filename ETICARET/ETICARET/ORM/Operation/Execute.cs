using ETICARET.ORM.Context;
using ETICARET.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.ORM.Operation
{
    internal class Execute
    {
        public static int CategoryInsert(Category entity)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.Categories.Add(entity);
                return db.SaveChanges();
            }

        }

        public static List<Category> CategoryList()
        {
            ProjectContext db = new ProjectContext();
            return db.Categories.ToList();
        }

        public static int ProductInsert(Product entity)
        {
            using (ProjectContext db = new ProjectContext())
            {
                db.Products.Add(entity);
                return db.SaveChanges();
            }

        }

        public static List<City> CityList()
        {
            using (ProjectContext db = new ProjectContext())
            {
                return db.Cities.ToList();
            }
        }

        public static List<District> DistrictList(int id)
        {
            ProjectContext db = new ProjectContext();
            return db.Districts.Where(i => i.CityID == id).ToList();
        }


        public static int UserInsert(User entity)
        {
            using (ProjectContext db = new ProjectContext())
            {

                User user = db.Users.Where(u => u.Username == entity.Username || u.Email == entity.Email).FirstOrDefault();

                if (user != null) 
                {
                    if (db.Users.Where(u => u.Username == entity.Username).FirstOrDefault() != null)
                        return -1;
                    else if(db.Users.Where(u => u.Email == entity.Email).FirstOrDefault() != null)
                    {
                        return -2;
                    }
                }
               

                db.Users.Add(entity);
                return db.SaveChanges();
            }
        }

        public static User UserLogin(string email, string password)
        {
            using (ProjectContext db = new ProjectContext())
            {
                User user = db.Users.Where(u => u.Email == email && u.Password==password).FirstOrDefault();

               if(user == null) 
                {
                    return null;
                }
                return user;
            }
        }

        public static List<Product> ProductByCategoryId(int id)
        {
            using (ProjectContext db = new ProjectContext())
            {

                List<Product> products = db.Products.Where(p => p.CategoryID == id).ToList();

               return products;
            }
        }

        public static Product ProductById(int id)
        {
            using (ProjectContext db = new ProjectContext())
            {

                Product product = db.Products.Where(p => p.ID== id).FirstOrDefault();
                //Product product = db.Products.Find(id);
                //string name = db.Products.Where(p => p.ID== id).Select(i=> i.ProductName).ToString();

                return product;
            }
        }

        public static User UserById(int id)
        {
            using(var db = new ProjectContext())
            {
               User findUser= db.Users.Find(id);

                if (findUser == null)
                {
                    return null;
                }

                return findUser;
            }
        }

        public static Address UserAddressById(int id)
        {
            using (var db = new ProjectContext())
            {
                Address findAddress = db.Addresses.Where(u => u.UserID == id).FirstOrDefault(); ;

                if (findAddress == null)
                {
                    return null;
                }

                return findAddress;
            }
        }
    }
}
