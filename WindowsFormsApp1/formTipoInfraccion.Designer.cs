namespace WindowsFormsApp1
{
    partial class formTipoInfraccion
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
            this.inputCod = new System.Windows.Forms.TextBox();
            this.InputDetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioGrave = new System.Windows.Forms.RadioButton();
            this.RadioLeve = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE UNA NUEVO TIPO DE INFRACCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // inputCod
            // 
            this.inputCod.Location = new System.Drawing.Point(59, 72);
            this.inputCod.Name = "inputCod";
            this.inputCod.Size = new System.Drawing.Size(252, 20);
            this.inputCod.TabIndex = 2;
            this.inputCod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InputDetalle
            // 
            this.InputDetalle.Location = new System.Drawing.Point(59, 98);
            this.InputDetalle.Name = "InputDetalle";
            this.InputDetalle.Size = new System.Drawing.Size(252, 20);
            this.InputDetalle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detalle";
            // 
            // InputImporte
            // 
            this.InputImporte.Location = new System.Drawing.Point(59, 124);
            this.InputImporte.Name = "InputImporte";
            this.InputImporte.Size = new System.Drawing.Size(252, 20);
            this.InputImporte.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Importe";
            // 
            // radioGrave
            // 
            this.radioGrave.AutoSize = true;
            this.radioGrave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radioGrave.Location = new System.Drawing.Point(15, 187);
            this.radioGrave.Name = "radioGrave";
            this.radioGrave.Size = new System.Drawing.Size(54, 17);
            this.radioGrave.TabIndex = 9;
            this.radioGrave.TabStop = true;
            this.radioGrave.Text = "Grave";
            this.radioGrave.UseVisualStyleBackColor = true;
            this.radioGrave.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioLeve
            // 
            this.RadioLeve.AutoSize = true;
            this.RadioLeve.Location = new System.Drawing.Point(106, 187);
            this.RadioLeve.Name = "RadioLeve";
            this.RadioLeve.Size = new System.Drawing.Size(49, 17);
            this.RadioLeve.TabIndex = 10;
            this.RadioLeve.TabStop = true;
            this.RadioLeve.Text = "Leve";
            this.RadioLeve.UseVisualStyleBackColor = true;
            this.RadioLeve.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gravedad de la infraccion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formTipoInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RadioLeve);
            this.Controls.Add(this.radioGrave);
            this.Controls.Add(this.InputImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formTipoInfraccion";
            this.Text = "Agregar Tipo de infraccion";
            this.Load += new System.EventHandler(this.formTipoInfraccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCod;
        private System.Windows.Forms.TextBox InputDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioGrave;
        private System.Windows.Forms.RadioButton RadioLeve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}