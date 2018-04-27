using System;

namespace WindowsFormsApp1
{
    partial class modInfraccion
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
            this.listTipoInfraccion = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioLeve = new System.Windows.Forms.RadioButton();
            this.radioGrave = new System.Windows.Forms.RadioButton();
            this.InputImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputDetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de tipo de infracciones";
            // 
            // listTipoInfraccion
            // 
            this.listTipoInfraccion.FormattingEnabled = true;
            this.listTipoInfraccion.Location = new System.Drawing.Point(18, 57);
            this.listTipoInfraccion.Name = "listTipoInfraccion";
            this.listTipoInfraccion.Size = new System.Drawing.Size(413, 199);
            this.listTipoInfraccion.TabIndex = 1;
            this.listTipoInfraccion.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "&Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gravedad de la infraccion";
            // 
            // RadioLeve
            // 
            this.RadioLeve.AutoSize = true;
            this.RadioLeve.Location = new System.Drawing.Point(106, 132);
            this.RadioLeve.Name = "RadioLeve";
            this.RadioLeve.Size = new System.Drawing.Size(49, 17);
            this.RadioLeve.TabIndex = 21;
            this.RadioLeve.TabStop = true;
            this.RadioLeve.Text = "Leve";
            this.RadioLeve.UseVisualStyleBackColor = true;
            // 
            // radioGrave
            // 
            this.radioGrave.AutoSize = true;
            this.radioGrave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radioGrave.Location = new System.Drawing.Point(15, 132);
            this.radioGrave.Name = "radioGrave";
            this.radioGrave.Size = new System.Drawing.Size(54, 17);
            this.radioGrave.TabIndex = 20;
            this.radioGrave.TabStop = true;
            this.radioGrave.Text = "Grave";
            this.radioGrave.UseVisualStyleBackColor = true;
            // 
            // InputImporte
            // 
            this.InputImporte.Location = new System.Drawing.Point(59, 69);
            this.InputImporte.Name = "InputImporte";
            this.InputImporte.Size = new System.Drawing.Size(252, 20);
            this.InputImporte.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Importe";
            // 
            // InputDetalle
            // 
            this.InputDetalle.Location = new System.Drawing.Point(59, 43);
            this.InputDetalle.Name = "InputDetalle";
            this.InputDetalle.Size = new System.Drawing.Size(252, 20);
            this.InputDetalle.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Detalle";
            // 
            // inputCod
            // 
            this.inputCod.Location = new System.Drawing.Point(59, 17);
            this.inputCod.Name = "inputCod";
            this.inputCod.ReadOnly = true;
            this.inputCod.Size = new System.Drawing.Size(252, 20);
            this.inputCod.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RadioLeve);
            this.groupBox1.Controls.Add(this.radioGrave);
            this.groupBox1.Controls.Add(this.InputImporte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.InputDetalle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputCod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 237);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // modInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listTipoInfraccion);
            this.Controls.Add(this.label1);
            this.Name = "modInfraccion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.modInfraccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTipoInfraccion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioLeve;
        private System.Windows.Forms.RadioButton radioGrave;
        private System.Windows.Forms.TextBox InputImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}