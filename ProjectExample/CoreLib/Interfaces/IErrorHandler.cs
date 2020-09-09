using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Interfaces
{
    public interface IErrorHandler
    {
        /// <summary>
        /// Lưu log vào file.
        /// </summary>
        /// <param name="ex">exception.</param>
        void WriteToFile(Exception ex);

        /// <summary>
        /// Log đoạn lỗi
        /// </summary>
        /// <param name="Messegae"></param>
        void WriteStringToFile(string SPname, string paramArr);
    }
}
