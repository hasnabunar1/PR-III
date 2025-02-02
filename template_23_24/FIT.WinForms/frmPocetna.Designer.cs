namespace FIT.WinForms
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnIzvjestaj = new Button();
            btnIspit = new Button();
            label1 = new Label();
            btnDrzave = new Button();
            btnPretraga = new Button();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 15F);
            lblKonekcijaInfo.Location = new Point(114, 96);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 35);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(154, 13);
            btnIzvjestaj.Margin = new Padding(3, 4, 3, 4);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(207, 31);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // btnIspit
            // 
            btnIspit.Location = new Point(422, 204);
            btnIspit.Name = "btnIspit";
            btnIspit.Size = new Size(80, 29);
            btnIspit.TabIndex = 2;
            btnIspit.Text = "Ispit";
            btnIspit.UseVisualStyleBackColor = true;
            btnIspit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 182);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 3;
            label1.Text = "jul";
            // 
            // btnDrzave
            // 
            btnDrzave.Location = new Point(0, 204);
            btnDrzave.Name = "btnDrzave";
            btnDrzave.Size = new Size(148, 29);
            btnDrzave.TabIndex = 4;
            btnDrzave.Text = "Drzave i gradovi";
            btnDrzave.UseVisualStyleBackColor = true;
            btnDrzave.Click += button1_Click_1;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(0, 173);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(148, 29);
            btnPretraga.TabIndex = 5;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 245);
            Controls.Add(btnPretraga);
            Controls.Add(btnDrzave);
            Controls.Add(label1);
            Controls.Add(btnIspit);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblKonekcijaInfo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
        private Button btnIspit;
        private Label label1;
        private Button btnDrzave;
        private Button btnPretraga;
    }
}