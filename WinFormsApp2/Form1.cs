namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double anaPara = double.Parse(txtAnaPara.Text);
                double faizOrani = double.Parse(txtFaizOrani.Text);
                double tarihSayisi = double.Parse(txtTarihSayisi.Text);

                string tarih = "y�l";
                int payda = 100;

                if (rbAylik.Checked)
                {
                    tarih = "ay";
                    payda = 1200;
                }
                else if (rbGunluk.Checked)
                {
                    tarih = "g�n";
                    payda = 36500;
                }

                double getiri = Math.Round(((anaPara * faizOrani * tarihSayisi) / payda), 2);
                double sonuc = Math.Round((anaPara + getiri), 2);

                lblSonuc.Text = $"{anaPara} TL, %{faizOrani} faizle {tarihSayisi} {tarih} sonunda \n{getiri} TL faiz getirirken toplamda {sonuc} TL paran olur.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Anla��lamayan bir hata olu�tu :(\n" + ex.Message);
            }
        }
    }
}
