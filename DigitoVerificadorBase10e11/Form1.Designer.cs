namespace SolutionDigitoVerificadorBase10e11
{
    partial class Main
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculaDigito = new System.Windows.Forms.Button();
            this.lbBase10 = new System.Windows.Forms.Label();
            this.lbBase11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(150, 44);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(83, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "1";
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe um Valor :";
            // 
            // btnCalculaDigito
            // 
            this.btnCalculaDigito.Location = new System.Drawing.Point(252, 42);
            this.btnCalculaDigito.Name = "btnCalculaDigito";
            this.btnCalculaDigito.Size = new System.Drawing.Size(124, 23);
            this.btnCalculaDigito.TabIndex = 2;
            this.btnCalculaDigito.Text = "Calculo Dígito";
            this.btnCalculaDigito.UseVisualStyleBackColor = true;
            this.btnCalculaDigito.Click += new System.EventHandler(this.btnCalculaDigito_Click);
            // 
            // lbBase10
            // 
            this.lbBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase10.Location = new System.Drawing.Point(46, 121);
            this.lbBase10.Name = "lbBase10";
            this.lbBase10.Size = new System.Drawing.Size(330, 16);
            this.lbBase10.TabIndex = 3;
            this.lbBase10.Text = "Dígito verificador base 10 : ";
            // 
            // lbBase11
            // 
            this.lbBase11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase11.Location = new System.Drawing.Point(46, 158);
            this.lbBase11.Name = "lbBase11";
            this.lbBase11.Size = new System.Drawing.Size(330, 16);
            this.lbBase11.TabIndex = 4;
            this.lbBase11.Text = "Dígito verificador base 11 : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 205);
            this.Controls.Add(this.lbBase11);
            this.Controls.Add(this.lbBase10);
            this.Controls.Add(this.btnCalculaDigito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Digito Verificador Base 10 e 11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculaDigito;
        private System.Windows.Forms.Label lbBase10;
        private System.Windows.Forms.Label lbBase11;
    }
}

