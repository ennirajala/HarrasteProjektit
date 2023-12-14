namespace Tehtava11
{
    public partial class Ikkuna : Form
    {
        public Ikkuna()
        {
            InitializeComponent();
        }

        private bool laskee = false;
        private int luku = 0;
        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            laskee = true;
            Kasvata();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            laskee = false;
            //testu
        }

        private async void Kasvata()
        {
            while(laskee)
            {
                luku = luku + 1;
                textBoxNumber.Text = luku.ToString();

                await Task.Delay(100);
            }

        }
    }
}
