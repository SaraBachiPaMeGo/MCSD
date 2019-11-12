using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        //Un constructor es un método de objeto 
        //Utiliza el mismo nombre que la clase
        //Es el punto de entrada de cualquier 
        //clase Se ejecuta cuando escribimos NEW
        //SI NO HAY CONSTRUCTOR SE UTILIZA EL DE
        //LA CLASE base (la clase la cuál estoy he-
        //redando)
        public Direccion() {
            this.Numero = 77; //Siempre va a ser 77
            // si el usuario no pone nada 
        }

        //Se puede hacer sobrecarga de constructor
        //podemos tener todas las firmas que queramos
        //"Direccion(String calle, String ciudad)" ,
        //"Direccion()"
        public Direccion(String calle, String ciudad) {
            this.Calle = calle;
            this.Ciudad = ciudad;
        }

        //EN ESTE CASO ESTAMOS HEREDANDO DE OBJECT
        
        //Propiedades autoimplementadas
        //Son propiedades que tienen "OCULTA"
        // el campo privado
        //Se utilizan cuando queremos declarar
        //una propiedad sin controlar excepciones
        public String Calle {get; set;}//Propiedad autoimplementada
        //Lo hae el programa por detrás
        public int Numero {get; set;}
        public String Ciudad {get;set;}
    }
}
