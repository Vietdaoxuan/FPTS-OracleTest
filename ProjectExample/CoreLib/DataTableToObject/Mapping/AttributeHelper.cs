using CoreLib.DataTableToObject.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreLib.DataTableToObject.Mapping
{
    public static class AttributeHelper
    {
        /// <summary>
        /// Lấy tên cột để mapping của thuộc tính.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="propertyName"></param>
        /// <returns>datanames.</returns>
        public static List<string> GetDataNames(Type type, string propertyName)
        {
            // lấy attribute
            var property = type
                .GetProperty(propertyName)
                ?.GetCustomAttributes(false)
                .FirstOrDefault(x => x.GetType().Name == nameof(DataNamesAttribute));

            return property != null ? ((DataNamesAttribute)property).ValueNames : new List<string>();
        }
    }
}
