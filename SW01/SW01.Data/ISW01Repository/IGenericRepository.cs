﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW01.Data.ISW01Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetQueryable();
        List<T> GetAll();
        List<T> GetList(Func<T, bool> where);
        T GetSingle(Func<T, bool> where);
        T Insert(T entity);
        //List<T> InsertMany(List<T> entities);
        int Delete(Func<T, bool> where, T entity);
        //int DeleteMany(Func<T, bool> where, List<T> entites);
        List<T> UpdateMany(List<T> entities);
        T Update(Func<T, bool> where, T entity);
        T Update(T entity);
        T InsertOrUpdate(Func<T, bool> where, T entity);
        int UpdateProperty(Func<T, bool> where, KeyValuePair<string, object> set);
        int UpdatePropertyDecimal(Func<T, bool> where, KeyValuePair<string, object> set);
        int UpdatePropertyForList(Func<T, bool> where, KeyValuePair<string, object> set);
        bool IsExist(Func<T, bool> where);

        // For Update Two Properties
        // int UpdateProperties(Func<T, bool> where, KeyValuePair<string, object> set1, KeyValuePair<string, object> set2);
       int UpdateProperties(Func<T, bool> where, KeyValuePair<string, object> set1, KeyValuePair<string, object> set2, KeyValuePair<string, object> set3, KeyValuePair<string, object> set4);
    }
}
