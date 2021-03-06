using CommonLib.Implementations;
using CommonLib.Interfaces;
using CoreLib.SharedKernel;
using DataServiceLib.Implementations;
using DataServiceLib.Implementations.Sellers;
using DataServiceLib.Interfaces;
using DataServiceLib.Interfaces.Sellers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectFont.AppCodes.CallAPI;
using ProjectFont.Services.Implementations;
using ProjectFont.Services.Interfaces;

namespace ProjectFont
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
            ConfigProvider.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddTransient<IHttpService, HttpService>();
            services.AddTransient<ICommon, Common>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<ISellerService, SellerService>();
            //services.AddSingleton<ISellerContext, SellerContext>();
            services.AddScoped<ISellerContext, SellerContext>();
            services.AddScoped<ICBaseDataProvider, CBaseDataProvider>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=InvoiceSummaryReport}/{action=InvoiceSummaryReport}/{id?}"
                    );
            });
        }
    }
}
