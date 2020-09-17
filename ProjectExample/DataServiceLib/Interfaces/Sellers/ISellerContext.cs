﻿using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataServiceLib.Interfaces.Sellers
{
    public interface ISellerContext : IDataContext<Seller>
    {
        DataSet Get(Seller searchOptions);

        DataSet Get(string SellerId);

        ResponseMessage Delete(string SellerId);
    }
}
