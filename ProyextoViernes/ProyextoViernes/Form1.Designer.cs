namespace ProyextoViernes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarDept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDept = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarEmp = new System.Windows.Forms.Button();
            this.listBoxEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrarDept
            // 
            this.btnMostrarDept.Location = new System.Drawing.Point(181, 327);
            this.btnMostrarDept.Name = "btnMostrarDept";
            this.btnMostrarDept.Size = new System.Drawing.Size(213, 43);
            this.btnMostrarDept.TabIndex = 0;
            this.btnMostrarDept.Text = "Mostrar Departamentos";
            this.btnMostrarDept.UseVisualStyleBackColor = true;
            this.btnMostrarDept.Click += new System.EventHandler(this.btnMostrarDept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamentos:";
            // 
            // listViewDept
            // 
            this.listViewDept.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDept.HideSelection = false;
            this.listViewDept.Location = new System.Drawing.Point(84, 133);
            this.listViewDept.Name = "listViewDept";
            this.listViewDept.Size = new System.Drawing.Size(415, 161);
            this.listViewDept.TabIndex = 2;
            this.listViewDept.UseCompatibleStateImageBehavior = false;
            this.listViewDept.View = System.Windows.Forms.View.Details;
           
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Localidad";
            this.columnHeader3.Width = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer LINQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleados:";
            // 
            // btnMostrarEmp
            // 
            this.btnMostrarEmp.Location = new System.Drawing.Point(694, 327);
            this.btnMostrarEmp.Name = "btnMostrarEmp";
            this.btnMostrarEmp.Size = new System.Drawing.Size(213, 43);
            this.btnMostrarEmp.TabIndex = 4;
            this.btnMostrarEmp.Text = "Mostrar Empleados";
            this.btnMostrarEmp.UseVisualStyleBackColor = true;
            this.btnMostrarEmp.Click += new System.EventHandler(this.btnMostrarEmp_Click);
            // 
            // listBoxEmpleados
            // 
            this.listBoxEmpleados.FormattingEnabled = true;
            this.listBoxEmpleados.ItemHeight = 18;
            this.listBoxEmpleados.Location = new System.Drawing.Point(597, 133);
            this.listBoxEmpleados.Name = "listBoxEmpleados";
            this.listBoxEmpleados.Size = new System.Drawing.Size(394, 166);
            this.listBoxEmpleados.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 421);
            this.Controls.Add(this.listBoxEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrarEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewDept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarDept);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDept;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarEmp;
        private System.Windows.Forms.ListBox listBoxEmpleados;
    }
}

