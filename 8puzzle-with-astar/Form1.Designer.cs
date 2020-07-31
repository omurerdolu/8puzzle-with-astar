namespace _8tasAStar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.b11 = new System.Windows.Forms.NumericUpDown();
            this.b12 = new System.Windows.Forms.NumericUpDown();
            this.b13 = new System.Windows.Forms.NumericUpDown();
            this.b23 = new System.Windows.Forms.NumericUpDown();
            this.b22 = new System.Windows.Forms.NumericUpDown();
            this.b21 = new System.Windows.Forms.NumericUpDown();
            this.b33 = new System.Windows.Forms.NumericUpDown();
            this.b32 = new System.Windows.Forms.NumericUpDown();
            this.b31 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bKaristir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aKaristir = new System.Windows.Forms.Button();
            this.a21 = new System.Windows.Forms.NumericUpDown();
            this.a11 = new System.Windows.Forms.NumericUpDown();
            this.a12 = new System.Windows.Forms.NumericUpDown();
            this.a13 = new System.Windows.Forms.NumericUpDown();
            this.a22 = new System.Windows.Forms.NumericUpDown();
            this.a23 = new System.Windows.Forms.NumericUpDown();
            this.a31 = new System.Windows.Forms.NumericUpDown();
            this.a32 = new System.Windows.Forms.NumericUpDown();
            this.a33 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coz = new System.Windows.Forms.Button();
            this.c11 = new System.Windows.Forms.Button();
            this.c12 = new System.Windows.Forms.Button();
            this.c13 = new System.Windows.Forms.Button();
            this.c23 = new System.Windows.Forms.Button();
            this.c22 = new System.Windows.Forms.Button();
            this.c21 = new System.Windows.Forms.Button();
            this.c33 = new System.Windows.Forms.Button();
            this.c32 = new System.Windows.Forms.Button();
            this.c31 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.adimlar = new System.Windows.Forms.ListView();
            this.Adım = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.b11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b31)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a33)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(6, 19);
            this.b11.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(31, 20);
            this.b11.TabIndex = 0;
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(43, 19);
            this.b12.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(31, 20);
            this.b12.TabIndex = 1;
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(80, 19);
            this.b13.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(31, 20);
            this.b13.TabIndex = 2;
            // 
            // b23
            // 
            this.b23.Location = new System.Drawing.Point(80, 45);
            this.b23.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(31, 20);
            this.b23.TabIndex = 5;
            // 
            // b22
            // 
            this.b22.Location = new System.Drawing.Point(43, 45);
            this.b22.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(31, 20);
            this.b22.TabIndex = 4;
            // 
            // b21
            // 
            this.b21.Location = new System.Drawing.Point(6, 45);
            this.b21.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(31, 20);
            this.b21.TabIndex = 3;
            // 
            // b33
            // 
            this.b33.Location = new System.Drawing.Point(80, 71);
            this.b33.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b33.Name = "b33";
            this.b33.Size = new System.Drawing.Size(31, 20);
            this.b33.TabIndex = 8;
            // 
            // b32
            // 
            this.b32.Location = new System.Drawing.Point(43, 71);
            this.b32.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b32.Name = "b32";
            this.b32.Size = new System.Drawing.Size(31, 20);
            this.b32.TabIndex = 7;
            // 
            // b31
            // 
            this.b31.Location = new System.Drawing.Point(6, 71);
            this.b31.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.b31.Name = "b31";
            this.b31.Size = new System.Drawing.Size(31, 20);
            this.b31.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bKaristir);
            this.groupBox1.Controls.Add(this.b21);
            this.groupBox1.Controls.Add(this.b11);
            this.groupBox1.Controls.Add(this.b12);
            this.groupBox1.Controls.Add(this.b13);
            this.groupBox1.Controls.Add(this.b22);
            this.groupBox1.Controls.Add(this.b23);
            this.groupBox1.Controls.Add(this.b31);
            this.groupBox1.Controls.Add(this.b32);
            this.groupBox1.Controls.Add(this.b33);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAŞLANGIÇ";
            // 
            // bKaristir
            // 
            this.bKaristir.Location = new System.Drawing.Point(23, 104);
            this.bKaristir.Name = "bKaristir";
            this.bKaristir.Size = new System.Drawing.Size(75, 23);
            this.bKaristir.TabIndex = 21;
            this.bKaristir.Text = "RASTGELE";
            this.bKaristir.UseVisualStyleBackColor = true;
            this.bKaristir.Click += new System.EventHandler(this.bKaristir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aKaristir);
            this.groupBox2.Controls.Add(this.a21);
            this.groupBox2.Controls.Add(this.a11);
            this.groupBox2.Controls.Add(this.a12);
            this.groupBox2.Controls.Add(this.a13);
            this.groupBox2.Controls.Add(this.a22);
            this.groupBox2.Controls.Add(this.a23);
            this.groupBox2.Controls.Add(this.a31);
            this.groupBox2.Controls.Add(this.a32);
            this.groupBox2.Controls.Add(this.a33);
            this.groupBox2.Location = new System.Drawing.Point(179, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 133);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AMAÇ";
            // 
            // aKaristir
            // 
            this.aKaristir.Location = new System.Drawing.Point(24, 104);
            this.aKaristir.Name = "aKaristir";
            this.aKaristir.Size = new System.Drawing.Size(75, 23);
            this.aKaristir.TabIndex = 22;
            this.aKaristir.Text = "RASTGELE";
            this.aKaristir.UseVisualStyleBackColor = true;
            this.aKaristir.Click += new System.EventHandler(this.aKaristir_Click);
            // 
            // a21
            // 
            this.a21.Location = new System.Drawing.Point(6, 45);
            this.a21.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a21.Name = "a21";
            this.a21.Size = new System.Drawing.Size(31, 20);
            this.a21.TabIndex = 3;
            // 
            // a11
            // 
            this.a11.Location = new System.Drawing.Point(6, 19);
            this.a11.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(31, 20);
            this.a11.TabIndex = 0;
            // 
            // a12
            // 
            this.a12.Location = new System.Drawing.Point(43, 19);
            this.a12.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(31, 20);
            this.a12.TabIndex = 1;
            // 
            // a13
            // 
            this.a13.Location = new System.Drawing.Point(80, 19);
            this.a13.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a13.Name = "a13";
            this.a13.Size = new System.Drawing.Size(31, 20);
            this.a13.TabIndex = 2;
            // 
            // a22
            // 
            this.a22.Location = new System.Drawing.Point(43, 45);
            this.a22.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a22.Name = "a22";
            this.a22.Size = new System.Drawing.Size(31, 20);
            this.a22.TabIndex = 4;
            // 
            // a23
            // 
            this.a23.Location = new System.Drawing.Point(80, 45);
            this.a23.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a23.Name = "a23";
            this.a23.Size = new System.Drawing.Size(31, 20);
            this.a23.TabIndex = 5;
            // 
            // a31
            // 
            this.a31.Location = new System.Drawing.Point(6, 71);
            this.a31.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a31.Name = "a31";
            this.a31.Size = new System.Drawing.Size(31, 20);
            this.a31.TabIndex = 6;
            // 
            // a32
            // 
            this.a32.Location = new System.Drawing.Point(43, 71);
            this.a32.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a32.Name = "a32";
            this.a32.Size = new System.Drawing.Size(31, 20);
            this.a32.TabIndex = 7;
            // 
            // a33
            // 
            this.a33.Location = new System.Drawing.Point(80, 71);
            this.a33.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.a33.Name = "a33";
            this.a33.Size = new System.Drawing.Size(31, 20);
            this.a33.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sıfır(0) değeri boş alanı temsil etmektedir.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.coz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 178);
            this.panel1.TabIndex = 21;
            // 
            // coz
            // 
            this.coz.Location = new System.Drawing.Point(345, 6);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(62, 133);
            this.coz.TabIndex = 21;
            this.coz.Text = "ÇÖZ";
            this.coz.UseVisualStyleBackColor = true;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // c11
            // 
            this.c11.Location = new System.Drawing.Point(19, 24);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(50, 50);
            this.c11.TabIndex = 0;
            this.c11.UseVisualStyleBackColor = true;
            // 
            // c12
            // 
            this.c12.Location = new System.Drawing.Point(75, 24);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(50, 50);
            this.c12.TabIndex = 1;
            this.c12.UseVisualStyleBackColor = true;
            // 
            // c13
            // 
            this.c13.Location = new System.Drawing.Point(131, 24);
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(50, 50);
            this.c13.TabIndex = 2;
            this.c13.UseVisualStyleBackColor = true;
            // 
            // c23
            // 
            this.c23.Location = new System.Drawing.Point(130, 80);
            this.c23.Name = "c23";
            this.c23.Size = new System.Drawing.Size(50, 50);
            this.c23.TabIndex = 5;
            this.c23.UseVisualStyleBackColor = true;
            // 
            // c22
            // 
            this.c22.Location = new System.Drawing.Point(74, 80);
            this.c22.Name = "c22";
            this.c22.Size = new System.Drawing.Size(50, 50);
            this.c22.TabIndex = 4;
            this.c22.UseVisualStyleBackColor = true;
            // 
            // c21
            // 
            this.c21.Location = new System.Drawing.Point(18, 80);
            this.c21.Name = "c21";
            this.c21.Size = new System.Drawing.Size(50, 50);
            this.c21.TabIndex = 3;
            this.c21.UseVisualStyleBackColor = true;
            // 
            // c33
            // 
            this.c33.Location = new System.Drawing.Point(130, 136);
            this.c33.Name = "c33";
            this.c33.Size = new System.Drawing.Size(50, 50);
            this.c33.TabIndex = 8;
            this.c33.UseVisualStyleBackColor = true;
            // 
            // c32
            // 
            this.c32.Location = new System.Drawing.Point(74, 136);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(50, 50);
            this.c32.TabIndex = 7;
            this.c32.UseVisualStyleBackColor = true;
            // 
            // c31
            // 
            this.c31.Location = new System.Drawing.Point(18, 136);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(50, 50);
            this.c31.TabIndex = 6;
            this.c31.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.c33);
            this.groupBox3.Controls.Add(this.c22);
            this.groupBox3.Controls.Add(this.c32);
            this.groupBox3.Controls.Add(this.c11);
            this.groupBox3.Controls.Add(this.c31);
            this.groupBox3.Controls.Add(this.c12);
            this.groupBox3.Controls.Add(this.c23);
            this.groupBox3.Controls.Add(this.c13);
            this.groupBox3.Controls.Add(this.c21);
            this.groupBox3.Location = new System.Drawing.Point(12, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÇÖZÜM";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.adimlar);
            this.groupBox4.Location = new System.Drawing.Point(226, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 200);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ADIMLAR";
            // 
            // adimlar
            // 
            this.adimlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Adım});
            this.adimlar.GridLines = true;
            this.adimlar.HideSelection = false;
            this.adimlar.Location = new System.Drawing.Point(7, 20);
            this.adimlar.Name = "adimlar";
            this.adimlar.Size = new System.Drawing.Size(187, 174);
            this.adimlar.TabIndex = 0;
            this.adimlar.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 411);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "A* Algoritması ile 8 Taş Bulmacası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b31)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.a21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a33)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown b11;
        private System.Windows.Forms.NumericUpDown b12;
        private System.Windows.Forms.NumericUpDown b13;
        private System.Windows.Forms.NumericUpDown b23;
        private System.Windows.Forms.NumericUpDown b22;
        private System.Windows.Forms.NumericUpDown b21;
        private System.Windows.Forms.NumericUpDown b33;
        private System.Windows.Forms.NumericUpDown b32;
        private System.Windows.Forms.NumericUpDown b31;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bKaristir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button aKaristir;
        private System.Windows.Forms.NumericUpDown a21;
        private System.Windows.Forms.NumericUpDown a11;
        private System.Windows.Forms.NumericUpDown a12;
        private System.Windows.Forms.NumericUpDown a13;
        private System.Windows.Forms.NumericUpDown a22;
        private System.Windows.Forms.NumericUpDown a23;
        private System.Windows.Forms.NumericUpDown a31;
        private System.Windows.Forms.NumericUpDown a32;
        private System.Windows.Forms.NumericUpDown a33;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button coz;
        private System.Windows.Forms.Button c11;
        private System.Windows.Forms.Button c12;
        private System.Windows.Forms.Button c13;
        private System.Windows.Forms.Button c23;
        private System.Windows.Forms.Button c22;
        private System.Windows.Forms.Button c21;
        private System.Windows.Forms.Button c33;
        private System.Windows.Forms.Button c32;
        private System.Windows.Forms.Button c31;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView adimlar;
        private System.Windows.Forms.ColumnHeader Adım;
    }
}

