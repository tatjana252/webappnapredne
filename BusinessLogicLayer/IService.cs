using System;
using System.Collections;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Insert(T t);
    }
}
