namespace ProyectoAdo
{
    partial class Form01PrimerConectado
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLeerDatos = new System.Windows.Forms.Button();
            this.txtConnection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstColumn = new System.Windows.Forms.ListBox();
            this.lstApell = new System.Windows.Forms.ListBox();
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Conectado";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(68, 110);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(106, 27);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(68, 146);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(106, 27);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLeerDatos
            // 
            this.btnLeerDatos.Location = new System.Drawing.Point(68, 185);
            this.btnLeerDatos.Name = "btnLeerDatos";
            this.btnLeerDatos.Size = new System.Drawing.Size(106, 27);
            this.btnLeerDatos.TabIndex = 3;
            this.btnLeerDatos.Text = "Leer Datos";
            this.btnLeerDatos.UseVisualStyleBackColor = true;
            this.btnLeerDatos.Click += new System.EventHandler(this.btnLeerDatos_Click);
            // 
            // txtConnection
            // 
            this.txtConnection.AutoSize = true;
            this.txtConnection.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtConnection.Location = new System.Drawing.Point(309, 352);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(92, 17);
            this.txtConnection.TabIndex = 4;
            this.txtConnection.Text = "lblConecction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Columnas";
            // 
            // lstColumn
            // 
            this.lstColumn.FormattingEnabled = true;
            this.lstColumn.ItemHeight = 16;
            this.lstColumn.Location = new System.Drawing.Point(382, 100);
            this.lstColumn.Name = "lstColumn";
            this.lstColumn.Size = new System.Drawing.Size(135, 228);
            this.lstColumn.TabIndex = 7;
            // 
            // lstApell
            // 
            this.lstApell.FormattingEnabled = true;
            this.lstApell.ItemHeight = 16;
            this.lstApell.Location = new System.Drawing.Point(230, 100);
            this.lstApell.Name = "lstApell";
            this.lstApell.Size = new System.Drawing.Size(135, 228);
            this.lstApell.TabIndex = 8;
            // 
            // lstTipos
            // 
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.ItemHeight = 16;
            this.lstTipos.Location = new System.Drawing.Point(533, 100);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(135, 228);
            this.lstTipos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(92, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "cadena de conexion :  view > server Explorer > btn derech \'Add Connection\' > SQL " +
    "Server > ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(12, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(755, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "nombre del servidor : localhost ó nombre del equipo > Tipo de autentificación  > " +
    "server authentic > password y usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(95, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(587, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "SELECCIONAR LA BBDD, proopiedades en dat connections y copiar el string de connec" +
    "tion";
            // 
            // Form01PrimerConectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(807, 474);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.lstApell);
            this.Controls.Add(this.lstColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConnection);
            this.Controls.Add(this.btnLeerDatos);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form01PrimerConectado";
            this.Text = "Form01PrimerConectado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnLeerDatos;
        private System.Windows.Forms.Label txtConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstColumn;
        private System.Windows.Forms.ListBox lstApell;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}