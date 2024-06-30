namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHesapla = new Button();
            rbYillik = new RadioButton();
            rbAylik = new RadioButton();
            rbGunluk = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSonuc = new Label();
            txtAnaPara = new TextBox();
            txtFaizOrani = new TextBox();
            txtTarihSayisi = new TextBox();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(50, 139);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(75, 23);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += button1_Click;
            // 
            // rbYillik
            // 
            rbYillik.AutoSize = true;
            rbYillik.Location = new Point(299, 43);
            rbYillik.Name = "rbYillik";
            rbYillik.Size = new Size(50, 19);
            rbYillik.TabIndex = 1;
            rbYillik.TabStop = true;
            rbYillik.Text = "Yıllık";
            rbYillik.UseVisualStyleBackColor = true;
            // 
            // rbAylik
            // 
            rbAylik.AutoSize = true;
            rbAylik.Location = new Point(299, 68);
            rbAylik.Name = "rbAylik";
            rbAylik.Size = new Size(51, 19);
            rbAylik.TabIndex = 2;
            rbAylik.TabStop = true;
            rbAylik.Text = "Aylık";
            rbAylik.UseVisualStyleBackColor = true;
            // 
            // rbGunluk
            // 
            rbGunluk.AutoSize = true;
            rbGunluk.Location = new Point(299, 93);
            rbGunluk.Name = "rbGunluk";
            rbGunluk.Size = new Size(63, 19);
            rbGunluk.TabIndex = 3;
            rbGunluk.TabStop = true;
            rbGunluk.Text = "Günlük";
            rbGunluk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Ana Para";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 73);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Faiz Oranı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 98);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Tarih Sayısı";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(438, 45);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 15);
            lblSonuc.TabIndex = 7;
            // 
            // txtAnaPara
            // 
            txtAnaPara.Location = new Point(143, 37);
            txtAnaPara.Name = "txtAnaPara";
            txtAnaPara.Size = new Size(100, 23);
            txtAnaPara.TabIndex = 8;
            // 
            // txtFaizOrani
            // 
            txtFaizOrani.Location = new Point(143, 66);
            txtFaizOrani.Name = "txtFaizOrani";
            txtFaizOrani.Size = new Size(100, 23);
            txtFaizOrani.TabIndex = 9;
            // 
            // txtTarihSayisi
            // 
            txtTarihSayisi.Location = new Point(143, 95);
            txtTarihSayisi.Name = "txtTarihSayisi";
            txtTarihSayisi.Size = new Size(100, 23);
            txtTarihSayisi.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTarihSayisi);
            Controls.Add(txtFaizOrani);
            Controls.Add(txtAnaPara);
            Controls.Add(lblSonuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbGunluk);
            Controls.Add(rbAylik);
            Controls.Add(rbYillik);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private RadioButton rbYillik;
        private RadioButton rbAylik;
        private RadioButton rbGunluk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSonuc;
        private TextBox txtAnaPara;
        private TextBox txtFaizOrani;
        private TextBox txtTarihSayisi;
    }
}
