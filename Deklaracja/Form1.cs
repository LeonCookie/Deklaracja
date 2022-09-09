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
            comboBoxTermin.Items.Add("styczeÒ");
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
                labelNazwaEgzaminu.Text = ("Administracja i eksploatacja systemÛw komputerowych, urzπdzeÒ peryferyjnych i lokalnych sieci komputerowych");
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
        string Sname, Slastname, Sdata, Shome,Spesel,Smiejsc,Sstreet,Sadress,Skodpoczt,Spoczta,Sphone,Smail  ;

        private void pocztaEditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DataEditBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        Boolean Bsprawdz = true;

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {

            //checked lastname
            if (string.IsNullOrEmpty(NazwiskoEditBox.Text))
            {
                NazwiskoEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Slastname = NazwiskoEditBox.Text;
                Debug.WriteLine(Slastname);
                NazwiskoEditBox.BackColor = Color.LimeGreen;
                Bsprawdz = true;
            }
            //checked name
            if (string.IsNullOrEmpty(ImieEditBox.Text))
            {
                ImieEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Sname = ImieEditBox.Text;
                ImieEditBox.BackColor = Color.LimeGreen;
                Bsprawdz = true;
            }
            //checked date and home
            if (!DataEditBox.MaskCompleted)
            {
                DataEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Sdata= DataEditBox.Text;
                DataEditBox.BackColor = Color.LimeGreen;
                Bsprawdz = true;
            }
            
            if (string.IsNullOrEmpty(MiejsceEditBox.Text))
            {
                
                MiejsceEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Smiejsc= MiejsceEditBox.Text;
                MiejsceEditBox.BackColor = Color.LimeGreen;
                Bsprawdz = true;
            }
            //checked PESEL
            if (string.IsNullOrEmpty(PeselEditBox.Text) || PeselEditBox.TextLength != 11)
            {
                    PeselEditBox.BackColor = Color.Red;
                MessageBox.Show("üle wpisano email");
                Bsprawdz = false;

            }
             else       
             {
                    
                    Spesel = PeselEditBox.Text;
                    //DODAC WARUNEK DLA LICZB PARZYSYCH I LITERT A
                    PeselEditBox.BackColor = Color.LimeGreen;
                Bsprawdz = true;
                //if () ;
            }
            
            
            //checked adress
            if (string.IsNullOrEmpty(MiejscEditBox.Text))
            {
                MiejscEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Bsprawdz = true;
                Sadress = MiejscEditBox.Text;
                MiejscEditBox.BackColor = Color.LimeGreen;
            }
            //checked street
            if (string.IsNullOrEmpty(UlicaEditBox.Text))
            {
                UlicaEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Sstreet = UlicaEditBox.Text;
                UlicaEditBox.BackColor = Color.LimeGreen;
                Bsprawdz = true;
            }
            //checked code for mail
            if (!kodPocztowyEditBox.MaskCompleted)
            {
                kodPocztowyEditBox.BackColor = Color.Red;
                Bsprawdz = false;

            }
            else
            {
                Bsprawdz = true;
                Skodpoczt = kodPocztowyEditBox.Text;
                kodPocztowyEditBox.BackColor = Color.LimeGreen;
            }
            //checked mail
            if (string.IsNullOrEmpty(pocztaEditBox.Text))
            {
                pocztaEditBox.BackColor = Color.Red;
                Bsprawdz = false;
            }
            else
            {
                Bsprawdz = true;
                Spoczta = pocztaEditBox.Text;
                pocztaEditBox.BackColor = Color.LimeGreen;
            }
            //checked phone number
            if (!telefonEditBox.MaskCompleted)
            {
                telefonEditBox.BackColor = Color.Red;
                Bsprawdz = false;
                MessageBox.Show("èle wpisono numer telefonu ");
            }
            else
            { 
                    Bsprawdz = true;
                    Sphone = telefonEditBox.Text;
                    telefonEditBox.BackColor = Color.LimeGreen;
                
                   
             
            }
            //checked mail
            if (string.IsNullOrEmpty(mailEditBox.Text))
            {
                mailEditBox.BackColor = Color.Red;
                Bsprawdz = false;

            }
            else
            {
                int x = 1;
                if (x==1)
                {
                    Smail=mailEditBox.Text;
                    Bsprawdz = true;
                    mailEditBox.BackColor = Color.LimeGreen;

                }
                else
                {
                    MessageBox.Show("nie uøyto '@' w mail");
                }
            }

            if (Bsprawdz == true) //comboBoxTermin.SelectedIndex == -1 && comboBoxRodzaj.SelectedIndex == -1 && (RadioButtonInf.Checked || radioButtonProg.Checked) & (radioButtonPierw.Checked || radioButtonKolejny.Checked) && (checkBoxPisemny.Checked || checkBoxPraktyczny.Checked)) 
            {
                Debug.WriteLine("dobrze podane dane");
            }


        }

        private void NazwiskoEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}