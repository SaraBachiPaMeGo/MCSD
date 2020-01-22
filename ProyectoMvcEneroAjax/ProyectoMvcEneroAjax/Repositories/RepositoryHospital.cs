using ProyectoMvcEneroAjax.Data;
using ProyectoMvcEneroAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMvcEneroAjax.Repositories
{
    public class RepositoryHospital
    {
        ContextoHospital context;
        public RepositoryHospital() 
        {
            this.context = new ContextoHospital();
        }

        public List<Plantilla> GetPlantillas(int hospiCod)
        {
            var consulta = from datos in context.Plantillas
                           where datos.IdHospital == hospiCod
                           select datos;
            return consulta.ToList();
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public List<Plantilla> GetPlantillasAll()
        {
            var consulta = from datos in context.Plantillas
                           select datos;
            return consulta.ToList();
        }

        public Plantilla DetallesPlantilla(int idPlantilla)
        {
            var consulta = from datos in context.Plantillas
                           where datos.IdPlantilla == idPlantilla
                           select datos;
            return consulta.FirstOrDefault();

        }

        public void Delete(int idPlantilla)
        {
            Plantilla plan = DetallesPlantilla(idPlantilla);

            this.context.Plantillas.Remove(plan);
            this.context.SaveChanges();
        }

        public void DeleteHospi(int hospiCod)
        {
            Hospital hospi = this.context.Hospitales.SingleOrDefault(z => z.HospiCod == hospiCod);

            if (hospi != null) {
                this.context.Hospitales.Remove(hospi);
                this.context.SaveChanges();
            }           
        }

        public Hospital BuscarHospi(int hospicod)
        {
            return this.context.Hospitales.SingleOrDefault(z=>z.HospiCod == hospicod);
        }
    }
}