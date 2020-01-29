using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PrimerCore.Models;

namespace PrimerCore
{
    //Qué voy a utilizar en mi App : Si quiero autentificación, cookies...
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Esto es nuestro container
            //IoC --> Inversión de control
            //Transient crea un objeto por REQUEST
            //services.AddTransient<Coche>();

            //Podemos crear un solo objeto en las peticiones
            //y que se comparta
            //services.AddSingleton<Coche>();

            //services.AddSingleton<ICoche, Deportivo>();

            //Realizar la IoC con el obejto 
            //inicializado con las propiedades que deseemos
            services.AddSingleton<ICoche>(car => new Deportivo
            {
                Marca = "Ferrari",
                Modelo = "Testarrosa",
                Velocidad=0,
                VelocidadMax = 150,
                Imagen = "Coche3.jpg"

            }) ;
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "Default",
                  template: //Qué vamos a mapear
                      "{controller=Home}/{action=Index}/{id?}"); //? parametro opcional
            });

        }
    }
}
