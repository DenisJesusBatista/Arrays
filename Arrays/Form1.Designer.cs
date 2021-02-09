namespace Arrays
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
            this.btnTesteVetor = new System.Windows.Forms.Button();
            this.btnVetorTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTesteVetor
            // 
            this.btnTesteVetor.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTesteVetor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesteVetor.ForeColor = System.Drawing.Color.Transparent;
            this.btnTesteVetor.Location = new System.Drawing.Point(72, 33);
            this.btnTesteVetor.Name = "btnTesteVetor";
            this.btnTesteVetor.Size = new System.Drawing.Size(148, 54);
            this.btnTesteVetor.TabIndex = 0;
            this.btnTesteVetor.Text = "Teste Vetor";
            this.btnTesteVetor.UseVisualStyleBackColor = false;
            this.btnTesteVetor.Click += new System.EventHandler(this.btnTesteVetor_Click);
            // 
            // btnVetorTexto
            // 
            this.btnVetorTexto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVetorTexto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetorTexto.ForeColor = System.Drawing.Color.Transparent;
            this.btnVetorTexto.Location = new System.Drawing.Point(72, 156);
            this.btnVetorTexto.Name = "btnVetorTexto";
            this.btnVetorTexto.Size = new System.Drawing.Size(148, 54);
            this.btnVetorTexto.TabIndex = 1;
            this.btnVetorTexto.Text = "Vetor Textos";
            this.btnVetorTexto.UseVisualStyleBackColor = false;
            this.btnVetorTexto.Click += new System.EventHandler(this.btnVetorTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVetorTexto);
            this.Controls.Add(this.btnTesteVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesteVetor;
        private System.Windows.Forms.Button btnVetorTexto;
    }
}

