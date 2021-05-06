namespace WindowsFormsApp2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnvirgul = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.btntopla = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btncikar = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnsin = new System.Windows.Forms.Button();
            this.btncot = new System.Windows.Forms.Button();
            this.btntan = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnkare = new System.Windows.Forms.Button();
            this.btnkok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(18, 45);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(333, 46);
            this.txt1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.Location = new System.Drawing.Point(20, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 37);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.Location = new System.Drawing.Point(86, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 37);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.Location = new System.Drawing.Point(150, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 37);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn4.Location = new System.Drawing.Point(19, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(61, 37);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn5.Location = new System.Drawing.Point(86, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 37);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn6.Location = new System.Drawing.Point(152, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 37);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.Location = new System.Drawing.Point(19, 119);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(61, 37);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn8.Location = new System.Drawing.Point(86, 119);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 37);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn9.Location = new System.Drawing.Point(150, 119);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 37);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn0.Location = new System.Drawing.Point(18, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(126, 37);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnvirgul
            // 
            this.btnvirgul.Location = new System.Drawing.Point(152, 257);
            this.btnvirgul.Name = "btnvirgul";
            this.btnvirgul.Size = new System.Drawing.Size(58, 37);
            this.btnvirgul.TabIndex = 11;
            this.btnvirgul.Text = ",";
            this.btnvirgul.UseVisualStyleBackColor = true;
            this.btnvirgul.Click += new System.EventHandler(this.btnvirgul_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(469, 208);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(60, 86);
            this.btnhesapla.TabIndex = 10;
            this.btnhesapla.Text = "=";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // btntopla
            // 
            this.btntopla.Location = new System.Drawing.Point(224, 257);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(60, 37);
            this.btntopla.TabIndex = 16;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // btnbol
            // 
            this.btnbol.Location = new System.Drawing.Point(223, 119);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(60, 37);
            this.btnbol.TabIndex = 15;
            this.btnbol.Text = "/";
            this.btnbol.UseVisualStyleBackColor = true;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // btncarp
            // 
            this.btncarp.Location = new System.Drawing.Point(223, 165);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(60, 37);
            this.btncarp.TabIndex = 14;
            this.btncarp.Text = "X";
            this.btncarp.UseVisualStyleBackColor = true;
            this.btncarp.Click += new System.EventHandler(this.btncarp_Click);
            // 
            // btncikar
            // 
            this.btncikar.Location = new System.Drawing.Point(223, 208);
            this.btncikar.Name = "btncikar";
            this.btncikar.Size = new System.Drawing.Size(61, 37);
            this.btncikar.TabIndex = 13;
            this.btncikar.Text = "---";
            this.btncikar.UseVisualStyleBackColor = true;
            this.btncikar.Click += new System.EventHandler(this.btncikar_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(466, 119);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(63, 40);
            this.btntemizle.TabIndex = 17;
            this.btntemizle.Text = "C";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(466, 165);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(63, 40);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "<-----";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 19;
            // 
            // btnsin
            // 
            this.btnsin.Location = new System.Drawing.Point(314, 119);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(75, 37);
            this.btnsin.TabIndex = 21;
            this.btnsin.Text = "sin";
            this.btnsin.UseVisualStyleBackColor = true;
            this.btnsin.Click += new System.EventHandler(this.btnsin_Click);
            // 
            // btncot
            // 
            this.btncot.Location = new System.Drawing.Point(385, 165);
            this.btncot.Name = "btncot";
            this.btncot.Size = new System.Drawing.Size(75, 37);
            this.btncot.TabIndex = 22;
            this.btncot.Text = "cot";
            this.btncot.UseVisualStyleBackColor = true;
            this.btncot.Click += new System.EventHandler(this.btncot_Click);
            // 
            // btntan
            // 
            this.btntan.Location = new System.Drawing.Point(314, 165);
            this.btntan.Name = "btntan";
            this.btntan.Size = new System.Drawing.Size(75, 37);
            this.btntan.TabIndex = 24;
            this.btntan.Text = "tan";
            this.btntan.UseVisualStyleBackColor = true;
            this.btntan.Click += new System.EventHandler(this.btntan_Click);
            // 
            // btncos
            // 
            this.btncos.Location = new System.Drawing.Point(385, 119);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(75, 37);
            this.btncos.TabIndex = 23;
            this.btncos.Text = "cos";
            this.btncos.UseVisualStyleBackColor = true;
            this.btncos.Click += new System.EventHandler(this.btncos_Click);
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(314, 257);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(146, 37);
            this.btnlog.TabIndex = 28;
            this.btnlog.Text = "log";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnkare
            // 
            this.btnkare.Location = new System.Drawing.Point(385, 211);
            this.btnkare.Name = "btnkare";
            this.btnkare.Size = new System.Drawing.Size(75, 37);
            this.btnkare.TabIndex = 27;
            this.btnkare.Text = "x² ";
            this.btnkare.UseVisualStyleBackColor = true;
            this.btnkare.Click += new System.EventHandler(this.btnkare_Click);
            // 
            // btnkok
            // 
            this.btnkok.Location = new System.Drawing.Point(314, 211);
            this.btnkok.Name = "btnkok";
            this.btnkok.Size = new System.Drawing.Size(75, 37);
            this.btnkok.TabIndex = 25;
            this.btnkok.Text = "√";
            this.btnkok.UseVisualStyleBackColor = true;
            this.btnkok.Click += new System.EventHandler(this.btnkok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(655, 380);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btnkare);
            this.Controls.Add(this.btnkok);
            this.Controls.Add(this.btntan);
            this.Controls.Add(this.btncos);
            this.Controls.Add(this.btncot);
            this.Controls.Add(this.btnsin);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btntopla);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btncikar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnvirgul);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnvirgul;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btncikar;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Button btncot;
        private System.Windows.Forms.Button btntan;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnkare;
        private System.Windows.Forms.Button btnkok;
    }
}

