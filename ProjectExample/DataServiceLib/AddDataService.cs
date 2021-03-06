﻿using System;
using DataServiceLib.Implementations;
using DataServiceLib.Implementations.Employees;
using DataServiceLib.Implementations.Invoices;
using DataServiceLib.Implementations.InvoicesSummaryReport;
using DataServiceLib.Implementations.Seller;
using DataServiceLib.Interfaces;
using DataServiceLib.Interfaces.Employees;
using DataServiceLib.Interfaces.Invoices;
using DataServiceLib.Interfaces.InvoicesSummaryReport;

using DataServiceLib.Interfaces.Sellers;
using Microsoft.Extensions.DependencyInjection;

namespace DataServiceLib
{
    public static class AddDataService
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(ICBaseDataProvider), typeof(CBaseDataProvider));
            services.AddTransient(typeof(IEmployeeContext), typeof(EmployeeContext));
            services.AddTransient(typeof(IInvoiceContext), typeof(InvoiceContext));
            services.AddTransient(typeof(IInvoicesSummaryReportContext), typeof(InvoicesSummaryReportContext));
            //services.AddTransient(typeof(ISellerContext), typeof(SellerContext));
            services.AddTransient(typeof(ISellerContext), typeof(SellerContext));
            return services;
        }
    }
}
