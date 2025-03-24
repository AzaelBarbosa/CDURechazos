namespace CDURechazos.Catalogos
{
    partial class frmPerfiles
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
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.chEstatus = new System.Windows.Forms.CheckBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.dgvPerfil = new System.Windows.Forms.DataGridView();
            this.btNewPerfil = new System.Windows.Forms.Button();
            this.gbPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPerfil
            // 
            this.gbPerfil.Controls.Add(this.chEstatus);
            this.gbPerfil.Controls.Add(this.txCodigo);
            this.gbPerfil.Controls.Add(this.label1);
            this.gbPerfil.Controls.Add(this.btCancelar);
            this.gbPerfil.Controls.Add(this.btAceptar);
            this.gbPerfil.Location = new System.Drawing.Point(12, 225);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(418, 119);
            this.gbPerfil.TabIndex = 5;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Alta Perfil";
            // 
            // chEstatus
            // 
            this.chEstatus.AutoSize = true;
            this.chEstatus.Location = new System.Drawing.Point(101, 55);
            this.chEstatus.Name = "chEstatus";
            this.chEstatus.Size = new System.Drawing.Size(56, 17);
            this.chEstatus.TabIndex = 6;
            this.chEstatus.Text = "Activo";
            this.chEstatus.UseVisualStyleBackColor = true;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(101, 29);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(170, 20);
            this.txCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(208, 87);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(101, 87);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.AllowUserToAddRows = false;
            this.dgvPerfil.AllowUserToDeleteRows = false;
            this.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfil.Location = new System.Drawing.Point(12, 55);
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.ReadOnly = true;
            this.dgvPerfil.RowHeadersWidth = 82;
            this.dgvPerfil.Size = new System.Drawing.Size(418, 153);
            this.dgvPerfil.TabIndex = 4;
            this.dgvPerfil.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfil_CellContentDoubleClick);
            // 
            // btNewPerfil
            // 
            this.btNewPerfil.Location = new System.Drawing.Point(12, 12);
            this.btNewPerfil.Name = "btNewPerfil";
            this.btNewPerfil.Size = new System.Drawing.Size(43, 37);
            this.btNewPerfil.TabIndex = 3;
            this.btNewPerfil.UseVisualStyleBackColor = true;
            this.btNewPerfil.Click += new System.EventHandler(this.btNewPerfil_Click);
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 351);
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.dgvPerfil);
            this.Controls.Add(this.btNewPerfil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfiles";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.CheckBox chEstatus;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DataGridView dgvPerfil;
        private System.Windows.Forms.Button btNewPerfil;
    }
}