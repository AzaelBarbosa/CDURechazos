namespace CDURechazos
{
    partial class frmEditarRegistro
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
            this.txSerie = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFalla = new System.Windows.Forms.ComboBox();
            this.cboSubfalla = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txComentario = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie:";
            // 
            // txSerie
            // 
            this.txSerie.Location = new System.Drawing.Point(85, 20);
            this.txSerie.Name = "txSerie";
            this.txSerie.Size = new System.Drawing.Size(317, 22);
            this.txSerie.TabIndex = 1;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(85, 55);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(317, 22);
            this.txCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(85, 91);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(317, 22);
            this.txNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Falla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sub Falla:";
            // 
            // cboFalla
            // 
            this.cboFalla.FormattingEnabled = true;
            this.cboFalla.Location = new System.Drawing.Point(85, 126);
            this.cboFalla.Name = "cboFalla";
            this.cboFalla.Size = new System.Drawing.Size(219, 24);
            this.cboFalla.TabIndex = 8;
            this.cboFalla.SelectedIndexChanged += new System.EventHandler(this.cboFalla_SelectedIndexChanged);
            // 
            // cboSubfalla
            // 
            this.cboSubfalla.FormattingEnabled = true;
            this.cboSubfalla.Location = new System.Drawing.Point(85, 160);
            this.cboSubfalla.Name = "cboSubfalla";
            this.cboSubfalla.Size = new System.Drawing.Size(219, 24);
            this.cboSubfalla.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre:";
            // 
            // txComentario
            // 
            this.txComentario.Location = new System.Drawing.Point(85, 195);
            this.txComentario.Multiline = true;
            this.txComentario.Name = "txComentario";
            this.txComentario.Size = new System.Drawing.Size(445, 116);
            this.txComentario.TabIndex = 11;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(455, 323);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(365, 323);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 12;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // frmEditarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 358);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txComentario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSubfalla);
            this.Controls.Add(this.cboFalla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txSerie);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarRegistro";
            this.Text = "frmEditarRegistro";
            this.Load += new System.EventHandler(this.frmEditarRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSerie;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFalla;
        private System.Windows.Forms.ComboBox cboSubfalla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txComentario;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}