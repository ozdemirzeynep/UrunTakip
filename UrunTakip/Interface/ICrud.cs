﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UrunTakip.Interface
{
    public interface ICrud
    {
        T Insert<T>(T model) where T : class;
        T Update<T>(T model) where T : class;
        void Delete<T>(int id) where T : class;
        T Find<T>(int id) where T : class;
        IQueryable<T> Get<T>() where T : class;
    }
}