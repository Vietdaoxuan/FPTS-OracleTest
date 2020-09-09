using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CoreLib.DataTableToObject.Mapping
{
    public static class DataMapperExtentions
    {
        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public static IEnumerable<T> ToListItem<T>(this DataSet dataSet) where T : class, new()
        {
            if (dataSet.Tables.Count > 1)
            {
                throw new Exception("Dataset must contain only 1 table to convert to collection");
            }

            if (dataSet.Tables.Count == 0)
            {
                return new List<T>();
            }

            var mapper = new DataNamesMapper<T>();
            return mapper.Map(dataSet.Tables[0]);
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static IEnumerable<T> ToListItem<T>(this DataTable dataTable) where T : class, new()
        {
            if (dataTable == null)
            {
                throw new NullReferenceException("Datatable cannot be null when convert to list item");
            }

            var mapper = new DataNamesMapper<T>();
            return mapper.Map(dataTable);
        }
    }
}
