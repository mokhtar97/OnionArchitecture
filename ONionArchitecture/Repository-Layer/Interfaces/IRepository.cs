using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T Find(int? id);

        void ADD(T Model);
        void Update(int id, T Model);
        void Delete(int id);
    }
}
