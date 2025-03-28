namespace CDURechazos.Catalogos
{
    partial class frmSubFallas
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
            this.gbSubFalla = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFallas = new System.Windows.Forms.ComboBox();
            this.chEstatus = new System.Windows.Forms.CheckBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.dgvFallas = new System.Windows.Forms.DataGridView();
            this.btNewSubFalla = new System.Windows.Forms.Button();
            this.cboFallasFiltro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSubFalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSubFalla
            // 
            this.gbSubFalla.Controls.Add(this.label4);
            this.gbSubFalla.Controls.Add(this.cboFallas);
            this.gbSubFalla.Controls.Add(this.chEstatus);
            this.gbSubFalla.Controls.Add(this.txNombre);
            this.gbSubFalla.Controls.Add(this.label2);
            this.gbSubFalla.Controls.Add(this.btCancelar);
            this.gbSubFalla.Controls.Add(this.btAceptar);
            this.gbSubFalla.Location = new System.Drawing.Point(16, 477);
            this.gbSubFalla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbSubFalla.Name = "gbSubFalla";
            this.gbSubFalla.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbSubFalla.Size = new System.Drawing.Size(836, 285);
            this.gbSubFalla.TabIndex = 5;
            this.gbSubFalla.TabStop = false;
            this.gbSubFalla.Text = "Alta SubFalla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Falla:";
            // 
            // cboFallas
            // 
            this.cboFallas.FormattingEnabled = true;
            this.cboFallas.Location = new System.Drawing.Point(160, 52);
            this.cboFallas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFallas.Name = "cboFallas";
            this.cboFallas.Size = new System.Drawing.Size(384, 33);
            this.cboFallas.TabIndex = 8;
            // 
            // chEstatus
            // 
            this.chEstatus.AutoSize = true;
            this.chEstatus.Location = new System.Drawing.Point(168, 146);
            this.chEstatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chEstatus.Name = "chEstatus";
            this.chEstatus.Size = new System.Drawing.Size(103, 29);
            this.chEstatus.TabIndex = 6;
            this.chEstatus.Text = "Activo";
            this.chEstatus.UseVisualStyleBackColor = true;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(160, 96);
            this.txNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(506, 31);
            this.txNombre.TabIndex = 5;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(424, 215);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(150, 44);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(208, 215);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(150, 44);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgvFallas
            // 
            this.dgvFallas.AllowUserToAddRows = false;
            this.dgvFallas.AllowUserToDeleteRows = false;
            this.dgvFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFallas.Location = new System.Drawing.Point(28, 152);
            this.dgvFallas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvFallas.Name = "dgvFallas";
            this.dgvFallas.ReadOnly = true;
            this.dgvFallas.RowHeadersWidth = 82;
            this.dgvFallas.Size = new System.Drawing.Size(824, 294);
            this.dgvFallas.TabIndex = 4;
            this.dgvFallas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubFallas_CellContentDoubleClick);
            // 
            // btNewSubFalla
            // 
            this.btNewSubFalla.Image = global::CDURechazos.Properties.Resources._1486564407_plus_green_81521;
            this.btNewSubFalla.Location = new System.Drawing.Point(16, 15);
            this.btNewSubFalla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btNewSubFalla.Name = "btNewSubFalla";
            this.btNewSubFalla.Size = new System.Drawing.Size(84, 81);
            this.btNewSubFalla.TabIndex = 3;
            this.btNewSubFalla.UseVisualStyleBackColor = true;
            this.btNewSubFalla.Click += new System.EventHandler(this.btNewSubFalla_Click);
            // 
            // cboFallasFiltro
            // 
            this.cboFallasFiltro.FormattingEnabled = true;
            this.cboFallasFiltro.Location = new System.Drawing.Point(96, 108);
            this.cboFallasFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFallasFiltro.Name = "cboFallasFiltro";
            this.cboFallasFiltro.Size = new System.Drawing.Size(384, 33);
            this.cboFallasFiltro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Falla:";
            // 
            // frmSubFallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFallasFiltro);
            this.Controls.Add(this.gbSubFalla);
            this.Controls.Add(this.dgvFallas);
            this.Controls.Add(this.btNewSubFalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubFallas";
            this.Text = "SubFallas";
            this.Load += new System.EventHandler(this.frmSubFallas_Load);
            this.gbSubFalla.ResumeLayout(false);
            this.gbSubFalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSubFalla;
        private System.Windows.Forms.CheckBox chEstatus;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DataGridView dgvFallas;
        private System.Windows.Forms.Button btNewSubFalla;
        private System.Windows.Forms.ComboBox cboFallasFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFallas;
    }
}