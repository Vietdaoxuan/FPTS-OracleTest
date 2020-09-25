using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces.Sellers
{
    public interface ISellerContext : IDataContext<Seller>
    {
        DataSet Get(int sellerID, string sellerName);

        DataSet Get(string sellerID);

        ResponseMessage Delete(string sellerID);
    }
}
