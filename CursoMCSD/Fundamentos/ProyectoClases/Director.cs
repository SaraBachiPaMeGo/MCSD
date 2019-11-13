using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director() {
            this.Nombre = "Director";
            this.SalarioBase +=200;
            //Acumulamos el valor que ya viene
            //(El del constructor de Empleado) y 
            //añadir +200
        }
        //SOBREESCRITUR DE MÉTODOS
        //Sustituímos el código de empleado
        public override int GetDiasVacaciones() {
            
            //Override para los métodos que se vayan 
            //a sobreescribir (En la otra clase se deberá
            //poner VIRTUAL)
            //Sustituye el código base por este
            
            //Si necesitamos llamar al método de la clase 
            //base por alguna razón, debemos hacer la llamada
            //EXPLÍCITA:
            //base.GetDiasVacaciones(); //this.GetDiasVacaciones(); -->Es lo mismo
            //De esta manera haremos un bucle infinito, por lo que deberemos
            //DE UTILIZAR LA PALABRA BASE
            //Será la primera línea de código para utilizarlo 
            //return 30; 
            int  diasempleado = base.GetDiasVacaciones();
            Debug.WriteLine("Vacaciones director");
            return diasempleado + 8;
        }
    }
}
