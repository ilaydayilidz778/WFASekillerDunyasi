namespace WFASekillerDuyasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LstSekiller = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudYuk = new NumericUpDown();
            label4 = new Label();
            cboTur = new ComboBox();
            label5 = new Label();
            pnlCizim = new Panel();
            pboRenk = new PictureBox();
            label6 = new Label();
            btnEkle = new Button();
            nudGen = new NumericUpDown();
            nudY = new NumericUpDown();
            nudX = new NumericUpDown();
            cdiRenk = new ColorDialog();
            btnRastgeleEkle = new Button();
            btnTemizle = new Button();
            btnAsagi = new Button();
            button2 = new Button();
            btnYukari = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
            SuspendLayout();
            // 
            // LstSekiller
            // 
            LstSekiller.FormattingEnabled = true;
            LstSekiller.ItemHeight = 25;
            LstSekiller.Location = new Point(28, 118);
            LstSekiller.Name = "LstSekiller";
            LstSekiller.Size = new Size(769, 179);
            LstSekiller.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 39);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 39);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 3;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 39);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 5;
            label3.Text = "Genişlik";
            // 
            // nudYuk
            // 
            nudYuk.AutoSize = true;
            nudYuk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudYuk.Location = new Point(343, 74);
            nudYuk.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudYuk.Name = "nudYuk";
            nudYuk.Size = new Size(101, 31);
            nudYuk.TabIndex = 8;
            nudYuk.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 39);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 7;
            label4.Text = "Yükseklik";
            // 
            // cboTur
            // 
            cboTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTur.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboTur.FormattingEnabled = true;
            cboTur.Items.AddRange(new object[] { "Dikdörtgen", "Elips" });
            cboTur.Location = new Point(462, 73);
            cboTur.Margin = new Padding(2);
            cboTur.Name = "cboTur";
            cboTur.Size = new Size(160, 33);
            cboTur.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 39);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 10;
            label5.Text = "Şekil Türü";
            // 
            // pnlCizim
            // 
            pnlCizim.BackColor = Color.White;
            pnlCizim.Location = new Point(28, 311);
            pnlCizim.Margin = new Padding(2);
            pnlCizim.Name = "pnlCizim";
            pnlCizim.Size = new Size(838, 684);
            pnlCizim.TabIndex = 11;
            pnlCizim.Paint += pnlCizim_Paint;
            // 
            // pboRenk
            // 
            pboRenk.BackColor = Color.Black;
            pboRenk.Location = new Point(636, 73);
            pboRenk.Margin = new Padding(2);
            pboRenk.Name = "pboRenk";
            pboRenk.Size = new Size(30, 30);
            pboRenk.TabIndex = 13;
            pboRenk.TabStop = false;
            pboRenk.Click += pboRenk_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(626, 39);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 14;
            label6.Text = "Renk";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(752, 60);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(114, 53);
            btnEkle.TabIndex = 15;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // nudGen
            // 
            nudGen.AutoSize = true;
            nudGen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudGen.Location = new Point(233, 74);
            nudGen.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudGen.Name = "nudGen";
            nudGen.Size = new Size(101, 31);
            nudGen.TabIndex = 16;
            nudGen.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudY
            // 
            nudY.AutoSize = true;
            nudY.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudY.Location = new Point(126, 74);
            nudY.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudY.Name = "nudY";
            nudY.Size = new Size(101, 31);
            nudY.TabIndex = 17;
            // 
            // nudX
            // 
            nudX.AutoSize = true;
            nudX.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudX.Location = new Point(19, 74);
            nudX.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudX.Name = "nudX";
            nudX.Size = new Size(101, 31);
            nudX.TabIndex = 18;
            // 
            // btnRastgeleEkle
            // 
            btnRastgeleEkle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRastgeleEkle.Location = new Point(702, 60);
            btnRastgeleEkle.Margin = new Padding(2);
            btnRastgeleEkle.Name = "btnRastgeleEkle";
            btnRastgeleEkle.Size = new Size(46, 53);
            btnRastgeleEkle.TabIndex = 19;
            btnRastgeleEkle.Text = "?";
            btnRastgeleEkle.UseVisualStyleBackColor = true;
            btnRastgeleEkle.Click += btnRastgeleEkle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTemizle.Location = new Point(28, 1012);
            btnTemizle.Margin = new Padding(2);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(135, 37);
            btnTemizle.TabIndex = 20;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsagi.Location = new Point(802, 239);
            btnAsagi.Margin = new Padding(2);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(64, 59);
            btnAsagi.TabIndex = 21;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(819, 210);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 22;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnYukari.Location = new Point(802, 117);
            btnYukari.Margin = new Padding(2);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(64, 58);
            btnYukari.TabIndex = 23;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(802, 179);
            btnSil.Margin = new Padding(2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(64, 54);
            btnSil.TabIndex = 24;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(176, 1012);
            btnKaydet.Margin = new Padding(2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(135, 37);
            btnKaydet.TabIndex = 25;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 1074);
            Controls.Add(btnKaydet);
            Controls.Add(btnSil);
            Controls.Add(btnYukari);
            Controls.Add(button2);
            Controls.Add(btnAsagi);
            Controls.Add(btnTemizle);
            Controls.Add(btnRastgeleEkle);
            Controls.Add(nudX);
            Controls.Add(nudY);
            Controls.Add(nudGen);
            Controls.Add(btnEkle);
            Controls.Add(label6);
            Controls.Add(pboRenk);
            Controls.Add(pnlCizim);
            Controls.Add(label5);
            Controls.Add(cboTur);
            Controls.Add(nudYuk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LstSekiller);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şekiller Dünyası";
            ((System.ComponentModel.ISupportInitialize)nudYuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSekiller;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudYuk;
        private Label label4;
        private ComboBox cboTur;
        private Label label5;
        private Panel pnlCizim;
        private PictureBox pboRenk;
        private Label label6;
        private Button btnEkle;
        private NumericUpDown nudGen;
        private NumericUpDown nudY;
        private NumericUpDown nudX;
        private ColorDialog cdiRenk;
        private Button btnRastgeleEkle;
        private Button btnTemizle;
        private Button btnAsagi;
        private Button button2;
        private Button btnYukari;
        private Button btnSil;
        private Button btnKaydet;
    }
}