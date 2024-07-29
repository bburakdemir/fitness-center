namespace FitnessCenter
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.PzamanlamaCb = new System.Windows.Forms.ComboBox();
            this.PsporturuCb = new System.Windows.Forms.ComboBox();
            this.PcinsiyetCb = new System.Windows.Forms.ComboBox();
            this.PtelnoTb = new System.Windows.Forms.TextBox();
            this.PyasTb = new System.Windows.Forms.TextBox();
            this.PadSoyadTb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 134);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(413, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 27);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Yeni Personel Ekle";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox6.Location = new System.Drawing.Point(389, 48);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(259, 42);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Fitness Center";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Red;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox12.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox12.Location = new System.Drawing.Point(159, 388);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(794, 29);
            this.textBox12.TabIndex = 47;
            this.textBox12.Text = "Lütfen telefon numarasını başında \"0\" olmadan giriniz!(Örn; 5XX XXX XX XX)";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PzamanlamaCb
            // 
            this.PzamanlamaCb.FormattingEnabled = true;
            this.PzamanlamaCb.Items.AddRange(new object[] {
            "08.00-11.00",
            "11.00-14.00",
            "14.00-17.00",
            "17.00-21.00",
            "21.00-23.00"});
            this.PzamanlamaCb.Location = new System.Drawing.Point(563, 305);
            this.PzamanlamaCb.Name = "PzamanlamaCb";
            this.PzamanlamaCb.Size = new System.Drawing.Size(158, 24);
            this.PzamanlamaCb.TabIndex = 46;
            // 
            // PsporturuCb
            // 
            this.PsporturuCb.FormattingEnabled = true;
            this.PsporturuCb.Items.AddRange(new object[] {
            "Fitness",
            "Muaythai",
            "Boks",
            "Güreş",
            "Bilek Güreşi",
            "Powerlifting"});
            this.PsporturuCb.Location = new System.Drawing.Point(565, 240);
            this.PsporturuCb.Name = "PsporturuCb";
            this.PsporturuCb.Size = new System.Drawing.Size(156, 24);
            this.PsporturuCb.TabIndex = 45;
            // 
            // PcinsiyetCb
            // 
            this.PcinsiyetCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Kadın",
            "Erkek"});
            this.PcinsiyetCb.FormattingEnabled = true;
            this.PcinsiyetCb.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.PcinsiyetCb.Location = new System.Drawing.Point(328, 305);
            this.PcinsiyetCb.Name = "PcinsiyetCb";
            this.PcinsiyetCb.Size = new System.Drawing.Size(156, 24);
            this.PcinsiyetCb.TabIndex = 44;
            // 
            // PtelnoTb
            // 
            this.PtelnoTb.Location = new System.Drawing.Point(566, 171);
            this.PtelnoTb.Multiline = true;
            this.PtelnoTb.Name = "PtelnoTb";
            this.PtelnoTb.Size = new System.Drawing.Size(155, 27);
            this.PtelnoTb.TabIndex = 43;
            // 
            // PyasTb
            // 
            this.PyasTb.Location = new System.Drawing.Point(328, 237);
            this.PyasTb.Multiline = true;
            this.PyasTb.Name = "PyasTb";
            this.PyasTb.Size = new System.Drawing.Size(155, 27);
            this.PyasTb.TabIndex = 42;
            // 
            // PadSoyadTb
            // 
            this.PadSoyadTb.Location = new System.Drawing.Point(328, 171);
            this.PadSoyadTb.Multiline = true;
            this.PadSoyadTb.Name = "PadSoyadTb";
            this.PadSoyadTb.Size = new System.Drawing.Size(155, 27);
            this.PadSoyadTb.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(446, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 47);
            this.button3.TabIndex = 40;
            this.button3.Text = "Ana sayfa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(541, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 44);
            this.button2.TabIndex = 39;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(379, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 38;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox8.Location = new System.Drawing.Point(563, 272);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 27);
            this.textBox8.TabIndex = 37;
            this.textBox8.Text = "Zamanlama";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox7.Location = new System.Drawing.Point(581, 204);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(123, 27);
            this.textBox7.TabIndex = 36;
            this.textBox7.Text = "Spor Türü";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox5.Location = new System.Drawing.Point(550, 138);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 27);
            this.textBox5.TabIndex = 35;
            this.textBox5.Text = "Telefon Numarası";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox4.Location = new System.Drawing.Point(353, 272);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 27);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "Cinsiyet";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox3.Location = new System.Drawing.Point(379, 204);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 27);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "Yaş";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Location = new System.Drawing.Point(328, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 27);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "Ad Soyad";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(989, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 39);
            this.button10.TabIndex = 51;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 600);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.PzamanlamaCb);
            this.Controls.Add(this.PsporturuCb);
            this.Controls.Add(this.PcinsiyetCb);
            this.Controls.Add(this.PtelnoTb);
            this.Controls.Add(this.PyasTb);
            this.Controls.Add(this.PadSoyadTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ComboBox PzamanlamaCb;
        private System.Windows.Forms.ComboBox PsporturuCb;
        private System.Windows.Forms.ComboBox PcinsiyetCb;
        private System.Windows.Forms.TextBox PtelnoTb;
        private System.Windows.Forms.TextBox PyasTb;
        private System.Windows.Forms.TextBox PadSoyadTb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
    }
}