namespace Fundamentos
{
    partial class Form21AsociarEventos
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
            this.groupNum = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupLetras = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupNum.SuspendLayout();
            this.groupLetras.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNum
            // 
            this.groupNum.Controls.Add(this.textBox2);
            this.groupNum.Controls.Add(this.textBox3);
            this.groupNum.Controls.Add(this.textBox1);
            this.groupNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNum.Location = new System.Drawing.Point(347, 111);
            this.groupNum.Name = "groupNum";
            this.groupNum.Size = new System.Drawing.Size(200, 166);
            this.groupNum.TabIndex = 17;
            this.groupNum.TabStop = false;
            this.groupNum.Text = "Números";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eventos Dinámicos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 20;
            // 
            // groupLetras
            // 
            this.groupLetras.Controls.Add(this.textBox4);
            this.groupLetras.Controls.Add(this.textBox5);
            this.groupLetras.Controls.Add(this.textBox6);
            this.groupLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLetras.Location = new System.Drawing.Point(77, 111);
            this.groupLetras.Name = "groupLetras";
            this.groupLetras.Size = new System.Drawing.Size(200, 166);
            this.groupLetras.TabIndex = 18;
            this.groupLetras.TabStop = false;
            this.groupLetras.Text = "Letras";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(37, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(37, 34);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 18;
            // 
            // Form21AsociarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(673, 354);
            this.Controls.Add(this.groupLetras);
            this.Controls.Add(this.groupNum);
            this.Controls.Add(this.label1);
            this.Name = "Form21AsociarEventos";
            this.Text = "Form21AsociarEventos";
            this.groupNum.ResumeLayout(false);
            this.groupNum.PerformLayout();
            this.groupLetras.ResumeLayout(false);
            this.groupLetras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupLetras;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}