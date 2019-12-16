using ProyectoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

#region PROCEDURE

//ALTER PROCEDURE PAGINARHOSPITALES
//(@POSICION INT, @REGISTROS INT OUT)
//AS
//    SELECT @REGISTROS = COUNT(HOSPITAL_COD) FROM HOSPITAL

//    SELECT* FROM
//    (
//    SELECT ROW_NUMBER() OVER (ORDER BY NOMBRE)

//    AS POSICION, NOMBRE, DIRECCION, TELEFONO, NUM_CAMA, HOSPITAL_COD

//    FROM HOSPITAL
//	) HOSPITALES
//    WHERE POSICION = @POSICION
//GO


#endregion

namespace ProyectoEntityFramework.Repositories
{
    public class RepositoryHospital
    {
        ContextoHospital context;
        public RepositoryHospital() {
            context = new ContextoHospital();
        }

        public ModeloHospital PaginarHospitales (int posicion){

            ObjectParameter param = new ObjectParameter("REGISTROS", typeof(int));
            var resultado = context.PAGINARHOSPITALES(posicion, param);

            PAGINARHOSPITALES_Result hospital = resultado.FirstOrDefault();

            ModeloHospital datos = new ModeloHospital();
            datos.NumeroRegistros = int.Parse((param.Value).ToString());
            datos.Hospital = hospital;
            datos.ListaDoctores = GetDoctores(datos.Hospital.HOSPITAL_COD);

            return datos;
        }

        public List<DOCTOR> GetDoctores(int hospi_cod)
        {
            var consulta = from datos in context.DOCTOR
                           where datos.HOSPITAL_COD == hospi_cod
                           select datos;

            return consulta.ToList();
        }
    }
}