using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrünFiyatHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxUrün.Items.Add("Notebook");
        
            comboBoxUrün.Items.Add("LCD Monitör");

     

            comboBoxUrün.Visible = true;
            comboBoxMarka.Visible = false;
            comboBoxModel.Visible = false;
            labelUrün.Visible = true;
            labelMarka.Visible = true;
            labelModel.Visible = true;
            textBoxFiyat.Visible = false;
            textBoxTaksitSayisi.Visible = false;
            textBoxTaksitTutari.Visible = false;
            buttonGöster.Visible = false;
        }

        private void comboBoxUrün_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            comboBoxMarka.Visible = true;
            comboBoxModel.Visible = false;

 

            if (comboBoxUrün.Text == "Notebook")
            {
                comboBoxMarka.Items.Add("HP");
                comboBoxMarka.Items.Add("Dell");
                comboBoxMarka.Items.Add("Monster");
            }

   

            else if (comboBoxUrün.Text == "LCD Monitör")
            {
                comboBoxMarka.Items.Add("Phılıps");
                comboBoxMarka.Items.Add("LG");
                comboBoxMarka.Items.Add("BENQ");
            }


        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            comboBoxModel.Visible = true;

           

            if (comboBoxMarka.Text == "HP")
            {
                comboBoxModel.Items.Add("1330-A64P3");
                comboBoxModel.Items.Add("XPS-M1530"); comboBoxModel.Items.Add("INSPIRON1520"); comboBoxModel.Items.Add("STUDIO1537");
            }

            if (comboBoxMarka.Text == "Dell")
            {
                comboBoxModel.Items.Add("PAV.DV9610ET");
                comboBoxModel.Items.Add("PAV.DV5-1230ET");
                comboBoxModel.Items.Add("PAV.DV-2999ET");
                comboBoxModel.Items.Add("TABLET TX2630TR");
            }

            if (comboBoxMarka.Text == "Toshiba")
            {
                comboBoxModel.Items.Add("NB100-125");
                comboBoxModel.Items.Add("A350-13C");
                comboBoxModel.Items.Add("A300-1ND");
                comboBoxModel.Items.Add("R600-10U");
            }

            
            if (comboBoxMarka.Text == "Phılıps")
            {
                comboBoxModel.Items.Add("18.5191EW9FB");
                comboBoxModel.Items.Add("19 190CW9FB");
                comboBoxModel.Items.Add("21.6 220VW9FB");
            }
            if (comboBoxMarka.Text == "LG")
            {
                comboBoxModel.Items.Add("18.5 W1941S-PF");
                comboBoxModel.Items.Add("22 W2234S-BN");
                comboBoxModel.Items.Add("19 L196WSQ-WF");
            }

            if (comboBoxMarka.Text == "BENQ")
                comboBoxModel.Items.Add("19 G900WAD");

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
       

            labelFiyat.Visible = true;
            labelTaksitSayisi.Visible = true;
            labelTaksitTutari.Visible = true;
            textBoxFiyat.Visible = true;
            textBoxTaksitSayisi.Visible = true;
            textBoxTaksitTutari.Visible = true;
            buttonGöster.Visible = true;
        }

        private void buttonGöster_Click(object sender, EventArgs e)
        {
            if (comboBoxModel.Text == "NB100-125")
                textBoxFiyat.Text = "1000";

            if (comboBoxModel.Text == "1330-A64P3")
                textBoxFiyat.Text = "1250";
            if (comboBoxModel.Text == "XPS-M1530")
                textBoxFiyat.Text = "1350";
            if (comboBoxModel.Text == "INSPIRON1520")
                textBoxFiyat.Text = "1150";
            if (comboBoxModel.Text == "STUDIO1537")
                textBoxFiyat.Text = "2000";
            if (comboBoxModel.Text == "PAV.DV9610ET")
                textBoxFiyat.Text = "1850";

            if (comboBoxModel.Text == "PAV.DV5-1230ET")
                textBoxFiyat.Text = "1750";

            if (comboBoxModel.Text == "PAV.DV-2999ET")
                textBoxFiyat.Text = "1500";

            if (comboBoxModel.Text == "TABLET TX2630TR")
                textBoxFiyat.Text = "2250";

            if (comboBoxModel.Text == "NB100-125")
                textBoxFiyat.Text = "2000";

            if (comboBoxModel.Text == "A350-13C")
                textBoxFiyat.Text = "2500";

            if (comboBoxModel.Text == "A300-1ND")
                textBoxFiyat.Text = "2100";

            if (comboBoxModel.Text == "R600-10U")
                textBoxFiyat.Text = "2200";

            if (comboBoxModel.Text == "IXUS 82")
                textBoxFiyat.Text = "1900";

            if (comboBoxModel.Text == "POWERSHOT E1")
                textBoxFiyat.Text = "1850";

            if (comboBoxModel.Text == "CANON IXUS 85 IS")
                textBoxFiyat.Text = "2300";

            if (comboBoxModel.Text == "SX 110B")
                textBoxFiyat.Text = "3000";

            if (comboBoxModel.Text == "DMC-FS3EG-K")
                textBoxFiyat.Text = "2600";
            if (comboBoxModel.Text == "DMC-FS5")
                textBoxFiyat.Text = "2500";

            if (comboBoxModel.Text == "DMC-LZ8")
                textBoxFiyat.Text = "1500";

            if (comboBoxModel.Text == "VPC-S880")
                textBoxFiyat.Text = "2600";

            if (comboBoxModel.Text == "18.5191EW9FB")
                textBoxFiyat.Text = "3100";

            if (comboBoxModel.Text == "19 190CW9FB")
                textBoxFiyat.Text = "3400";

            if (comboBoxModel.Text == "21.6 220VW9FB")
                textBoxFiyat.Text = "2800";

            if (comboBoxModel.Text == "18.5 W1941S-PF")
                textBoxFiyat.Text = "2250";
            if (comboBoxModel.Text == "22 W2234S-BN")
                textBoxFiyat.Text = "3000";
            if (comboBoxModel.Text == "19 L196WSQ-WF")
                textBoxFiyat.Text = "1750";
            if (comboBoxModel.Text == "19 G900WAD")
                textBoxFiyat.Text = "1250";

          

            comboBoxMarka.Items.Clear();
            comboBoxModel.Items.Clear();

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
          

            double taksit_sayisi, taksit_tutari, pesin;
            pesin = Convert.ToDouble(textBoxFiyat.Text);
            taksit_sayisi = Convert.ToDouble(textBoxTaksitSayisi.Text);
            taksit_tutari = pesin / taksit_sayisi;
            textBoxTaksitTutari.Text = Convert.ToString(taksit_tutari);
        }
    }
}
