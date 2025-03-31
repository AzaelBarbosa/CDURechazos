namespace CDURechazos.Base_Forms
{
    partial class frmCatalogos
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
            this.mnFormulario = new System.Windows.Forms.MenuStrip();
            this.tbNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tbGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnFormulario
            // 
            this.mnFormulario.AllowMerge = false;
            this.mnFormulario.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnFormulario.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnFormulario.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnFormulario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNuevo,
            this.tbGuardar,
            this.tbEliminar});
            this.mnFormulario.Location = new System.Drawing.Point(0, 0);
            this.mnFormulario.Name = "mnFormulario";
            this.mnFormulario.Size = new System.Drawing.Size(1033, 48);
            this.mnFormulario.TabIndex = 0;
            this.mnFormulario.Text = "menuStrip1";
            // 
            // tbNuevo
            // 
            this.tbNuevo.Image = global::CDURechazos.Properties.Resources._1486564407_plus_green_81521;
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(147, 41);
            this.tbNuevo.Text = "Nuevo";
            this.tbNuevo.Click += new System.EventHandler(this.tbNuevo_Click);
            // 
            // tbGuardar
            // 
            this.tbGuardar.Image = global::CDURechazos.Properties.Resources.disco_flexible;
            this.tbGuardar.Name = "tbGuardar";
            this.tbGuardar.Size = new System.Drawing.Size(165, 41);
            this.tbGuardar.Text = "Guardar";
            this.tbGuardar.Click += new System.EventHandler(this.tbGuardar_Click);
            // 
            // tbEliminar
            // 
            this.tbEliminar.Image = global::CDURechazos.Properties.Resources.eliminar;
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Size = new System.Drawing.Size(165, 41);
            this.tbEliminar.Text = "Eliminar";
            this.tbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbEliminar.Click += new System.EventHandler(this.tbEliminar_Click);
            // 
            // frmCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 908);
            this.Controls.Add(this.mnFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnFormulario;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalogos";
            this.Text = "frmCatalogos";
            this.Load += new System.EventHandler(this.frmCatalogos_Load);
            this.mnFormulario.ResumeLayout(false);
            this.mnFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MenuStrip mnFormulario;
        protected System.Windows.Forms.ToolStripMenuItem tbNuevo;
        protected System.Windows.Forms.ToolStripMenuItem tbGuardar;
        protected System.Windows.Forms.ToolStripMenuItem tbEliminar;
    }
}