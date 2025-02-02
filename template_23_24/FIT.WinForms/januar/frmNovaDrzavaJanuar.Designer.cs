namespace FIT.WinForms.januar
{
    partial class frmNovaDrzavaJanuar
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
            cbStatus = new CheckBox();
            btnSacuvaj = new Button();
            lblZastava = new Label();
            lblNaziv = new Label();
            tbNaziv = new TextBox();
            pbZastava = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(12, 240);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 0;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(115, 240);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // lblZastava
            // 
            lblZastava.AutoSize = true;
            lblZastava.Location = new Point(12, 9);
            lblZastava.Name = "lblZastava";
            lblZastava.Size = new Size(63, 20);
            lblZastava.TabIndex = 2;
            lblZastava.Text = "Zastava:";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(12, 160);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(49, 20);
            lblNaziv.TabIndex = 3;
            lblNaziv.Text = "Naziv:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(12, 193);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(197, 27);
            tbNaziv.TabIndex = 4;
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 32);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(197, 125);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 5;
            pbZastava.TabStop = false;
            pbZastava.Click += pbZastava_Click;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaDrzavaJanuar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 279);
            Controls.Add(pbZastava);
            Controls.Add(tbNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(lblZastava);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStatus);
            Name = "frmNovaDrzavaJanuar";
            Text = "Podaci o drzavi ";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbStatus;
        private Button btnSacuvaj;
        private Label lblZastava;
        private Label lblNaziv;
        private TextBox tbNaziv;
        private PictureBox pbZastava;
        private ErrorProvider errorProvider1;
    }
}