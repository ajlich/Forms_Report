namespace DLWMS.WinForms.IspitIB200199
{
    partial class frmPretragaIB200199
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.brojIndeksaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeprez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brPoloz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime/Prezime/Indeks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spol:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(175, 24);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(342, 27);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(571, 23);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(185, 28);
            this.cmbSpol.TabIndex = 3;
            this.cmbSpol.SelectedIndexChanged += new System.EventHandler(this.cmbSpol_SelectedIndexChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToDeleteRows = false;
            this.dgvPretraga.AutoGenerateColumns = false;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojIndeksaDataGridViewTextBoxColumn,
            this.imeprez,
            this.spolDataGridViewTextBoxColumn,
            this.brPoloz,
            this.poruke});
            this.dgvPretraga.DataSource = this.studentBindingSource;
            this.dgvPretraga.Location = new System.Drawing.Point(28, 53);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            this.dgvPretraga.RowHeadersWidth = 51;
            this.dgvPretraga.RowTemplate.Height = 29;
            this.dgvPretraga.Size = new System.Drawing.Size(728, 285);
            this.dgvPretraga.TabIndex = 4;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // brojIndeksaDataGridViewTextBoxColumn
            // 
            this.brojIndeksaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brojIndeksaDataGridViewTextBoxColumn.DataPropertyName = "BrojIndeksa";
            this.brojIndeksaDataGridViewTextBoxColumn.HeaderText = "BrojIndeksa";
            this.brojIndeksaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojIndeksaDataGridViewTextBoxColumn.Name = "brojIndeksaDataGridViewTextBoxColumn";
            this.brojIndeksaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeprez
            // 
            this.imeprez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeprez.DataPropertyName = "ImePrezime";
            this.imeprez.HeaderText = "Ime i prezime";
            this.imeprez.MinimumWidth = 6;
            this.imeprez.Name = "imeprez";
            this.imeprez.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "Spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brPoloz
            // 
            this.brPoloz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brPoloz.DataPropertyName = "BrojPolozenih";
            this.brPoloz.HeaderText = "Broj polozenih";
            this.brPoloz.MinimumWidth = 6;
            this.brPoloz.Name = "brPoloz";
            this.brPoloz.ReadOnly = true;
            // 
            // poruke
            // 
            this.poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.poruke.DataPropertyName = "Id";
            this.poruke.HeaderText = "";
            this.poruke.MinimumWidth = 6;
            this.poruke.Name = "poruke";
            this.poruke.ReadOnly = true;
            this.poruke.Text = "Poruke";
            this.poruke.ToolTipText = "Poruke";
            this.poruke.UseColumnTextForButtonValue = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DLWMS.Data.Student);
            // 
            // frmPretragaIB200199
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 358);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB200199";
            this.Text = "frmPretragaIB200199";
            this.Load += new System.EventHandler(this.frmPretragaIB200199_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPretraga;
        private ComboBox cmbSpol;
        private DataGridView dgvPretraga;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn brojIndeksaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imeprez;
        private DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brPoloz;
        private DataGridViewButtonColumn poruke;
    }
}