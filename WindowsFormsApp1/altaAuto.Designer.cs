namespace WindowsFormsApp1
{
    partial class altaAuto
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
            this.ComoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.inputModelo = new System.Windows.Forms.TextBox();
            this.inputAnio = new System.Windows.Forms.TextBox();
            this.inputDominio = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ComoUsuario
            // 
            this.ComoUsuario.FormattingEnabled = true;
            this.ComoUsuario.Items.AddRange(new object[] {
            "Persona",
            "Corporacion"});
            this.ComoUsuario.Location = new System.Drawing.Point(28, 163);
            this.ComoUsuario.Name = "ComoUsuario";
            this.ComoUsuario.Size = new System.Drawing.Size(199, 21);
            this.ComoUsuario.TabIndex = 0;
            this.ComoUsuario.Text = "Seleccione tipo de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alta Auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dominio";
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(82, 45);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(145, 20);
            this.inputMarca.TabIndex = 6;
            // 
            // inputModelo
            // 
            this.inputModelo.Location = new System.Drawing.Point(82, 67);
            this.inputModelo.Name = "inputModelo";
            this.inputModelo.Size = new System.Drawing.Size(145, 20);
            this.inputModelo.TabIndex = 7;
            // 
            // inputAnio
            // 
            this.inputAnio.Location = new System.Drawing.Point(82, 90);
            this.inputAnio.Name = "inputAnio";
            this.inputAnio.Size = new System.Drawing.Size(145, 20);
            this.inputAnio.TabIndex = 8;
            // 
            // inputDominio
            // 
            this.inputDominio.Location = new System.Drawing.Point(82, 112);
            this.inputDominio.Name = "inputDominio";
            this.inputDominio.Size = new System.Drawing.Size(145, 20);
            this.inputDominio.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 199);
            this.listBox1.TabIndex = 10;
            this.listBox1.Visible = false;
            // 
            // altaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 445);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.inputDominio);
            this.Controls.Add(this.inputAnio);
            this.Controls.Add(this.inputModelo);
            this.Controls.Add(this.inputMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComoUsuario);
            this.Name = "altaAuto";
            this.Text = "altaAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.TextBox inputModelo;
        private System.Windows.Forms.TextBox inputAnio;
        private System.Windows.Forms.TextBox inputDominio;
        private System.Windows.Forms.ListBox listBox1;
    }
}