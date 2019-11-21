namespace ProyectoAdo
{
    partial class Form07MensajesServidor
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertDept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDept = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensajes Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(145, 112);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(133, 24);
            this.txtNum.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 24);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txtxCity
            // 
            this.txtxCity.Location = new System.Drawing.Point(145, 202);
            this.txtxCity.Name = "txtxCity";
            this.txtxCity.Size = new System.Drawing.Size(133, 24);
            this.txtxCity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ciudad: ";
            // 
            // btnInsertDept
            // 
            this.btnInsertDept.Location = new System.Drawing.Point(145, 244);
            this.btnInsertDept.Name = "btnInsertDept";
            this.btnInsertDept.Size = new System.Drawing.Size(133, 28);
            this.btnInsertDept.TabIndex = 7;
            this.btnInsertDept.Text = "Insertar DEPT";
            this.btnInsertDept.UseVisualStyleBackColor = true;
            this.btnInsertDept.Click += new System.EventHandler(this.btnInsertDept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamentos:";
            // 
            // lstDept
            // 
            this.lstDept.FormattingEnabled = true;
            this.lstDept.ItemHeight = 18;
            this.lstDept.Location = new System.Drawing.Point(323, 115);
            this.lstDept.Name = "lstDept";
            this.lstDept.Size = new System.Drawing.Size(362, 166);
            this.lstDept.TabIndex = 9;
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Location = new System.Drawing.Point(323, 287);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(133, 18);
            this.txtMensaje.TabIndex = 10;
            this.txtMensaje.Text = "-------------------------";
            // 
            // Form07MensajesServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(745, 363);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lstDept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertDept);
            this.Controls.Add(this.txtxCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form07MensajesServidor";
            this.Text = "Form07MensajesServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDept;
        private System.Windows.Forms.Label txtMensaje;
    }
}