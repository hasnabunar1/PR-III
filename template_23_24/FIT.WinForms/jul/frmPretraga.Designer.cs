namespace FIT.WinForms.jul
{
    partial class frmPretraga
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
            lblSpol = new Label();
            lblRodjen = new Label();
            lblDo = new Label();
            cmbSpol = new ComboBox();
            dtOd = new DateTimePicker();
            dtDo = new DateTimePicker();
            dgvPretraga = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // lblSpol
            // 
            lblSpol.AutoSize = true;
            lblSpol.Location = new Point(2, 20);
            lblSpol.Name = "lblSpol";
            lblSpol.Size = new Size(39, 20);
            lblSpol.TabIndex = 0;
            lblSpol.Text = "Spol";
            // 
            // lblRodjen
            // 
            lblRodjen.AutoSize = true;
            lblRodjen.Location = new Point(204, 20);
            lblRodjen.Name = "lblRodjen";
            lblRodjen.Size = new Size(138, 20);
            lblRodjen.TabIndex = 1;
            lblRodjen.Text = "rođen u periodu od";
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(604, 20);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(27, 20);
            lblDo.TabIndex = 2;
            lblDo.Text = "do";
            // 
            // cmbSpol
            // 
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(47, 17);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(151, 28);
            cmbSpol.TabIndex = 3;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            cmbSpol.SelectionChangeCommitted += cmbSpol_SelectionChangeCommitted;
            // 
            // dtOd
            // 
            dtOd.Location = new Point(348, 15);
            dtOd.Name = "dtOd";
            dtOd.Size = new Size(250, 27);
            dtOd.TabIndex = 4;
            // 
            // dtDo
            // 
            dtDo.Location = new Point(637, 15);
            dtDo.Name = "dtDo";
            dtDo.Size = new Size(250, 27);
            dtDo.TabIndex = 5;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
            dgvPretraga.Location = new Point(12, 51);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(871, 297);
            dgvPretraga.TabIndex = 6;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Broj indeksa";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodjenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 362);
            Controls.Add(dgvPretraga);
            Controls.Add(dtDo);
            Controls.Add(dtOd);
            Controls.Add(cmbSpol);
            Controls.Add(lblDo);
            Controls.Add(lblRodjen);
            Controls.Add(lblSpol);
            Name = "frmPretraga";
            Text = "frmPretraga";
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSpol;
        private Label lblRodjen;
        private Label lblDo;
        private ComboBox cmbSpol;
        private DateTimePicker dtOd;
        private DateTimePicker dtDo;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}