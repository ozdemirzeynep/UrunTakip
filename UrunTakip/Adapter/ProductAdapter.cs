using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrunTakip.Interface;

namespace UrunTakip.Adapter
{
    class ProductAdapter : ICrud
    {
        public void Delete<T>(int id) where T : class
        {
            T model = Find<T>(id);

            using (UrunTakipContext urunTakipContext = new UrunTakipContext())
            {
                urunTakipContext.Set<T>().Remove(model);
                urunTakipContext.SaveChanges();
            }
        }

        public T Find<T>(int id) where T : class
        {
            T product;

            using (UrunTakipContext urunTakipContext = new UrunTakipContext())
            {
                product = urunTakipContext.Set<T>().Find(id);
            }

            return product;
        }

        public IQueryable<T> Get<T>() where T : class
        {
            IQueryable<T> models;

            using (UrunTakipContext urunTakipContext = new UrunTakipContext())
            {
                models = urunTakipContext.Set<T>();
            }

            return models;
        }

        public T Insert<T>(T model) where T : class
        {
            using (UrunTakipContext urunTakipContext = new UrunTakipContext())
            {
                urunTakipContext.Set<T>().Add(model);
                urunTakipContext.SaveChanges();
            }

            return model;
        }

        public T Update<T>(T model) where T : class
        {
            using (UrunTakipContext urunTakipContext = new UrunTakipContext())
            {
                urunTakipContext.Set<T>().Update(model);
                urunTakipContext.SaveChanges();
            }

            return model;
        }

        
    }
}
