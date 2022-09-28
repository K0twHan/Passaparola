using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0,sure=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           sure=sure-1;
            label7.Text=(sure).ToString();
            if (sure == -1)
            {
                MessageBox.Show("Süren Bitti ozoğğ!");
                MessageBox.Show("Şimdi Programı kapıyorum baştan başla ezq");
                Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            sure = 31;
            timer1.Enabled = true;
            timer1.Start();
            linkLabel1.Text = "Cevapla";
            if (soruno>= 17)
            {
                MessageBox.Show("Daha Fazla soru kalmadı");
                soruno--;
            }
           soruno++;
            this.Text = soruno.ToString() + " " + "Şrfsz Uzooğ!";
            switch (soruno)
            {
                case 1: //adana
                    richTextBox1.Text = "01 Plakalı Şehrimizin adı ?";
                    button17.Text = "A";
                    break;
                case 2: //bursa
                    button17.Text = "B";

                    richTextBox1.Text = ".... civarı pasif var mı sorusunun sorulduğu ilimiz ? xD";
                    break ;
                case 3: //cumhur
                    button17.Text = "C";

                    richTextBox1.Text = "AKP ve MHP nin kurduğu ittifakın adı nedir ?";
                    break;
                case 4: //dersim
                    button17.Text = "D";

                    richTextBox1.Text = "Tunceli şehrimizin diğer adı nedir ?";
                    break;
                case 5: //endonezya
                    button17.Text = "E";

                    richTextBox1.Text = "Tsunami Felaketinde En Fazla Zarar Gören Güney Asya Ülkesi Aşağıdakilerden Hangisidir ?";
                    break;
                case 6: //fatih terim
                    button17.Text = "F";

                    richTextBox1.Text = "İmparator adıyla bilinen Teknik Direktör Kimdir?";
                    break;
                case 7: //gaziantep
                    button17.Text = "G";

                    richTextBox1.Text = "Mustafa Kemal Atatürk’ün Nüfusa Kayıtlı Olduğu İl Hangisidir ?";
                    break;
                case 8: //herkül
                    button17.Text = "H";

                    richTextBox1.Text = "Yunan mitolojisinde gücü ile bilinen yarı tanrı";
                    break;
                case 9: //ırak
                    button17.Text = "I";

                    richTextBox1.Text = "Eskiden İslam Dünyasının ilim beşiği olan Kufe şehri hangi devlet sınırları içindedir?";
                    break;
                case 10: //kudüs
                    button17.Text = "K";

                    richTextBox1.Text = "Üç Büyük Dince Kutsal Sayılan Şehir Hangisidir?";
                    break;
                case 11: //lizozom
                    button17.Text = "L";

                    richTextBox1.Text = "Hücre yapısında yer alan organelin adı nedir?";
                    break;
                case 12: //muğla
                    button17.Text = "M";

                    richTextBox1.Text = "Hangi İlimizde Demiryolu Yoktur?";
                    break;
                case 13: //namibya
                    button17.Text = "N";

                    richTextBox1.Text = "Namib Çölünün Bulunduğu ülke";
                    break;
                case 14: //olay ufku
                    button17.Text = "O";

                    richTextBox1.Text = "Bir Karadelik'ten Kurtulabileceğiniz en yakın noktanın adı nedir";
                    break;
                case 15: //pruva
                    button17.Text = "P";

                    richTextBox1.Text = "Geminin baş kısmının adı nedir?";
                    break;
                case 16: //resital
                    button17.Text = "R";

                    richTextBox1.Text = "tek bir sanatçının tek bir çalgıyla verdiği konsere ne denir";
                    break;
            }
           switch(soruno-1)
            {
                case 1:
                    if (textBox1.Text=="Adana"|| textBox1.Text=="adana")
                    {
                        button1.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 2:
                    if (textBox1.Text == "Bursa" || textBox1.Text == "bursa")
                    {
                        button2.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button2.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 3:
                    if (textBox1.Text == "Cumhur" || textBox1.Text == "cumhur")
                    {
                        button3.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button3.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 4:
                    if (textBox1.Text == "Dersim" || textBox1.Text == "dersim")
                    {
                        button4.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button4.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 5:
                    if (textBox1.Text == "Endonezya" || textBox1.Text == "endonezya")
                    {
                        button5.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button5.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 6:
                    if (textBox1.Text == "Fatih Terim" || textBox1.Text == "bursa")
                    {
                        button6.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button6.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 7:
                    if (textBox1.Text == "GaziAntep" || textBox1.Text == "gaziantep")
                    {
                        button7.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button7.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 8:
                    if (textBox1.Text == "Herkül" || textBox1.Text == "herkül")
                    {
                        button8.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button8.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 9:
                    if (textBox1.Text == "Irak" || textBox1.Text == "ırak")
                    {
                        button9.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button9.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 10:
                    if (textBox1.Text == "Kudüs" || textBox1.Text == "kudüs")
                    {
                        button10.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button10.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 11:
                    if (textBox1.Text == "Lizozom" || textBox1.Text == "lizozom")
                    {
                        button11.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button11.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 12:
                    if (textBox1.Text == "Muğla" || textBox1.Text == "muğla")
                    {
                        button12.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button12.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 13:
                    if (textBox1.Text == "namibya" || textBox1.Text == "Namibya")
                    {
                        button13.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button13.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 14:
                    if (textBox1.Text == "Olay ufku" || textBox1.Text == "olay ufku")
                    {
                        button14.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button14.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 15:
                    if (textBox1.Text == "Pruva" || textBox1.Text == "pruva")
                    {
                        button15.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button15.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
                case 16:
                    if (textBox1.Text == "Resital" || textBox1.Text == "resital")
                    {
                        button16.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        button16.BackColor = Color.Red;
                        yanlis++;
                    }
                    textBox1.Clear();
                    break;
            }
            label2.Text = dogru.ToString();
            label4.Text = yanlis.ToString();
           
            if (dogru == 16)
            {
                MessageBox.Show("Kel Ozo fullemişin");
            }
            if (yanlis == 16)
            {
                MessageBox.Show("Kel Ozo 16 da 0 nasıl başardın laaağn");
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Text = "Soru Yarışması";
        }
    }
}
