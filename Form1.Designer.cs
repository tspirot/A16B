namespace A16B
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxIzlozba = new System.Windows.Forms.ComboBox();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBoxPas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 533);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonZatvori);
            this.tabPage1.Controls.Add(this.buttonPrijava);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboBoxIzlozba);
            this.tabPage1.Controls.Add(this.comboBoxKategorija);
            this.tabPage1.Controls.Add(this.comboBoxPas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unesi prijavu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Zatvori aplikaciju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prijava";
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.BackgroundImage = global::A16B.Properties.Resources.zatvori;
            this.buttonZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonZatvori.Location = new System.Drawing.Point(184, 154);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(76, 77);
            this.buttonZatvori.TabIndex = 19;
            this.buttonZatvori.UseVisualStyleBackColor = true;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackgroundImage = global::A16B.Properties.Resources.dodaj;
            this.buttonPrijava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrijava.Location = new System.Drawing.Point(53, 154);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(76, 77);
            this.buttonPrijava.TabIndex = 18;
            this.buttonPrijava.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A16B.Properties.Resources.pasmacka;
            this.pictureBox1.Location = new System.Drawing.Point(498, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxIzlozba
            // 
            this.comboBoxIzlozba.FormattingEnabled = true;
            this.comboBoxIzlozba.Location = new System.Drawing.Point(125, 61);
            this.comboBoxIzlozba.Name = "comboBoxIzlozba";
            this.comboBoxIzlozba.Size = new System.Drawing.Size(316, 24);
            this.comboBoxIzlozba.TabIndex = 16;
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(125, 96);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(183, 24);
            this.comboBoxKategorija.TabIndex = 15;
            // 
            // comboBoxPas
            // 
            this.comboBoxPas.FormattingEnabled = true;
            this.comboBoxPas.Location = new System.Drawing.Point(125, 27);
            this.comboBoxPas.Name = "comboBoxPas";
            this.comboBoxPas.Size = new System.Drawing.Size(183, 24);
            this.comboBoxPas.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Izložba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pas";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(983, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "O aplikaciji";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(983, 615);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Izlaz";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Prijava na izlozbu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxIzlozba;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

