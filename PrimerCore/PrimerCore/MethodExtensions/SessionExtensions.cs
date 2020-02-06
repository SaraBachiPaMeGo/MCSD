using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.MethodExtensions
{
    public static class SessionExtensions
    {
        //Los métodos de extensión deben ser de
        //tipo estatic
        public static void SetObjeto(this ISession session,
            String key, object value)
        {
            //Convertimos el objeto Value a txtjson
            String json =
                JsonConvert.SerializeObject(value);

            //Almacenamos como String en la sesión 
            //el formato JSON
            session.SetString(key, json);
        }

        //Como no sabemos lo que vamos a devolver
        //al programador debemos usar genéricos
        //<T> --> Se utiliza en los métodos para 
        //recibir o devolver
        //Persona p ? sesion.GetObject<Persona>("PERSONA")
        public static T GetObjecto<T>(this ISession session,
            String key)
        {
            //Recuperamos el StringJson de la session
            String json = session.GetString(key);

            //Es posible que no exista la Key
            //si es así devolveremos null
            if (json == null)
            {
                //Devolvemos la clase por defecto
                //enviando T
                //En caso de int un 0 y persona null
                return default(T);
            }
            else {
                //Devolvemos el objeto serializado a su 
                //forma T
                
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
