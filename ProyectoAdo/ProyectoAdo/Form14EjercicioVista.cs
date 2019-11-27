using ProyectoAdo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region

//ALTER TRIGGER Trigger_Update
//ON VistaTrabajadores
//INSTEAD OF UPDATE
//AS
//    DECLARE CONSULTA2 CURSOR FOR
//    SELECT SALARIO, TABLA, NUMERO
//    FROM inserted

//    DECLARE @INCR INT

//    DECLARE @SALARIO INT
//    DECLARE @TABLA NVARCHAR(10)

//    DECLARE @NUM INT
//    OPEN CONSULTA2

//        FETCH NEXT FROM CONSULTA2 INTO @SALARIO	, @TABLA, @NUM

//    SELECT*, @SALARIO FROM INSERTED
//   WHILE(@@FETCH_STATUS = 0)

//    BEGIN
//        IF(@TABLA = 'PLANTILLA')

//        BEGIN
//            UPDATE PLANTILLA SET SALARIO = @SALARIO
//            WHERE EMPLEADO_NO = @NUM;
//		END
//        ELSE

//        BEGIN
//            UPDATE DOCTOR SET SALARIO = @SALARIO
//            WHERE DOCTOR_NO = @NUM
//        END

//        FETCH NEXT FROM CONSULTA2 INTO @SALARIO, @TABLA, @NUM

//    END
//    CLOSE CONSULTA2
//    DEALLOCATE CONSULTA2
//GO

#endregion

namespace ProyectoAdo
{
    public partial class Form14EjercicioVista : Form
    {
        Class14Datos datos;
        String apel;
        String trab;
        int sal;
        public Form14EjercicioVista()
        {
            InitializeComponent();
            datos = new Class14Datos();
            PintarTrabajadores();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form15Vista form2 = new Form15Vista(apel,trab, sal);                
            form2.Show();
        }

        private void btnSubirSalario_Click(object sender, EventArgs e)
        {           
            datos.IncrementarSalario(int.Parse(this.txtIncr.Text));
            PintarTrabajadores();
        }

        private void PintarTrabajadores() {

            this.listView1.Items.Clear();
            List<Trabajadores> listaTrab = datos.GetTrabajadores();

            foreach (Trabajadores trab in listaTrab)
            {
                ListViewItem it = new ListViewItem();
                it.Text = trab.apellido.ToString();
                it.SubItems.Add(trab.trabajo.ToString());
                it.SubItems.Add(trab.Salario.ToString());
                it.Tag = int.Parse(trab.Numero.ToString());
                this.listView1.Items.Add(it);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                ListViewItem itSelec = this.listView1.SelectedItems[0];
                apel = itSelec.Text;
                trab = itSelec.SubItems[1].Text;
                sal = int.Parse(itSelec.SubItems[2].Text);
            }
        }
    }
}
