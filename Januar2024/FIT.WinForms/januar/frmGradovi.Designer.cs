namespace FIT.WinForms.januar
{
    partial class frmGradovi
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
            components = new System.ComponentModel.Container();
            pbZastava = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbNaziv = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            promijeni = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            cbStatus = new CheckBox();
            btnGenerisi = new Button();
            tbInfo = new TextBox();
            tbBroj = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(203, 108);
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 48);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 123);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 2;
            label2.Text = "unesite naziv novog grada";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(210, 126);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(198, 27);
            tbNaziv.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(440, 124);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, promijeni });
            dgvGradovi.Location = new Point(12, 159);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.Size = new Size(522, 188);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellClick += dgvGradovi_CellClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan ";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // promijeni
            // 
            promijeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            promijeni.HeaderText = "";
            promijeni.MinimumWidth = 6;
            promijeni.Name = "promijeni";
            promijeni.ReadOnly = true;
            promijeni.Text = "Promijeni status";
            promijeni.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(tbBroj);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 189);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(183, 31);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Aktivan";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(374, 28);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(13, 64);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(503, 119);
            tbInfo.TabIndex = 2;
            // 
            // tbBroj
            // 
            tbBroj.Location = new Point(117, 26);
            tbBroj.Name = "tbBroj";
            tbBroj.Size = new Size(51, 27);
            tbBroj.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 32);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 0;
            label3.Text = "Broj gradova:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGradovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 547);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(tbNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Name = "frmGradovi";
            Text = "frmGradovi";
            Load += frmGradovi_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label label1;
        private Label label2;
        private TextBox tbNaziv;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private GroupBox groupBox1;
        private CheckBox cbStatus;
        private Button btnGenerisi;
        private TextBox tbInfo;
        private TextBox tbBroj;
        private Label label3;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn promijeni;
    }
}