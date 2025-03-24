namespace CDURechazos.Catalogos
{
    partial class frmFallas
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
            this.btNewFalla = new System.Windows.Forms.Button();
            this.dgvFallas = new System.Windows.Forms.DataGridView();
            this.gbFallas = new System.Windows.Forms.GroupBox();
            this.chEstatus = new System.Windows.Forms.CheckBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallas)).BeginInit();
            this.gbFallas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNewFalla
            // 
            this.btNewFalla.Image = global::CDURechazos.Properties.Resources._1486564407_plus_green_81521;
            this.btNewFalla.Location = new System.Drawing.Point(12, 12);
            this.btNewFalla.Name = "btNewFalla";
            this.btNewFalla.Size = new System.Drawing.Size(42, 42);
            this.btNewFalla.TabIndex = 0;
            this.btNewFalla.UseVisualStyleBackColor = true;
            this.btNewFalla.Click += new System.EventHandler(this.btNewFalla_Click);
            // 
            // dgvFallas
            // 
            this.dgvFallas.AllowUserToAddRows = false;
            this.dgvFallas.AllowUserToDeleteRows = false;
            this.dgvFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFallas.Location = new System.Drawing.Point(12, 55);
            this.dgvFallas.Name = "dgvFallas";
            this.dgvFallas.ReadOnly = true;
            this.dgvFallas.RowHeadersWidth = 82;
            this.dgvFallas.Size = new System.Drawing.Size(418, 153);
            this.dgvFallas.TabIndex = 1;
            this.dgvFallas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFallas_CellContentClick);
            this.dgvFallas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFallas_CellContentDoubleClick);
            // 
            // gbFallas
            // 
            this.gbFallas.Controls.Add(this.chEstatus);
            this.gbFallas.Controls.Add(this.txNombre);
            this.gbFallas.Controls.Add(this.txCodigo);
            this.gbFallas.Controls.Add(this.label2);
            this.gbFallas.Controls.Add(this.label1);
            this.gbFallas.Controls.Add(this.btCancelar);
            this.gbFallas.Controls.Add(this.btAceptar);
            this.gbFallas.Location = new System.Drawing.Point(12, 225);
            this.gbFallas.Name = "gbFallas";
            this.gbFallas.Size = new System.Drawing.Size(418, 149);
            this.gbFallas.TabIndex = 2;
            this.gbFallas.TabStop = false;
            this.gbFallas.Text = "Alta Falla";
            // 
            // chEstatus
            // 
            this.chEstatus.AutoSize = true;
            this.chEstatus.Location = new System.Drawing.Point(78, 83);
            this.chEstatus.Name = "chEstatus";
            this.chEstatus.Size = new System.Drawing.Size(56, 17);
            this.chEstatus.TabIndex = 6;
            this.chEstatus.Text = "Activo";
            this.chEstatus.UseVisualStyleBackColor = true;
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(78, 57);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(255, 20);
            this.txNombre.TabIndex = 5;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged);
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(78, 29);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(170, 20);
            this.txCodigo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(211, 120);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(104, 120);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // frmFallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 384);
            this.Controls.Add(this.gbFallas);
            this.Controls.Add(this.dgvFallas);
            this.Controls.Add(this.btNewFalla);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFallas";
            this.Text = "Fallas";
            this.Load += new System.EventHandler(this.frmFallas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallas)).EndInit();
            this.gbFallas.ResumeLayout(false);
            this.gbFallas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewFalla;
        private System.Windows.Forms.DataGridView dgvFallas;
        private System.Windows.Forms.GroupBox gbFallas;
        private System.Windows.Forms.CheckBox chEstatus;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}