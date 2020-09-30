using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Models
{
    public class PaginationDataTableModel
    {
        public int draw { get; set; }

        public int start { get; set; }

        public int length { get; set; }
    }
}
