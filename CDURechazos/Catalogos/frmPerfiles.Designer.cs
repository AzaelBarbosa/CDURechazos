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
            this.dgvPerfil = new System.Windows.Forms.DataGridView();
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
            this.gbPerfil.Location = new System.Drawing.Point(24, 433);
            this.gbPerfil.Margin = new System.Windows.Forms.Padding(6);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Padding = new System.Windows.Forms.Padding(6);
            this.gbPerfil.Size = new System.Drawing.Size(836, 229);
            this.gbPerfil.TabIndex = 5;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Alta Perfil";
            // 
            // chEstatus
            // 
            this.chEstatus.AutoSize = true;
            this.chEstatus.Location = new System.Drawing.Point(202, 106);
            this.chEstatus.Margin = new System.Windows.Forms.Padding(6);
            this.chEstatus.Name = "chEstatus";
            this.chEstatus.Size = new System.Drawing.Size(103, 29);
            this.chEstatus.TabIndex = 6;
            this.chEstatus.Text = "Activo";
            this.chEstatus.UseVisualStyleBackColor = true;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(202, 56);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(336, 31);
            this.txCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(674, 173);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(150, 44);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.AllowUserToAddRows = false;
            this.dgvPerfil.AllowUserToDeleteRows = false;
            this.dgvPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfil.Location = new System.Drawing.Point(24, 106);
            this.dgvPerfil.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.ReadOnly = true;
            this.dgvPerfil.RowHeadersWidth = 82;
            this.dgvPerfil.Size = new System.Drawing.Size(836, 294);
            this.dgvPerfil.TabIndex = 4;
            this.dgvPerfil.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfil_CellContentDoubleClick);
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 675);
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.dgvPerfil);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPerfiles";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            this.Controls.SetChildIndex(this.dgvPerfil, 0);
            this.Controls.SetChildIndex(this.gbPerfil, 0);
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.CheckBox chEstatus;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dgvPerfil;
    }
}