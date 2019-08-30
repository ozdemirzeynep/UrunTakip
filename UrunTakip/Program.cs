using System;
using System.Linq;
using UrunTakip.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace UrunTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveProduct("telefon3", "açıklaması");
            RemoveProduct(3);
            //List("deneme");
            Console.ReadLine();
            
        }


        private static readonly Adapter.ProductAdapter productAdapter = new Adapter.ProductAdapter();
        public static void SaveProduct(string UrunAdi, string Aciklamasi)
        {
            Models.Product product = new Models.Product()
            {
                Name = UrunAdi,
                Description = Aciklamasi,
                CreateDate = DateTime.UtcNow
            };
            product = productAdapter.Insert<Models.Product>(product);

        }

        public static void RemoveProduct(int id)
        {
            
            productAdapter.Delete<Models.Product>(id);
            
        }

        //public static List<Models.Product> List(string UrunAdi)
        //{
        //    List<Models.Product> result = new List<Models.Product>();
            
        //    IQueryable<Product> products = productAdapter.Get<Models.Product>();
        //    result = products.ToList();

        //    return result;

        //}

        




    }
}
