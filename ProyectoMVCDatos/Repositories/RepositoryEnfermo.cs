using ProyectoMVCDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVCDatos.Repositories
{
    public class RepositoryEnfermo
    {
        ContextoHospitalDataContext context;
        public RepositoryEnfermo() {
            context = new ContextoHospitalDataContext();
        }

        public List<ENFERMO> GetEnfermos() {
            var consulta = from datos in context.ENFERMOs
                           select datos;            
            return consulta.ToList();
        }

        public ENFERMO BuscarEnfermo(int insc) {
            var consulta = from datos in context.ENFERMOs
                           where datos.INSCRIPCION == insc
                           select datos;
            //context.ENFERMOs.Single(x => x.INSCRIPCION == insc); lambda
            
            return consulta.FirstOrDefault();
        }

        public void Modificar(int insc, String apellido, String direccion, DateTime fecha_nac, String s, int nss) {
            ENFERMO enf = this.BuscarEnfermo(insc);
            
            enf.APELLIDO = apellido;
            enf.DIRECCION = direccion;
            enf.FECHA_NAC = fecha_nac;
            enf.S = s;
            enf.NSS = nss;
            context.SubmitChanges();
        }

        public void Eliminar(int insc)
        {
            ENFERMO enf = this.BuscarEnfermo(insc);
            context.ENFERMOs.DeleteOnSubmit(enf);
            context.SubmitChanges();
        }

        public void Crear(int insc, String apellido, String direccion, DateTime fecha_nac, String s, int nss)
        {
            ENFERMO enf = new ENFERMO();
            enf.INSCRIPCION = insc;
            enf.APELLIDO = apellido;
            enf.DIRECCION = direccion;
            enf.FECHA_NAC = fecha_nac;
            enf.S = s;
            enf.NSS = nss;
            context.ENFERMOs.InsertOnSubmit(enf);
            context.SubmitChanges();
        }
    }
}