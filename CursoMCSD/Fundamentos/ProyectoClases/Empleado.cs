using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {

        //public Empleado()// : base(77) //Le estamos indicando que 
        //    //queremos que lea el constructor con parámetros
        //    //En este caso queremos que coja el constructor de
        //    //la clase persona cuyo parámetro es un int.
        //    //Por lo que base hará referencia a la clase anterior
        //    //para especificar el constructor que queremos utilizar
        //    //Cuando hacemos new empleado sin parámetros. 
        //    //SIEMPRE QUE EL CONSTRUCTOR DE LA CLASE SUPERIOR TENGA
        //    //PARÁMETROS SE DEBERÁ PONER BASE CON LOS PARÁMETROS DENTRO 
        //{
        //    this.Nacionalidad = Paises.España;
        //}
        //public Empleado(int numero) {
        //    this.Nacionalidad = Paises.Argentina;
        //}
        protected int SalarioBase { get; set; }
        //Solamente acceden a el los objetos que sean
        //empleado, que tengan la herencia de este obj
        //De esta manera no dejaremos que el salario base
        //Sea modificado en el formulario
        //Para ver el salario haríamos un método que devolviera
        //el salario
        public Empleado() {
            this.Nombre = "Empleado";
            this.SalarioBase = 1400;
        }
        public int GetSalarioBase() {
            return this.SalarioBase;
        }
        public virtual int GetDiasVacaciones() {
            //Con la palabra virtual decimos que este
            //Método puede ser sobreescrito
            Debug.WriteLine("Vacaciones empleado");
            return 22;
        }
        public override string ToString()
        {
            return this.GetNombreCompleto() + " " + this.GetSalarioBase(); //this.SalarioBase
        }
    }
}
