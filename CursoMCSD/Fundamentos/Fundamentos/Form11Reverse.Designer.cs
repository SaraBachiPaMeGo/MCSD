namespace Fundamentos
{
    partial class Form11Reverse
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
            this.btnInvertir2 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce una palabra";
            // 
            // btnInvertir2
            // 
            this.btnInvertir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertir2.Location = new System.Drawing.Point(353, 215);
            this.btnInvertir2.Name = "btnInvertir2";
            this.btnInvertir2.Size = new System.Drawing.Size(111, 48);
            this.btnInvertir2.TabIndex = 1;
            this.btnInvertir2.Text = "Invertir StringBuilder";
            this.btnInvertir2.UseVisualStyleBackColor = true;
            this.btnInvertir2.Click += new System.EventHandler(this.btnInvertir2_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtResult.Location = new System.Drawing.Point(172, 310);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(104, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "-------------------";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(175, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(325, 162);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "";
            // 
            // btnInvertir
            // 
            this.btnInvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertir.Location = new System.Drawing.Point(217, 215);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(111, 48);
            this.btnInvertir.TabIndex = 5;
            this.btnInvertir.Text = "Invertir String";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // Form11Reverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnInvertir2);
            this.Controls.Add(this.label1);
            this.Name = "Form11Reverse";
            this.Text = "Form11Reverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInvertir2;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnInvertir;
    }
}