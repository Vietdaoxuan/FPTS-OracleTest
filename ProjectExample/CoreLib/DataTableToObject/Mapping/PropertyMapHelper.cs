using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace CoreLib.DataTableToObject.Mapping
{
    public static class PropertyMapHelper
    {
        public static void Map(Type type, DataRow row, PropertyInfo prop, object entity)
        {
            var columnNames = AttributeHelper.GetDataNames(type, prop.Name);

            foreach (var columnName in columnNames)
            {
                if (string.IsNullOrWhiteSpace(columnName) || !row.Table.Columns.Contains(columnName))
                {
                    continue;
                }

                var propertyValue = row[columnName];
                if (propertyValue == DBNull.Value)
                {
                    continue;
                }

                ParsePrimitive(prop, entity, row[columnName]);
                break;
            }
        }

        public static bool ParseBoolean(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return false;
            }

            switch (value.ToString().ToLowerInvariant())
            {
                case "1":
                case "y":
                case "yes":
                case "true":
                    return true;

                case "0":
                case "n":
                case "no":
                case "false":
                default:
                    return false;
            }
        }

        private static void ParsePrimitive(PropertyInfo prop, object entity, object value)
        {
            if (prop.PropertyType == typeof(string))
            {
                prop.SetValue(entity, value.ToString().Trim(), null);
            }
            else if (prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(bool?))
            {
                if (value == null)
                {
                    prop.SetValue(entity, null, null);
                }
                else
                {
                    prop.SetValue(entity, ParseBoolean(value.ToString()), null);
                }
            }
            else if (prop.PropertyType == typeof(long))
            {
                prop.SetValue(entity, long.Parse(value.ToString()), null);
            }
            else if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(int?))
            {
                if (value == null)
                {
                    prop.SetValue(entity, null, null);
                }
                else
                {
                    prop.SetValue(entity, int.Parse(value.ToString()), null);
                }
            }
            else if (prop.PropertyType == typeof(decimal))
            {
                prop.SetValue(entity, decimal.Parse(value.ToString()), null);
            }
            else if (prop.PropertyType == typeof(double) || prop.PropertyType == typeof(double?))
            {
                var isValid = double.TryParse(value.ToString(), out var number);
                if (isValid)
                {
                    prop.SetValue(entity, double.Parse(value.ToString()), null);
                }
            }
            else if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
            {
                var isValid = DateTime.TryParse(value.ToString(), out var date);
                if (isValid)
                {
                    prop.SetValue(entity, date, null);
                    return;
                }

                isValid = DateTime.TryParseExact(value.ToString(), "MMddyyyy", new CultureInfo("en-US"), DateTimeStyles.AssumeLocal, out date);
                if (isValid)
                {
                    prop.SetValue(entity, date, null);
                    return;
                }

                isValid = DateTime.TryParseExact(value.ToString(), "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
                if (!isValid)
                {
                    return;
                }

                prop.SetValue(entity, date, null);
            }
            else if (prop.PropertyType == typeof(Guid))
            {
                var isValid = Guid.TryParse(value.ToString(), out var guid);
                if (isValid)
                {
                    prop.SetValue(entity, guid, null);
                }
                else
                {
                    isValid = Guid.TryParseExact(value.ToString(), "B", out guid);
                    if (isValid)
                    {
                        prop.SetValue(entity, guid, null);
                    }
                }
            }
            else if (prop.PropertyType == typeof(byte[]))
            {
                try
                {
                    var data = Encoding.ASCII.GetBytes(value.ToString());
                    prop.SetValue(entity, data, null);
                }
                catch
                {
                    // ignored
                }
            }
        }
    }
}
