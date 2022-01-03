namespace bilgi_yarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btnsonraki = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 286);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.Black;
            this.BtnA.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnA.ForeColor = System.Drawing.Color.White;
            this.BtnA.Location = new System.Drawing.Point(-1, 292);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(264, 58);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnB
            // 
            this.BtnB.BackColor = System.Drawing.Color.Black;
            this.BtnB.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnB.ForeColor = System.Drawing.Color.White;
            this.BtnB.Location = new System.Drawing.Point(288, 292);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(257, 58);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = false;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.Black;
            this.BtnC.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnC.ForeColor = System.Drawing.Color.White;
            this.BtnC.Location = new System.Drawing.Point(-1, 371);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(264, 58);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.BackColor = System.Drawing.Color.Black;
            this.BtnD.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnD.ForeColor = System.Drawing.Color.White;
            this.BtnD.Location = new System.Drawing.Point(288, 371);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(257, 58);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = false;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(850, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Btnsonraki
            // 
            this.Btnsonraki.BackColor = System.Drawing.Color.Black;
            this.Btnsonraki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnsonraki.ForeColor = System.Drawing.Color.White;
            this.Btnsonraki.Location = new System.Drawing.Point(643, 215);
            this.Btnsonraki.Name = "Btnsonraki";
            this.Btnsonraki.Size = new System.Drawing.Size(256, 41);
            this.Btnsonraki.TabIndex = 13;
            this.Btnsonraki.Text = "SONRAKİ...";
            this.Btnsonraki.UseVisualStyleBackColor = false;
            this.Btnsonraki.Click += new System.EventHandler(this.Btnsonraki_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1353, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btnsonraki);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btnsonraki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

