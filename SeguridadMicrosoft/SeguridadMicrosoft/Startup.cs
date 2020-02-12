using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeguridadMicrosoft.Data;

namespace SeguridadMicrosoft
{
    public class Startup
    {

        public IConfiguration Configuration;
        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Necesitamos la cadena de conexión
            String cadena = this.Configuration["AspnetDb:ConnectionString"];
                //.GetConnectionString("cadenaASPNET");

            //Declaramos nuestro contexto
            services.AddDbContext<AplicattionDbContext>(
                options => options.UseSqlServer(cadena)
                );

            //Asociar la identidad de usuario de nuestra app
            //con el context
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<AplicattionDbContext>();

            //Indicamos que la seguridad que utilizaremos será la de 
            //Microfost con nuestras claves
            String clienteId = this.Configuration["Authentication:Microsoft:ApplicationId"];
            String clienteSecret = this.Configuration["Authentication:Microsoft:Password"];

            services.AddAuthentication()
                .AddMicrosoftAccount(
                options => {
                    options.ClientId = clienteId;
                    options.ClientSecret = clienteSecret;
                });
            services.AddMvc();
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //Indicar que vamos a utilizar Authentication
            app.UseAuthentication();

            app.UseMvc( routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}"
                        );
                }
                
                );
        }
    }
}
