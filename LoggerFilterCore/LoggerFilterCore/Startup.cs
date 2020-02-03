using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerFilterCore.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace LoggerFilterCore
{
    public class Startup
    {
        public ILoggerFactory LoggerFactory;
        public Startup(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;
            this.LoggerFactory = loggerFactory;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            //Qué proveedor necesitamos para estos mensajes
            //Indicamos el tipo de logger que vamos a utilizar
            //en nuestra app
            LoggerFactory.AddProvider
                (new ConsoleLoggerProvider((category, loglevel) =>
                //Que tipo de nivel de log queremos
                //Enumeración >= 
                loglevel >= LogLevel.Information, false
                ));

            //Creamo un logger para mostrar mensajes
            ILogger logger = LoggerFactory.CreateLogger<ConsoleLogger>();

            //Escribimos
            logger.LogInformation("Logger en Servicio");

            services.AddScoped<MensajesFilter>(); //Para ponerlo en cualquier ámbito de la 
            //app, cuando lo necesite en los atributos

            //Transient y singleton --> PARA CLASES CON NEW 

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        
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
