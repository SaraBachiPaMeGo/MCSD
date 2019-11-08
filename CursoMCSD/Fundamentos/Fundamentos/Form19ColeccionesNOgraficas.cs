using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form19ColeccionesNOgraficas : Form
    {
        public Form19ColeccionesNOgraficas()
        {
            InitializeComponent();
            //ArrayList lista = new ArrayList();
            //lista.Add(this.button1);
            //lista.Add(this.button2);
            //lista.Add(this.textBox1);

            //((Button)lista[0]).BackColor = Color.Violet;
            ////Los bucles fore nos permiten realizar casting
            ////automático (ir al tipo definido en el bucle)

            //foreach (Control btn in lista) {
            //    btn.BackColor = Color.LightPink;
            //}

            List<Control> btns = new List<Control>();
            btns.Add(this.button1);
            btns.Add(this.button2);
            btns.Add(this.button3);
            //El compilador detecta errores de tipo type-safe
            btns.Add(this.textBox1);
            //Los objetos ya vienen tipados
            //btns[0] --> te devuelve un button
            btns[0].BackColor = Color.Fuchsia;

            //this.button1.c
            // foreach (Button c in btns) {
               foreach (Control c in btns) {//--> También sirve, te pinta todos los botones
                    if (c is TextBox) {
                        c.BackColor = Color.LightBlue;
                    //Si necesitamos alguna característica propia de la clase 
                    // TextBox necesitamos un casting
                    //La clase textBox tiene un método Paste()
                    //Pega en su interior lo que tengamos en el portapapeles
                    ((TextBox)c).Paste();
                    } else if (c is Button) {
                        c.BackColor = Color.LightCoral;
                    }
                
            }
        }
    }
}
