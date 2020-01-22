using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace ProyectoMvcEneroAjax.Controllers
{
    public class CorreosController : Controller
    {
        public CorreosController()
        { }
        // GET: Correos
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String para, String asunto, String mensaje, HttpPostedFileBase archivo)
        {
            MailMessage mail = new MailMessage();

            //La cuenta from y las credenciales deben der la misma
            String cuenta = ConfigurationManager.AppSettings["usuario"];

            String msj = "";
            try {

                mail.From = new MailAddress(cuenta);

                //A quien enviamos el correo
                mail.To.Add(para);

                mail.Subject = asunto;
                mail.Body = mensaje;

                //Si queremos que admita formato HTML
                mail.IsBodyHtml = true;

                //Establecer la prrioridad
                mail.Priority = MailPriority.Normal;

                //Recuperamos la ruta absoluta/física del servidor
                //a la carpeta temporal
                String ruta = Server.MapPath("/Temporal");

                ViewBag.Ruta = ruta;

                //Añadir a la ruta el nombre del archivo
                //Sirve para subir un fichero al servidor
                // a la carpeta temporal
                ruta += @"\" + archivo.FileName;
                archivo.SaveAs(ruta);

                //Adjuntar un fichero al correo indicándole la ruta
                Attachment att = new Attachment(ruta);

                //Añadimos al mail los att
                mail.Attachments.Add(att);

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;

                //Recuperamos el password -->AppSettings
                String pass = ConfigurationManager.AppSettings["password"];

                //Creamos las credenciales
                NetworkCredential credenciales = new NetworkCredential(cuenta,pass);

                //Establecemos las credenciales
                smtp.Credentials = credenciales;

                //Enviamos el correo
                smtp.Send(mail);

                msj = "Mensaje enviado";

            } catch (Exception ex)
            {
                msj = ex.ToString();
            }

            ViewBag.Mensaje = msj;
            
            return View();
        }
    }
}