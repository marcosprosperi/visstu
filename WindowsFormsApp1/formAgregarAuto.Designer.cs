namespace WindowsFormsApp1
{
    partial class formAgregarAuto
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
            this.inputDominio = new System.Windows.Forms.TextBox();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.inputModelo = new System.Windows.Forms.TextBox();
            this.inputAnio = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dominio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año:";
            // 
            // inputDominio
            // 
            this.inputDominio.Location = new System.Drawing.Point(71, 51);
            this.inputDominio.Name = "inputDominio";
            this.inputDominio.Size = new System.Drawing.Size(189, 20);
            this.inputDominio.TabIndex = 4;
            this.inputDominio.TextChanged += new System.EventHandler(this.inputDominio_TextChanged);
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(71, 75);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(189, 20);
            this.inputMarca.TabIndex = 5;
            // 
            // inputModelo
            // 
            this.inputModelo.Location = new System.Drawing.Point(71, 101);
            this.inputModelo.Name = "inputModelo";
            this.inputModelo.Size = new System.Drawing.Size(189, 20);
            this.inputModelo.TabIndex = 6;
            // 
            // inputAnio
            // 
            this.inputAnio.Location = new System.Drawing.Point(71, 126);
            this.inputAnio.Name = "inputAnio";
            this.inputAnio.Size = new System.Drawing.Size(189, 20);
            this.inputAnio.TabIndex = 7;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(152, 187);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(107, 30);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "&Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alta / Modificacion";
            // 
            // formAgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.inputAnio);
            this.Controls.Add(this.inputModelo);
            this.Controls.Add(this.inputMarca);
            this.Controls.Add(this.inputDominio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAgregarAuto";
            this.Text = "Agregar Auto";
            this.Load += new System.EventHandler(this.formAgregarAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputDominio;
        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.TextBox inputModelo;
        private System.Windows.Forms.TextBox inputAnio;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}