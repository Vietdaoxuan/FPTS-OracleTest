using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces
{
    public interface IDataContext<in T>
    {
        DataSet Get();

        ResponseMessage Add(T item);

        ResponseMessage Update(T item);
    }
}
