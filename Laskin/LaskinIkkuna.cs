using System.Security.AccessControl;

namespace Laskin
{
    public partial class LaskinIkkuna : Form
    {
        public LaskinIkkuna()
        {
            InitializeComponent();
        }

        private string rivi = "";
        private string[] operaatiot = ["+", "-", "/"];

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            rivi+= "0";
            textBoxRivi.Text = rivi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rivi += "1";
            textBoxRivi.Text = rivi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rivi += "2";
            textBoxRivi.Text = rivi;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            rivi += "3";
            textBoxRivi.Text = rivi;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rivi += "4";
            textBoxRivi.Text = rivi;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            rivi += "5";
            textBoxRivi.Text = rivi;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            rivi += "6";
            textBoxRivi.Text = rivi;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rivi += "7";
            textBoxRivi.Text = rivi;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rivi += "8";
            textBoxRivi.Text = rivi;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rivi += "9";
            textBoxRivi.Text = rivi;
        }

        private void buttonMiinus_Click(object sender, EventArgs e)
        {
            rivi += "-";
            textBoxRivi.Text = rivi;
        }

        private void buttonPilkku_Click(object sender, EventArgs e)
        {
            rivi += ",";
            textBoxRivi.Text = rivi;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            rivi += "+";
            textBoxRivi.Text = rivi;
        }

        private void buttonJako_Click(object sender, EventArgs e)
        {
            rivi += "/";
            textBoxRivi.Text = rivi;
        }

        //Testaa tata
        private void buttonON_Click(object sender, EventArgs e)
        {
            Erottele();
        }

        //Erottelee laskettavat luvut merkeista
        // toimii yhdellä operaatiolla
        // TODO toimimaan useammalla operaatiolla
        private void Erottele()
        {
            string merkki = string.Empty;
            double osa1 = 0;
            double osa2 = 0;

            for (int i = 0; i < rivi.Length; i++)
            {
                merkki = rivi.Substring(i, 1);
                if (operaatiot.Contains(merkki))
                {
                    osa1 = Convert.ToDouble(rivi.Substring(0, i));
                    osa2 = Convert.ToDouble(rivi.Substring(i + 1));
                    break;
                }
            }

            Laske(osa1, osa2, merkki);

        }

        //Laskee merkin mukaisen laskun kahdelle luvulle
        private void Laske(double luku1, double luku2, string merkki)
        {
            double tulos = 0;

            if (merkki.Equals("+"))
            {
                tulos = luku1 + luku2;
            }

            if (merkki.Equals("-"))
            {
                tulos = luku1 - luku2;
            }

            if (merkki.Equals("/"))
            {
                tulos = luku1 / luku2;
            }

            rivi = tulos.ToString();
            textBoxRivi.Text = tulos.ToString();
        }

        private void buttonNOLLAA_Click(object sender, EventArgs e)
        {
            rivi = "";
            textBoxRivi.Text = rivi;
        }

        private void buttonPyyhi_Click(object sender, EventArgs e)
        {
            if(rivi.Length > 0)
            {
                rivi = rivi.Remove(rivi.Length - 1);
                textBoxRivi.Text = rivi;
            }

        }
    }
}
