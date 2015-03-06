namespace WindowsFormsApplication1
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
            this.bttRecursivo = new System.Windows.Forms.Button();
            this.bttIterativo = new System.Windows.Forms.Button();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttRecursivo
            // 
            this.bttRecursivo.Location = new System.Drawing.Point(25, 71);
            this.bttRecursivo.Name = "bttRecursivo";
            this.bttRecursivo.Size = new System.Drawing.Size(87, 29);
            this.bttRecursivo.TabIndex = 0;
            this.bttRecursivo.Text = "Recursivo";
            this.bttRecursivo.UseVisualStyleBackColor = true;
            this.bttRecursivo.Click += new System.EventHandler(this.Recursão);
            // 
            // bttIterativo
            // 
            this.bttIterativo.Location = new System.Drawing.Point(127, 71);
            this.bttIterativo.Name = "bttIterativo";
            this.bttIterativo.Size = new System.Drawing.Size(87, 29);
            this.bttIterativo.TabIndex = 1;
            this.bttIterativo.Text = "Iterativo";
            this.bttIterativo.UseVisualStyleBackColor = true;
            this.bttIterativo.Click += new System.EventHandler(this.Iteração);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(25, 21);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(189, 20);
            this.textBoxNumero.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(82, 44);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(61, 13);
            this.Result.TabIndex = 3;
            this.Result.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 125);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.bttIterativo);
            this.Controls.Add(this.bttRecursivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttRecursivo;
        private System.Windows.Forms.Button bttIterativo;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label Result;
    }
}

