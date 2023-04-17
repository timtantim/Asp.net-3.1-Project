using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NttProject1.DbContexts;
using NttProject1.RepositoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NttProject1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*註冊資料庫服務*/
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection"),
            ef => ef.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            /*註冊控制器服務*/
            services.AddControllers().AddNewtonsoftJson();

            /*註冊Repository服務*/
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            /*導入第三方驗證 OAuth*/
            services.AddAuthentication("Bearer")
            .AddIdentityServerAuthentication("Bearer", options =>
            {
                options.ApiName = "myApi";
                options.Authority = "https://localhost:26691";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
