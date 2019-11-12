using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
    public enum Sexo
    {
        MASCULINO, FEMENINO
    }

    public enum Paises
    {
        Francia = 0, España = 1, Argentina = 2, Alemania = 82
    }
    #endregion
    public class Persona
    {
       // public Persona(string nombre) { 
        //Obligación de crear una persona
        //sí o sí con nombre
        // }

        #region METODOS PERSONA
        public String GetNombreCompleto() {
            return this.Nombre + " " + this._Apellido; //Estando en la clase
            //Da igual utilizar el nombre que el campo
        }

        public String GetNombreCompletoReves() {
            return this.Apellido + " " + this.Nombre;
        }

        #endregion

        #region CAMPOS DE PROPIEDAD

        //Una propiedad siempre tendrá
        //un campo privado para manejar la propiedad
        //El campo será del mismo tipo que la propiedad
        //por sintaxis, los campos asociados a propiedades 
        //se suelen escribir con guión bajo "_Edad"
        //Ejemplo de cambiar la edad

        private String _Nombre;
        private int _Edad;
        private String _Apellido;
        private Sexo _Genero;
        private Paises _Nacionalidad;

        #endregion

        #region PROPIEDADES

        public Direccion DireccionCasa { get; set; }
        public Direccion DireccionVacaciones { get; set; }
        public String Nombre { //Es una propiedad
            get {
                //Devolvemos el campo privado
                return _Nombre;//this._Nombre
            }
            set {
                //Establecemos el campo privado con
                //VALUE (es el valor que está estableciendo
                //el nombre/valor que asignemos a la propiedad)
                _Nombre = value;
            }
        }
        public int Edad {
            get { return _Edad; }
            set {
                
                if (value < 0)
                {
                    //Error silencioso
                    _Edad = 0;
                    //Lanzamos una exception
                    //throw new Exception("No se admiten valores negativos: " + value);
                }
                else { 
                    this._Edad = value;
                }
                
            }
        }
        public String Apellido {
            get { return this._Apellido; }
            set {
                this._Apellido = value;
            }
        }
        public Sexo Genero
        {
            get { return _Genero; }
            set
            {
                //Deberíamos de comprobar los posibles
                //valores de la enumeración
                if (value != Sexo.MASCULINO && value != Sexo.FEMENINO)
                {
                    throw new Exception("Valor no válido, sólo hay dos posibilidades");
                }
                this._Genero = value;
            }
        }
        public Paises Nacionalidad
        {
            get { return _Nacionalidad; }
            set
            {
                //if (value <= 0 || value >= 3 || value != 82)
                //{
                //    throw new Exception("Valor no válido");
                //}
                this._Nacionalidad = value;
            }
        }
        #endregion


    }
}