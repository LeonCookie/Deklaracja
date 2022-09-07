using System.Diagnostics;

namespace Deklaracja
{
    public partial class Deklaracja : Form
    {
        public Deklaracja()
        {
            InitializeComponent();
        }


        private void Deklaracja_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MiejsceEditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NazwiskoEditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PeselEditBox_TextChanged(object sender, EventArgs e)
        {
            PeselEditBox.MaxLength = 11;
            
        }

        private void DataEditBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPierw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPraktyczny_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTermin_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTermin.Items.Add("styczeñ");
            comboBoxTermin.Items.Add("czerwiec");
        }

        private void DataEditBox_KeyPress(object sender, KeyPressEventArgs e)//only numbers
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RadioButtonInf_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonInf.Checked == true)
            {
                comboBoxRodzaj.Enabled = true;
                Debug.WriteLine("wybrano inf");
                comboBoxRodzaj.Items.Clear();
                comboBoxRodzaj.Text = "";
                comboBoxRodzaj.Items.Add("INF.02");
                comboBoxRodzaj.Items.Add("INF.03");
            }
        }
        private void radioButtonProg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProg.Checked == true)
            {
                comboBoxRodzaj.Enabled = true;
                Debug.WriteLine("wybrano prog");
                comboBoxRodzaj.Items.Clear();
                comboBoxRodzaj.Text = "";
                comboBoxRodzaj.Items.Add("INF.03");
                comboBoxRodzaj.Items.Add("INF.04");
            }
        }

        private void comboBoxRodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBoxRodzaj.Text == "INF.02")
            {
                labelNazwaEgzaminu.Text = ("Administracja i eksploatacja systemów komputerowych, urz¹dzeñ peryferyjnych i lokalnych sieci komputerowych");
            }
            else if(comboBoxRodzaj.Text == "INF.03")
            {
                labelNazwaEgzaminu.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych";
            }
            else if (comboBoxRodzaj.Text == "INF.04")
            {
                labelNazwaEgzaminu.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
            else
            {
                labelNazwaEgzaminu.Text = "";
            }
        }
    }
}