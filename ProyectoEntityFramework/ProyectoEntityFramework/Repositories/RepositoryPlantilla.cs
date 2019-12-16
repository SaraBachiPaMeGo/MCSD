using ProyectoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace ProyectoEntityFramework.Repositories
{
    public class RepositoryPlantilla
    {
        ContextoHospital context;

        public RepositoryPlantilla() {
            context = new ContextoHospital();
        }

        public GrupoPlantilla GetGrupoPlantilla(int posicion) 
        {
            ObjectParameter param = new ObjectParameter("REGISTROS", typeof(int));

            var resultado = context.PAGINARGRUPO(posicion, param);

            GrupoPlantilla grupo = new GrupoPlantilla();
            grupo.Plantilla = resultado.ToList();
            int registros = int.Parse(param.Value.ToString()); //El número de registros del count del procedure
            grupo.NumeroRegistros = registros;

            return grupo; 
        }
    }
}