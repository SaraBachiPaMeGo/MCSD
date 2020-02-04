using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccesoDatosCore.Data;
using AccesoDatosCore.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AccesoDatosCore
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Para poder recuperar la cadena de conexion de AppSetting 
            //debemos inyectar dentro de de startup
            //IConfiguration, que nos lo ofrece en el servidor
            String cadena = this.Configuration.GetConnectionString("cadenaAzure");
            //String cadenaX = this.Configuration.GetConnectionString("cadenaMySql");
            
            //Resolvemos la dependencia del repositorio
            //services.AddTransient<RepositoryDept>();
            services.AddTransient<IRepository, RepositoryDept>();

            //Resolvemos la dependencia del context que se realiza
            //con el método específico AddDbContext
            //services.AddDbContext<HospitalContext>
            //    (options => options.UseSqlServer(cadena));

            services.AddDbContext<IHospitalContext, HospitalContext>
                (options => options.UseSqlServer(cadena));

            //El método para utilizar cadenas en options cambia respecto a cada
            //Proveedor
            //Mysql --> .UseMySql()
            //services.AddDbContext<IHospitalContext, HospitalContextMySql>
            //    (options => options.UseMySql(cadenaX));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
