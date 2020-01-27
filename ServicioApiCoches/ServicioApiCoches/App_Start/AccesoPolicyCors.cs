using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace ServicioApiCoches.App_Start
{
    public class AccesoPolicyCors : Attribute, ICorsPolicyProvider
    {
        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //Capturar la petición
            CorsRequestContext peticion = request.GetCorsRequestContext();

            String urlOrigen = peticion.Origin;

            //Nos creamos la politica de acceso cors
            CorsPolicy policy = new CorsPolicy();
            policy.AllowAnyHeader = true; //Put post y delete

            //Permitimos culquier método
            policy.AllowAnyMethod = true;

            //Aquí incluiríamos cualquier cliente de acceso 
            // o sólo alguno de ellos
            // policy.origin es una coleccion donde incluiremos los
            //clientes que deseemos que tengan acceso 
            //Si deseamos todos escribimos la url de la petición
            policy.Origins.Add(urlOrigen);

            //Si quisiéramos sólamente algunos clientes:
            //policy.Origind.Add("http:cliente1") --> Se hace por URL

            return policy;
        }
    }
}