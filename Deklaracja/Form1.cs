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
             if (radioButtonKolejny.Checked == true)
            {
                checkBoxPisemny.Enabled = true;
                checkBoxPraktyczny.Enabled = true;
            }
        }

        private void radioButtonPierw_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPierw.Checked == true)
            {
                checkBoxPisemny.Enabled = false;
                checkBoxPraktyczny.Enabled = false;
                checkBoxPraktyczny.Checked = false;
                checkBoxPisemny.Checked = false;
            }
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

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            //checked lastname
            if (string.IsNullOrEmpty(NazwiskoEditBox.Text))
            {
                NazwiskoEditBox.BackColor = Color.Red;
            }
            else
            {
                NazwiskoEditBox.BackColor = Color.LimeGreen;
            }
            //checked name
            if (string.IsNullOrEmpty(ImieEditBox.Text))
            {
                ImieEditBox.BackColor = Color.Red;
            }
            else
            {
                ImieEditBox.BackColor = Color.LimeGreen;
            }
            //checked date and home
            if (string.IsNullOrEmpty(DataEditBox.Text))
            {
                DataEditBox.BackColor = Color.Red;
            }
            else
            {
                DataEditBox.BackColor = Color.LimeGreen;
            }
            if (string.IsNullOrEmpty(MiejsceEditBox.Text))
            {
                MiejsceEditBox.BackColor = Color.Red;
            }
            else
            {
                MiejsceEditBox.BackColor = Color.LimeGreen;
            }
            //checked PESEL
            if (string.IsNullOrEmpty(PeselEditBox.Text) || PeselEditBox.TextLength !=11)
            {
                PeselEditBox.BackColor = Color.Red;
            }
            else
            {
                //DODAC WARUNEK DLA LICZB PARZYSYCH I LITERT A
                PeselEditBox.BackColor = Color.LimeGreen;
            }
            //checked adress
            if (string.IsNullOrEmpty(MiejscEditBox.Text))
            {
                MiejscEditBox.BackColor = Color.Red;
            }
            else
            {
                MiejscEditBox.BackColor = Color.LimeGreen;
            }
            //checked street
            if (string.IsNullOrEmpty(UlicaEditBox.Text))
            {
                UlicaEditBox.BackColor = Color.Red;
            }
            else
            {
                UlicaEditBox.BackColor = Color.LimeGreen;
            }
            //checked code for mail
            if (string.IsNullOrEmpty(kodPocztowyEditBox.Text))
            {
                kodPocztowyEditBox.BackColor = Color.Red;
            }
            else
            {
                kodPocztowyEditBox.BackColor = Color.LimeGreen;
            }
            //checked mail
            if (string.IsNullOrEmpty(pocztaEditBox.Text))
            {
                pocztaEditBox.BackColor = Color.Red;
            }
            else
            {
                pocztaEditBox.BackColor = Color.LimeGreen;
            }
            //checked phone number
            if (string.IsNullOrEmpty(telefonEditBox.Text))
            {
                telefonEditBox.BackColor = Color.Red;
            }
            else
            {
                telefonEditBox.BackColor = Color.LimeGreen;
            }
            //checked mail
            if (string.IsNullOrEmpty(mailEditBox.Text))
            {
                mailEditBox.BackColor = Color.Red;
            }
            else
            {
                mailEditBox.BackColor = Color.LimeGreen;
            }


        }

        private void NazwiskoEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}