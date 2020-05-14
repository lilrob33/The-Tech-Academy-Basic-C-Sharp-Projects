using KnockoutJS.Interface;
using KnockoutJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutJS.Repositories
{
    public class ProductRepository : IProductRepository
    {
        KnockoutJSEntities ProductDB = new KnockoutJSEntities();

        public KnockoutJSEntities ProductDB1 { get => ProductDB; set => ProductDB = value; }

        public IEnumerable<ProductList> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return ProductDB.ProductLists;
        }

        public ProductList Get(int id)
        {
            // TO DO : Code to find a record in database
            return ProductDB.ProductLists.Find(id);
        }

        public ProductList Add(ProductList item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            ProductDB.ProductLists.Add(item);
            ProductDB.SaveChanges();
            return item;
        }

        public bool Update(ProductList item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database

            var products = ProductDB.ProductLists.Single(a => a.Id == item.Id);
            products.Name = item.Name;
            products.Category = item.Category;
            products.Price = item.Price;
            ProductDB.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            // TO DO : Code to remove the records from database

            ProductList products = ProductDB.ProductLists.Find(id);
            ProductDB.ProductLists.Remove(products);
            ProductDB.SaveChanges();

            return true;
        }
    }
}