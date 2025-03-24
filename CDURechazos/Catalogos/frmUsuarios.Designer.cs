namespace CDURechazos.Catalogos
{
    partial class frmUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.chResetear = new System.Windows.Forms.CheckBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chEstatus = new System.Windows.Forms.CheckBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 51);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 82;
            this.dgvUsuarios.Size = new System.Drawing.Size(738, 222);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentDoubleClick);
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.chResetear);
            this.gbUsuarios.Controls.Add(this.cboPerfil);
            this.gbUsuarios.Controls.Add(this.label5);
            this.gbUsuarios.Controls.Add(this.chEstatus);
            this.gbUsuarios.Controls.Add(this.txNombre);
            this.gbUsuarios.Controls.Add(this.txUsuario);
            this.gbUsuarios.Controls.Add(this.label2);
            this.gbUsuarios.Controls.Add(this.label1);
            this.gbUsuarios.Controls.Add(this.btCancelar);
            this.gbUsuarios.Controls.Add(this.btAceptar);
            this.gbUsuarios.Location = new System.Drawing.Point(14, 289);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(515, 141);
            this.gbUsuarios.TabIndex = 1;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Alta Usuario";
            // 
            // chResetear
            // 
            this.chResetear.AutoSize = true;
            this.chResetear.Location = new System.Drawing.Point(383, 59);
            this.chResetear.Name = "chResetear";
            this.chResetear.Size = new System.Drawing.Size(126, 17);
            this.chResetear.TabIndex = 20;
            this.chResetear.Text = "Resetear Contraseña";
            this.chResetear.UseVisualStyleBackColor = true;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(112, 82);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(255, 21);
            this.cboPerfil.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Perfil:";
            // 
            // chEstatus
            // 
            this.chEstatus.AutoSize = true;
            this.chEstatus.Location = new System.Drawing.Point(383, 32);
            this.chEstatus.Name = "chEstatus";
            this.chEstatus.Size = new System.Drawing.Size(56, 17);
            this.chEstatus.TabIndex = 13;
            this.chEstatus.Text = "Activo";
            this.chEstatus.UseVisualStyleBackColor = true;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(112, 56);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(255, 20);
            this.txNombre.TabIndex = 12;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(112, 30);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(255, 20);
            this.txUsuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Completo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario;";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(434, 112);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(344, 112);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 7;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Image = global::CDURechazos.Properties.Resources._1486564407_plus_green_81521;
            this.btnuevo.Location = new System.Drawing.Point(12, 4);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(42, 42);
            this.btnuevo.TabIndex = 2;
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 439);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.CheckBox chEstatus;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chResetear;
    }
}