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
            pbzastavaGr = new PictureBox();
            label1 = new Label();
            lblNazNovG = new Label();
            tbGrad = new TextBox();
            btnDodaj = new Button();
            dgvDodaj = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromjenaStatusa = new DataGridViewButtonColumn();
            gbGenerator = new GroupBox();
            tbInfo = new TextBox();
            btnGenerisi = new Button();
            cbStatus = new CheckBox();
            tbBroj = new TextBox();
            label3 = new Label();
            lblBrojGradova = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbzastavaGr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDodaj).BeginInit();
            gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbzastavaGr
            // 
            pbzastavaGr.Location = new Point(12, 12);
            pbzastavaGr.Name = "pbzastavaGr";
            pbzastavaGr.Size = new Size(125, 83);
            pbzastavaGr.SizeMode = PictureBoxSizeMode.StretchImage;
            pbzastavaGr.TabIndex = 0;
            pbzastavaGr.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 36);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // lblNazNovG
            // 
            lblNazNovG.AutoSize = true;
            lblNazNovG.Location = new Point(12, 119);
            lblNazNovG.Name = "lblNazNovG";
            lblNazNovG.Size = new Size(188, 20);
            lblNazNovG.TabIndex = 2;
            lblNazNovG.Text = "Unesite naziv novog grada:";
            // 
            // tbGrad
            // 
            tbGrad.Location = new Point(206, 119);
            tbGrad.Name = "tbGrad";
            tbGrad.Size = new Size(298, 27);
            tbGrad.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(548, 125);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvDodaj
            // 
            dgvDodaj.AllowUserToAddRows = false;
            dgvDodaj.AllowUserToDeleteRows = false;
            dgvDodaj.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDodaj.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromjenaStatusa });
            dgvDodaj.Location = new Point(12, 160);
            dgvDodaj.Name = "dgvDodaj";
            dgvDodaj.ReadOnly = true;
            dgvDodaj.RowHeadersWidth = 51;
            dgvDodaj.RowTemplate.Height = 29;
            dgvDodaj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDodaj.Size = new Size(630, 188);
            dgvDodaj.TabIndex = 5;
            dgvDodaj.CellClick += dgvDodaj_CellClick;
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
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PromjenaStatusa
            // 
            PromjenaStatusa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromjenaStatusa.HeaderText = "";
            PromjenaStatusa.MinimumWidth = 6;
            PromjenaStatusa.Name = "PromjenaStatusa";
            PromjenaStatusa.ReadOnly = true;
            PromjenaStatusa.Resizable = DataGridViewTriState.False;
            PromjenaStatusa.Text = "Promjeni status";
            PromjenaStatusa.UseColumnTextForButtonValue = true;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(tbInfo);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(cbStatus);
            gbGenerator.Controls.Add(tbBroj);
            gbGenerator.Controls.Add(label3);
            gbGenerator.Controls.Add(lblBrojGradova);
            gbGenerator.Location = new Point(12, 367);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(630, 199);
            gbGenerator.TabIndex = 6;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 94);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(618, 99);
            tbInfo.TabIndex = 5;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(237, 39);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(151, 42);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 3;
            cbStatus.Text = "Aktivan";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // tbBroj
            // 
            tbBroj.Location = new Point(104, 39);
            tbBroj.Name = "tbBroj";
            tbBroj.Size = new Size(41, 27);
            tbBroj.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 1;
            label3.Text = "Info:";
            // 
            // lblBrojGradova
            // 
            lblBrojGradova.AutoSize = true;
            lblBrojGradova.Location = new Point(0, 42);
            lblBrojGradova.Name = "lblBrojGradova";
            lblBrojGradova.Size = new Size(98, 20);
            lblBrojGradova.TabIndex = 0;
            lblBrojGradova.Text = "Broj gradova:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGradovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 583);
            Controls.Add(gbGenerator);
            Controls.Add(dgvDodaj);
            Controls.Add(btnDodaj);
            Controls.Add(tbGrad);
            Controls.Add(lblNazNovG);
            Controls.Add(label1);
            Controls.Add(pbzastavaGr);
            Name = "frmGradovi";
            Text = "frmGradovi";
            ((System.ComponentModel.ISupportInitialize)pbzastavaGr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDodaj).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbzastavaGr;
        private Label label1;
        private Label lblNazNovG;
        private TextBox tbGrad;
        private Button btnDodaj;
        private DataGridView dgvDodaj;
        private GroupBox gbGenerator;
        private Label label3;
        private Label lblBrojGradova;
        private TextBox tbInfo;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private TextBox tbBroj;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromjenaStatusa;
    }
}