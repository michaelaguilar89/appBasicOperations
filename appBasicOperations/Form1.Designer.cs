
namespace appBasicOperations
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Numero1 = new System.Windows.Forms.Label();
            this.Numero2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSuma = new System.Windows.Forms.RadioButton();
            this.rdResta = new System.Windows.Forms.RadioButton();
            this.rdMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rdDivision = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(222, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Numero1
            // 
            this.Numero1.AutoSize = true;
            this.Numero1.Location = new System.Drawing.Point(29, 32);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(50, 13);
            this.Numero1.TabIndex = 1;
            this.Numero1.Text = "Numero1";
            // 
            // Numero2
            // 
            this.Numero2.AutoSize = true;
            this.Numero2.Location = new System.Drawing.Point(29, 79);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(50, 13);
            this.Numero2.TabIndex = 2;
            this.Numero2.Text = "Numero2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(155, 32);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(155, 79);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDivision);
            this.groupBox1.Controls.Add(this.rdMultiplicacion);
            this.groupBox1.Controls.Add(this.rdResta);
            this.groupBox1.Controls.Add(this.rdSuma);
            this.groupBox1.Location = new System.Drawing.Point(344, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una operacion";
            // 
            // rdSuma
            // 
            this.rdSuma.AutoSize = true;
            this.rdSuma.Location = new System.Drawing.Point(57, 33);
            this.rdSuma.Name = "rdSuma";
            this.rdSuma.Size = new System.Drawing.Size(52, 17);
            this.rdSuma.TabIndex = 9;
            this.rdSuma.TabStop = true;
            this.rdSuma.Text = "Suma";
            this.rdSuma.UseVisualStyleBackColor = true;
            // 
            // rdResta
            // 
            this.rdResta.AutoSize = true;
            this.rdResta.Location = new System.Drawing.Point(57, 56);
            this.rdResta.Name = "rdResta";
            this.rdResta.Size = new System.Drawing.Size(53, 17);
            this.rdResta.TabIndex = 10;
            this.rdResta.TabStop = true;
            this.rdResta.Text = "Resta";
            this.rdResta.UseVisualStyleBackColor = true;
            // 
            // rdMultiplicacion
            // 
            this.rdMultiplicacion.AutoSize = true;
            this.rdMultiplicacion.Location = new System.Drawing.Point(57, 82);
            this.rdMultiplicacion.Name = "rdMultiplicacion";
            this.rdMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rdMultiplicacion.TabIndex = 11;
            this.rdMultiplicacion.TabStop = true;
            this.rdMultiplicacion.Text = "Multiplicacion";
            this.rdMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdDivision
            // 
            this.rdDivision.AutoSize = true;
            this.rdDivision.Location = new System.Drawing.Point(57, 105);
            this.rdDivision.Name = "rdDivision";
            this.rdDivision.Size = new System.Drawing.Size(62, 17);
            this.rdDivision.TabIndex = 12;
            this.rdDivision.TabStop = true;
            this.rdDivision.Text = "Division";
            this.rdDivision.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label Numero1;
        private System.Windows.Forms.Label Numero2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdResta;
        private System.Windows.Forms.RadioButton rdSuma;
        private System.Windows.Forms.RadioButton rdDivision;
        private System.Windows.Forms.RadioButton rdMultiplicacion;
    }
}