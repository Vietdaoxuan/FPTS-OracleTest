using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Services.Interfaces
{
    public interface ISellerService
    {
        Task<IEnumerable<Seller>> Get(Seller searchOptions);

        //Task<Seller> Get(int invoiceID);

        //Task<ResponseMessage> Add(Seller group);

        //Task<ResponseMessage> Update(Seller group);

        //Task<ResponseMessage> Delete(int invoiceID);
    }
}
