namespace ProyectoAdo
{
    partial class Form08ModificarEmpTriggers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtComi = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtInc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comisión:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(387, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(136, 24);
            this.txtApellido.TabIndex = 5;
            // 
            // txtComi
            // 
            this.txtComi.Location = new System.Drawing.Point(387, 182);
            this.txtComi.Name = "txtComi";
            this.txtComi.Size = new System.Drawing.Size(136, 24);
            this.txtComi.TabIndex = 6;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(387, 143);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(136, 24);
            this.txtSalario.TabIndex = 7;
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(130, 105);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(121, 26);
            this.cmbEmp.TabIndex = 8;
            this.cmbEmp.SelectedIndexChanged += new System.EventHandler(this.cmbEmp_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(337, 227);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 32);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departamento:";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(262, 358);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(100, 24);
            this.txtDep.TabIndex = 12;
            // 
            // txtInc
            // 
            this.txtInc.Location = new System.Drawing.Point(262, 407);
            this.txtInc.Name = "txtInc";
            this.txtInc.Size = new System.Drawing.Size(100, 24);
            this.txtInc.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Incremento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Incrementar salario DEPT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            // 
            // Form08ModificarEmpTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 567);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtComi);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form08ModificarEmpTriggers";
            this.Text = "Form08ModificarEmpTriggers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtComi;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtInc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}