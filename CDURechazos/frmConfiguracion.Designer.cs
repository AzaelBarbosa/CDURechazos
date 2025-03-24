namespace CDURechazos
{
    partial class frmConfiguracion
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
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.txContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txBasseDatos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPostgres = new System.Windows.Forms.GroupBox();
            this.txConexionPG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbOtros = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbPG = new System.Windows.Forms.RadioButton();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.gbBase.SuspendLayout();
            this.gbPostgres.SuspendLayout();
            this.gbOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBase
            // 
            this.gbBase.Controls.Add(this.txContra);
            this.gbBase.Controls.Add(this.label4);
            this.gbBase.Controls.Add(this.txUsuario);
            this.gbBase.Controls.Add(this.label3);
            this.gbBase.Controls.Add(this.txBasseDatos);
            this.gbBase.Controls.Add(this.label2);
            this.gbBase.Controls.Add(this.txServidor);
            this.gbBase.Controls.Add(this.label1);
            this.gbBase.Location = new System.Drawing.Point(12, 12);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(519, 165);
            this.gbBase.TabIndex = 0;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Base de Datos SQL";
            // 
            // txContra
            // 
            this.txContra.Location = new System.Drawing.Point(112, 124);
            this.txContra.Name = "txContra";
            this.txContra.Size = new System.Drawing.Size(246, 22);
            this.txContra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(112, 96);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(246, 22);
            this.txUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txBasseDatos
            // 
            this.txBasseDatos.Location = new System.Drawing.Point(112, 64);
            this.txBasseDatos.Name = "txBasseDatos";
            this.txBasseDatos.Size = new System.Drawing.Size(246, 22);
            this.txBasseDatos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de Datos:";
            // 
            // txServidor
            // 
            this.txServidor.Location = new System.Drawing.Point(112, 33);
            this.txServidor.Name = "txServidor";
            this.txServidor.Size = new System.Drawing.Size(246, 22);
            this.txServidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // gbPostgres
            // 
            this.gbPostgres.Controls.Add(this.txConexionPG);
            this.gbPostgres.Controls.Add(this.label8);
            this.gbPostgres.Location = new System.Drawing.Point(12, 183);
            this.gbPostgres.Name = "gbPostgres";
            this.gbPostgres.Size = new System.Drawing.Size(519, 115);
            this.gbPostgres.TabIndex = 8;
            this.gbPostgres.TabStop = false;
            this.gbPostgres.Text = "Base de Datos POSTGRES";
            // 
            // txConexionPG
            // 
            this.txConexionPG.Location = new System.Drawing.Point(112, 33);
            this.txConexionPG.Multiline = true;
            this.txConexionPG.Name = "txConexionPG";
            this.txConexionPG.Size = new System.Drawing.Size(401, 67);
            this.txConexionPG.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "URL Conexion:";
            // 
            // gbOtros
            // 
            this.gbOtros.Controls.Add(this.rbPG);
            this.gbOtros.Controls.Add(this.rbSQL);
            this.gbOtros.Controls.Add(this.label5);
            this.gbOtros.Location = new System.Drawing.Point(12, 305);
            this.gbOtros.Name = "gbOtros";
            this.gbOtros.Size = new System.Drawing.Size(519, 79);
            this.gbOtros.TabIndex = 9;
            this.gbOtros.TabStop = false;
            this.gbOtros.Text = "General";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo Conexion:";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(122, 34);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(51, 20);
            this.rbSQL.TabIndex = 1;
            this.rbSQL.TabStop = true;
            this.rbSQL.Text = "SQL";
            this.rbSQL.UseVisualStyleBackColor = true;
            // 
            // rbPG
            // 
            this.rbPG.AutoSize = true;
            this.rbPG.Location = new System.Drawing.Point(211, 34);
            this.rbPG.Name = "rbPG";
            this.rbPG.Size = new System.Drawing.Size(79, 20);
            this.rbPG.TabIndex = 2;
            this.rbPG.TabStop = true;
            this.rbPG.Text = "Postgres";
            this.rbPG.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(456, 390);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(349, 390);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 10;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 420);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbOtros);
            this.Controls.Add(this.gbPostgres);
            this.Controls.Add(this.gbBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracion";
            this.Text = "Configuracion de la Aplicacion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.gbPostgres.ResumeLayout(false);
            this.gbPostgres.PerformLayout();
            this.gbOtros.ResumeLayout(false);
            this.gbOtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.TextBox txContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBasseDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPostgres;
        private System.Windows.Forms.TextBox txConexionPG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbOtros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbPG;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}