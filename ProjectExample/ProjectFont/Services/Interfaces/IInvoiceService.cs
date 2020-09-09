using CoreLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFont.Services.Interfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> Get(Invoice searchOptions);

        Task<Invoice> Get(int invoiceID);

        Task<ResponseMessage> Add(Invoice group);

        Task<ResponseMessage> Update(Invoice group);

        Task<ResponseMessage> Delete(int invoiceID);
    }
}
