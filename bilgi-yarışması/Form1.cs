using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label8.Text = BtnA.Text;
            if (label7.Text==label8.Text)
            {
                doğru++;
                label4.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0, doğru = 0, yanlış = 0;
        private void Btnsonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            Btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            label4.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildi?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label7.Text = "1923";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi ilimiz Ege Bölgesinde Değildir?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label7.Text = "Balıkesir";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label7.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                Btnsonraki.Enabled = true;
                Btnsonraki.Text = "Sonuçlar...";

                MessageBox.Show("Doğru:" + doğru + "\n" + "Yanlış:" + yanlış);
            }


        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label8.Text = BtnB.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;

            label8.Text = BtnC.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            Btnsonraki.Enabled = true;
           
            

            label8.Text = BtnD.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
            
        }
    }
}
