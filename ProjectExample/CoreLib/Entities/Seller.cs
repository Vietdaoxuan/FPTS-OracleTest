using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLib.Entities
{
    public class Seller
    {
        public int SellerID { get; set; }

        public string SellerName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Owners { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public string BankName { get; set; }

        public string Tax { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string Fax { get; set; }
    }
}
