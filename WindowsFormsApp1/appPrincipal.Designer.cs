namespace WindowsFormsApp1
{
    partial class appPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPersonaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaMultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarMiultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.entidadesToolStripMenuItem,
            this.autosToolStripMenuItem,
            this.multasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.agregarToolStripMenuItem.Text = "Tipo de Infracciones";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPersonaToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.entidadesToolStripMenuItem.Text = "Entidades";
            // 
            // altaPersonaToolStripMenuItem
            // 
            this.altaPersonaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPersonaToolStripMenuItem1,
            this.modificarPersonaToolStripMenuItem});
            this.altaPersonaToolStripMenuItem.Name = "altaPersonaToolStripMenuItem";
            this.altaPersonaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.altaPersonaToolStripMenuItem.Text = "Persona";
            // 
            // altaPersonaToolStripMenuItem1
            // 
            this.altaPersonaToolStripMenuItem1.Name = "altaPersonaToolStripMenuItem1";
            this.altaPersonaToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.altaPersonaToolStripMenuItem1.Text = "Alta Persona";
            this.altaPersonaToolStripMenuItem1.Click += new System.EventHandler(this.altaPersonaToolStripMenuItem1_Click);
            // 
            // modificarPersonaToolStripMenuItem
            // 
            this.modificarPersonaToolStripMenuItem.Name = "modificarPersonaToolStripMenuItem";
            this.modificarPersonaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarPersonaToolStripMenuItem.Text = "Modificar Persona";
            this.modificarPersonaToolStripMenuItem.Click += new System.EventHandler(this.modificarPersonaToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpresaToolStripMenuItem,
            this.modificarEmpresaToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // altaEmpresaToolStripMenuItem
            // 
            this.altaEmpresaToolStripMenuItem.Name = "altaEmpresaToolStripMenuItem";
            this.altaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.altaEmpresaToolStripMenuItem.Text = "Alta Empresa";
            this.altaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.altaEmpresaToolStripMenuItem_Click);
            // 
            // modificarEmpresaToolStripMenuItem
            // 
            this.modificarEmpresaToolStripMenuItem.Name = "modificarEmpresaToolStripMenuItem";
            this.modificarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificarEmpresaToolStripMenuItem.Text = "Modificar Empresa";
            this.modificarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.modificarEmpresaToolStripMenuItem_Click);
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAutoToolStripMenuItem,
            this.modificarAutoToolStripMenuItem});
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.autosToolStripMenuItem.Text = "Autos";
            // 
            // altaAutoToolStripMenuItem
            // 
            this.altaAutoToolStripMenuItem.Name = "altaAutoToolStripMenuItem";
            this.altaAutoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.altaAutoToolStripMenuItem.Text = "Alta Auto";
            this.altaAutoToolStripMenuItem.Click += new System.EventHandler(this.altaAutoToolStripMenuItem_Click);
            // 
            // modificarAutoToolStripMenuItem
            // 
            this.modificarAutoToolStripMenuItem.Name = "modificarAutoToolStripMenuItem";
            this.modificarAutoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modificarAutoToolStripMenuItem.Text = "Modificar Auto";
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaMultaToolStripMenuItem,
            this.pagarMiultaToolStripMenuItem});
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            this.multasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.multasToolStripMenuItem.Text = "Multas";
            // 
            // altaMultaToolStripMenuItem
            // 
            this.altaMultaToolStripMenuItem.Name = "altaMultaToolStripMenuItem";
            this.altaMultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaMultaToolStripMenuItem.Text = "Alta Multa";
            this.altaMultaToolStripMenuItem.Click += new System.EventHandler(this.altaMultaToolStripMenuItem_Click);
            // 
            // pagarMiultaToolStripMenuItem
            // 
            this.pagarMiultaToolStripMenuItem.Name = "pagarMiultaToolStripMenuItem";
            this.pagarMiultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagarMiultaToolStripMenuItem.Text = "Pagar Miulta";
            this.pagarMiultaToolStripMenuItem.Click += new System.EventHandler(this.pagarMiultaToolStripMenuItem_Click);
            // 
            // appPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "appPrincipal";
            this.Text = "Aplicacion de transito";
            this.Load += new System.EventHandler(this.appPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPersonaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaMultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarMiultaToolStripMenuItem;
    }
}

