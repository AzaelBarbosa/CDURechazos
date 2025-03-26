namespace CDURechazos
{
    partial class frmRegistros
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
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txSerie = new System.Windows.Forms.TextBox();
            this.btnuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRango = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.lbFechaFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(24, 194);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 82;
            this.dgvRegistros.Size = new System.Drawing.Size(1882, 717);
            this.dgvRegistros.TabIndex = 1;
            this.dgvRegistros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Serie:";
            // 
            // txSerie
            // 
            this.txSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSerie.Location = new System.Drawing.Point(152, 131);
            this.txSerie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txSerie.Name = "txSerie";
            this.txSerie.Size = new System.Drawing.Size(494, 41);
            this.txSerie.TabIndex = 4;
            this.txSerie.TextChanged += new System.EventHandler(this.txSerie_TextChanged);
            // 
            // btnuevo
            // 
            this.btnuevo.Image = global::CDURechazos.Properties.Resources._1486564407_plus_green_81521;
            this.btnuevo.Location = new System.Drawing.Point(30, 23);
            this.btnuevo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(84, 81);
            this.btnuevo.TabIndex = 5;
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRango);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.Controls.Add(this.lbFechaFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFechaFinal);
            this.groupBox1.Controls.Add(this.dtFechaInicial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(730, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(722, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbRango
            // 
            this.rbRango.AutoSize = true;
            this.rbRango.Location = new System.Drawing.Point(426, 21);
            this.rbRango.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbRango.Name = "rbRango";
            this.rbRango.Size = new System.Drawing.Size(210, 34);
            this.rbRango.TabIndex = 7;
            this.rbRango.Text = "Rango Fechas";
            this.rbRango.UseVisualStyleBackColor = true;
            this.rbRango.CheckedChanged += new System.EventHandler(this.rbRango_CheckedChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Checked = true;
            this.rbFecha.Location = new System.Drawing.Point(18, 21);
            this.rbFecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(153, 34);
            this.rbFecha.TabIndex = 6;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Por fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // lbFechaFinal
            // 
            this.lbFechaFinal.AutoSize = true;
            this.lbFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFinal.Location = new System.Drawing.Point(420, 65);
            this.lbFechaFinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFechaFinal.Name = "lbFechaFinal";
            this.lbFechaFinal.Size = new System.Drawing.Size(178, 36);
            this.lbFechaFinal.TabIndex = 5;
            this.lbFechaFinal.Text = "Fecha Final:";
            this.lbFechaFinal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Inicial:";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(426, 106);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(280, 37);
            this.dtFechaFinal.TabIndex = 1;
            this.dtFechaFinal.Visible = false;
            this.dtFechaFinal.ValueChanged += new System.EventHandler(this.dtFechaFinal_ValueChanged);
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(12, 106);
            this.dtFechaInicial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(280, 37);
            this.dtFechaInicial.TabIndex = 0;
            this.dtFechaInicial.ValueChanged += new System.EventHandler(this.dtFechaInicial_ValueChanged);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 935);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.txSerie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistros";
            this.Text = "frmRegistros";
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSerie;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRango;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.Label lbFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
    }
}