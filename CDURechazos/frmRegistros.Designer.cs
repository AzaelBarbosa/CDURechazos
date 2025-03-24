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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(12, 101);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 82;
            this.dgvRegistros.Size = new System.Drawing.Size(941, 373);
            this.dgvRegistros.TabIndex = 1;
            this.dgvRegistros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Serie:";
            // 
            // txSerie
            // 
            this.txSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSerie.Location = new System.Drawing.Point(76, 68);
            this.txSerie.Name = "txSerie";
            this.txSerie.Size = new System.Drawing.Size(249, 24);
            this.txSerie.TabIndex = 4;
            // 
            // btnuevo
            // 
            this.btnuevo.Image = global::CDURechazos.Properties.Resources._1486564407_plus_green_81521;
            this.btnuevo.Location = new System.Drawing.Point(15, 12);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(42, 42);
            this.btnuevo.TabIndex = 5;
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 486);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.txSerie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistros);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistros";
            this.Text = "frmRegistros";
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSerie;
        private System.Windows.Forms.Button btnuevo;
    }
}