﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PRIMERO LA LIBRERIA, DESPUÉS USING (Acceso directo a una libreria
//Deberemos crear primero la librería y después utilizarla)
//Proyecto clases-> build
//Fundamentos-> Add --> Reference --> Proyects
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form28Clases : Form
    {
        public Form28Clases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Crear un objeto e iniciar sus propiedades
            //Aunque no tenfa un constructor definido
            //con parámetros
            Persona person2 = new Persona {Nombre="Carlos"
            , Edad =29};

            Button btn = new Button { Text = "Botón", Location = new Point(50, 6)};

            Persona pers = new Persona();
            pers.Nombre = "Lucia";
            pers.Edad = 5;
            pers.Apellido = "Garcia";
            pers.Genero = Sexo.FEMENINO;
            pers.Nacionalidad = Paises.España;

            Direccion dirCasa = new Direccion();
            dirCasa.Calle = "Salvador Dalí";
            dirCasa.Numero = 2;
            dirCasa.Ciudad = "Madrid";
            //Es el mismo código 
            //Size size = new Size(200,200);
            //this.btn.Size = size;

            pers.DireccionCasa =dirCasa;
            //pers.DireccionCasa.Numero = 55;// Hemos hecho un objeto dentro de 
            //direccionCasa
            //pers.DireccionVacaciones.Numero = 55; // No hemos creado el objeto
            //es un null POR LO QUE NO FUNCIONA
            //this.btn.Size.Height =200;

            //Hecho con el constructor 2º 
            pers.DireccionVacaciones = new Direccion("Pez","Cádiz");

            this.listBox1.Items.Add(pers.GetNombreCompleto());
            this.listBox1.Items.Add(pers.Nombre);
            this.listBox1.Items.Add(pers.Edad);
            this.listBox1.Items.Add(pers.Genero);
            this.listBox1.Items.Add(pers.Nacionalidad);
            this.listBox1.Items.Add(pers.DireccionCasa.Calle + " - " + pers.DireccionCasa.Ciudad);
        }
    }
}
