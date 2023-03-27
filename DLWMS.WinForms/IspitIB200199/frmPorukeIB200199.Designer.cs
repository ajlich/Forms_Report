namespace DLWMS.WinForms.IspitIB200199
{
    partial class frmPorukeIB200199
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadrzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentPorukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNova = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPorukaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poruke studenta:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(145, 22);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(73, 20);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "STUDENT";
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.AutoGenerateColumns = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.predmetDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.sadrzajDataGridViewTextBoxColumn,
            this.slikaDataGridViewImageColumn,
            this.brisi});
            this.dgvPoruke.DataSource = this.studentPorukaBindingSource;
            this.dgvPoruke.Location = new System.Drawing.Point(22, 55);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowHeadersWidth = 51;
            this.dgvPoruke.RowTemplate.Height = 29;
            this.dgvPoruke.Size = new System.Drawing.Size(705, 291);
            this.dgvPoruke.TabIndex = 2;
            this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            this.predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sadrzajDataGridViewTextBoxColumn
            // 
            this.sadrzajDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sadrzajDataGridViewTextBoxColumn.DataPropertyName = "Sadrzaj";
            this.sadrzajDataGridViewTextBoxColumn.HeaderText = "Sadrzaj";
            this.sadrzajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sadrzajDataGridViewTextBoxColumn.Name = "sadrzajDataGridViewTextBoxColumn";
            this.sadrzajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Slika";
            this.slikaDataGridViewImageColumn.MinimumWidth = 6;
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            this.slikaDataGridViewImageColumn.ReadOnly = true;
            // 
            // brisi
            // 
            this.brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brisi.DataPropertyName = "Id";
            this.brisi.HeaderText = "";
            this.brisi.MinimumWidth = 6;
            this.brisi.Name = "brisi";
            this.brisi.ReadOnly = true;
            this.brisi.Text = "Briši";
            this.brisi.ToolTipText = "Briši";
            this.brisi.UseColumnTextForButtonValue = true;
            // 
            // studentPorukaBindingSource
            // 
            this.studentPorukaBindingSource.DataSource = typeof(DLWMS.Data.IspitIB200199.StudentPoruka);
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(605, 22);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(122, 27);
            this.btnNova.TabIndex = 3;
            this.btnNova.Text = "Nova poruka";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(622, 352);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(105, 29);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmPorukeIB200199
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 399);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmPorukeIB200199";
            this.Text = "frmPorukeIB200199";
            this.Load += new System.EventHandler(this.frmPorukeIB200199_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPorukaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private DataGridView dgvPoruke;
        private BindingSource studentPorukaBindingSource;
        private Button btnNova;
        private Button btnPrintaj;
        private DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sadrzajDataGridViewTextBoxColumn;
        private DataGridViewImageColumn slikaDataGridViewImageColumn;
        private DataGridViewButtonColumn brisi;
    }
}