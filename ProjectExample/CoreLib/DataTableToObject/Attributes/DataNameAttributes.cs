using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreLib.DataTableToObject.Attributes
{
    /// <summary>
    /// Tên cột của thuộc tính tương ứng trong cơ sở dữ liệu , để map Datatable thành list object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DataNamesAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataNamesAttribute"/> class.
        /// </summary>
        public DataNamesAttribute()
        {
            this._valueNames = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataNamesAttribute"/> class.
        /// </summary>
        /// <param name="valueNames">Tên cột tương ứng trong Dataset.</param>
        public DataNamesAttribute(params string[] valueNames)
        {
            this._valueNames = valueNames.ToList();
        }

        protected List<string> _valueNames { get; set; }

        public List<string> ValueNames
        {
            get
            {
                return this._valueNames;
            }

            set
            {
                this._valueNames = value;
            }
        }
    }
}
