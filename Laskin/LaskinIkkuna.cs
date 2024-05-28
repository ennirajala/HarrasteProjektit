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
        private string[] operaatiot = ["+", "-", "/", "*"];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region luku ja operaattori buttonit
        private void button0_Click(object sender, EventArgs e)
        {
            rivi += "0";
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
        private void buttonKerto_Click(object sender, EventArgs e)
        {
            rivi += "*";
            textBoxRivi.Text = rivi;
        }
        #endregion

        //Suorittaa tekstikentässä olevan merkkijonon mukaisen laskutoimituksen
        //TODO yhdistä LaskeJakoJaKerto sekä LaskePlusJaMiinus samaksi aliohjelmaksi, jolla argumenttina operaattorit joita lasketaan
        private void buttonON_Click(object sender, EventArgs e)
        {
            Erottele(rivi);
            LaskeJakoJaKerto(); 
            LaskePlusJaMiinus();

            textBoxRivi.Text = rivi;
        }

        List<double> luvut = new List<double>();
        List<string> merkit = new List<string>();

        //Erottelee annetusta merkkijonosta luvut ja merkit järjestyksessä eri listoihin
        private void Erottele(string s)
        {
            string merkki = string.Empty;
            double luku = 0;
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                merkki = s.Substring(i, 1);
                if (operaatiot.Contains(merkki))
                {
                    luku = Convert.ToDouble(s.Substring(j, i - j));
                    luvut.Add(luku);
                    merkit.Add(merkki);
                    j = i + 1;

                }
            }

            luku = Convert.ToDouble(s.Substring(j));
            luvut.Add(luku);
        }

        // Laskee plus- ja miinuslaskut oikealta vasemmalle luvut ja merkit listojen avulla
        private void LaskePlusJaMiinus()
        {

            while (0 < merkit.Count())
            {
                double tulos = Laske(luvut.ElementAt(0), luvut.ElementAt(1), merkit.ElementAt(0));
                luvut.RemoveAt(0);
                luvut.RemoveAt(0);
                luvut.Insert(0, tulos);
                merkit.RemoveAt(0);
            }
            rivi = luvut.ElementAt(0).ToString();
        }

        // Laskee jako- ja kertolaskut oikealta vasemmalle luvut ja merkit listojen avulla listojen avulla
        private void LaskeJakoJaKerto()
        {

            for (int i = 0; i < merkit.Count();)
            {
                if (merkit.ElementAt(i).Equals("*") || merkit.ElementAt(i).Equals("/"))
                {
                    double tulos = Laske(luvut.ElementAt(i), luvut.ElementAt(i + 1), merkit.ElementAt(i));

                    luvut.RemoveAt(i);
                    luvut.RemoveAt(i);
                    luvut.Insert(i, tulos);
                    merkit.RemoveAt(i);

                }
                else 
                { 
                    i++; 
                }
            }
        }

        //Laskee merkin mukaisen laskun kahdelle luvulle
        private double Laske(double luku1, double luku2, string merkki)
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

            if (merkki.Equals("*"))
            {
                tulos = luku1 * luku2;
            }

            return tulos;
        }

        //Tyhjentää tekstikentän sekä merkit ja luvut listat
        private void buttonNOLLAA_Click(object sender, EventArgs e)
        {
            rivi = "";
            luvut.Clear();
            merkit.Clear();
            textBoxRivi.Text = rivi;
        }

        //Poistaa viimeisimmän merkin tekstikentästä ja merkit- tai luvut listasta
        private void buttonPyyhi_Click(object sender, EventArgs e)
        {
            if (rivi.Length > 0)
            {

                if (operaatiot.Contains(rivi.Substring(rivi.Length - 1)) && merkit.Count() != 0)
                {
                    merkit.RemoveAt(merkit.Count() - 1);
                }
                else
                {
                    if (luvut.Count() != 0)
                    {
                        luvut.RemoveAt(luvut.Count() - 1);
                    }
                }
                
                rivi = rivi.Remove(rivi.Length - 1);
                textBoxRivi.Text = rivi;
            }

        }
    }
}
