using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            BackColor = Color.White;
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
            if (checkBoxPraktyczny.Checked == true)
            {
                Debug.WriteLine("Praktyczny");
            }
        }

        private void comboBoxTermin_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTermin.Items.Add("styczeÒ");
            comboBoxTermin.Items.Add("czerwiec");
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
        string Sname, Slastname, Sdata, Shome,Spesel,Smiejsc,Sstreet,Sadress,Skodpoczt,Spoczta,Sphone,Smail,SWyswietl  ;

       

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxPisemny_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxPisemny.Checked == true)
            {
                Debug.WriteLine("Pisemny");
            }

        }

        private void mailEditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            pocztaEditBox.Clear();
            PeselEditBox.Clear();
            ImieEditBox.Clear();
            NazwiskoEditBox.Clear();
            DataEditBox.Clear();
            MiejscEditBox.Clear();
            MiejsceEditBox.Clear();
            kodPocztowyEditBox.Clear();
            UlicaEditBox.Clear();
            telefonEditBox.Clear();
            mailEditBox.Clear();
            textBoxWyswietl.Clear();
        }

        private void pocztaEditBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pocztaEditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DataEditBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            int Isprawdz = 0;

            //checked lastname
            if (string.IsNullOrEmpty(NazwiskoEditBox.Text))
            {
                NazwiskoEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                Slastname = NazwiskoEditBox.Text;
                Debug.WriteLine(Slastname);
                NazwiskoEditBox.BackColor = Color.LimeGreen;
               
            }
            //checked name
            if (string.IsNullOrEmpty(ImieEditBox.Text))
            {
                ImieEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                Sname = ImieEditBox.Text;
                ImieEditBox.BackColor = Color.LimeGreen;
                
            }
            //checked date and home
            if (!DataEditBox.MaskCompleted)
            {
                DataEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                Sdata= DataEditBox.Text;
                DataEditBox.BackColor = Color.LimeGreen;
                
            }
            
            if (string.IsNullOrEmpty(MiejsceEditBox.Text))
            {
                
                MiejsceEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                Smiejsc= MiejsceEditBox.Text;
                MiejsceEditBox.BackColor = Color.LimeGreen;
                
            }
            //checked PESEL
            int iPESEL = 0;
            if (string.IsNullOrEmpty(PeselEditBox.Text) || PeselEditBox.TextLength != 11)
            {
                PeselEditBox.BackColor = Color.Red;
                Isprawdz++;
                iPESEL++;
            }
            else
            {
                if (ImieEditBox.Text.EndsWith("A") == true)
                {
                    int iostatnie = Convert.ToInt32(PeselEditBox.Text.ToString().Substring(9, 1));
                    if (iostatnie % 2 == 0)
                    {
                        PeselEditBox.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        PeselEditBox.BackColor = Color.Red;
                        iPESEL++;

                        Isprawdz++;
                    }

                }
                else
                {
                    int iostatnie = Convert.ToInt32(PeselEditBox.Text.ToString().Substring(9, 1));
                    if (iostatnie % 2 == 0)
                    {
                        PeselEditBox.BackColor = Color.Red;
                        iPESEL++;
                        Isprawdz++;
                    }
                    else
                    {
                        PeselEditBox.BackColor = Color.LimeGreen;
                    }
                }
                if (iPESEL > 0)
                {
                    MessageBox.Show("üle wpisano Pesel");
                }
            }

                //checked adress
                if (string.IsNullOrEmpty(MiejscEditBox.Text))
            {
                MiejscEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                
                Sadress = MiejscEditBox.Text;
                MiejscEditBox.BackColor = Color.LimeGreen;
            }
            //checked street
            if (string.IsNullOrEmpty(UlicaEditBox.Text))
            {
                UlicaEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                Sstreet = UlicaEditBox.Text;
                UlicaEditBox.BackColor = Color.LimeGreen;
                
            }
            //checked code for mail
            if (!kodPocztowyEditBox.MaskCompleted)
            {
                kodPocztowyEditBox.BackColor = Color.Red;
                Isprawdz++;

            }
            else
            {
                

                
                Skodpoczt = kodPocztowyEditBox.Text;
                kodPocztowyEditBox.BackColor = Color.LimeGreen;
            }
           
               

            //poczta
            if(string.IsNullOrEmpty(pocztaEditBox.Text))
            {
                pocztaEditBox.BackColor = Color.Red;
                Isprawdz++;
            }
            else
            {
                
                Spoczta = pocztaEditBox.Text;
                pocztaEditBox.BackColor = Color.LimeGreen;
            }
            //checked phone number
            if (!telefonEditBox.MaskCompleted)
            {
                telefonEditBox.BackColor = Color.Red;
                
                MessageBox.Show("èle wpisono numer telefonu ");
            }
            else
            { 
                    
                    Sphone = telefonEditBox.Text;
                    telefonEditBox.BackColor = Color.LimeGreen;
                
                   
             
            }
            //checked mail
            if (String.IsNullOrEmpty(mailEditBox.Text) || mailEditBox.Text.Contains("@") == false || (String.IsNullOrEmpty(mailEditBox.Text) && mailEditBox.Text.Contains("@") == false))
            {
                mailEditBox.BackColor = Color.Red;
                Isprawdz++;
                MessageBox.Show("brak '@' w mail");

            }
            else
            {
                    mailEditBox.BackColor = Color.LimeGreen;
        
                    
            }
            Debug.WriteLine(Isprawdz);


            
            if (Isprawdz==0) //comboBoxTermin.SelectedIndex == -1 && comboBoxRodzaj.SelectedIndex == -1 && (RadioButtonInf.Checked || radioButtonProg.Checked) & (radioButtonPierw.Checked || radioButtonKolejny.Checked) && (checkBoxPisemny.Checked || checkBoxPraktyczny.Checked)) 
            {
                Debug.WriteLine("dobrze podane dane");
                bool isChecked1 = radioButtonPierw.Checked;
                string value1 = "";
                if (isChecked1)     
                {
                    value1 = radioButtonPierw.Text;

                }
                else
                {
                    value1 = radioButtonKolejny.Text;
                }


                string textCze = "";

                if (checkBoxPisemny.Checked == true)
                {
                    textCze = "pisemnej.";

                }
                else if (checkBoxPisemny.Checked == true && checkBoxPraktyczny.Checked == true)
                {
                    textCze = "praktycznej i pisemnej1.";
                }
                else
                {
                    textCze = "praktycznej.";
                }



                string nazwaegz = "";
                if (comboBoxRodzaj.Text == "INF.02")
                {
                    nazwaegz = ("Administracja i eksploatacja systemÛw komputerowych, urzπdzeÒ peryferyjnych i lokalnych sieci komputerowych");
                }
                else if (comboBoxRodzaj.Text == "INF.03")
                {
                    nazwaegz = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych";
                }
                else if (comboBoxRodzaj.Text == "INF.04")
                {
                    nazwaegz = "Projektowanie, programowanie i testowanie aplikacji";
                }

                bool isChecked2 = radioButtonProg.Checked;
                string cyfrowy = "";
                string nazwaZaw = "";
                if (isChecked2)
                {
                    nazwaZaw = radioButtonProg.Text;
                    cyfrowy = "351406";

                }
                else
                {
                    cyfrowy = "351203";
                    nazwaZaw = RadioButtonInf.Text;
                }


                textBoxWyswietl.Text = "Deklaruje przystπpienie do egzaminu potwierdzajπcego kwalifikacje w zawodzie przeprowadzonego terminu" + " " + comboBoxTermin.Text + "\r\n" + "\r\n" +
                    "Dane osobowe ucznia" + "\r\n" +
                    " Nazwisko: \t" + NazwiskoEditBox.Text + "\r\n" +
                    " Imie(imiona):\t" + ImieEditBox.Text + "\r\n" +
                    " Data i miejsce urodzenia: \t" + DataEditBox.Text + " , " + MiejsceEditBox.Text + "\r\n" +
                    " Numer Pesel:\t " + PeselEditBox.Text + "\r\n" + "\r\n" +
                    "Adres korenspondencyjny" + "\r\n" +
                    " miejscowoúÊ:\t " + MiejscEditBox.Text + "\r\n" +
                    " ulica i numer domu:\t " + UlicaEditBox.Text + "\r\n" +
                    " kod pocztowy i poczta:\t " + kodPocztowyEditBox.Text + " , " + pocztaEditBox.Text + "\r\n" +
                    " nr telefonu z kierunkowym:\t " + telefonEditBox.Text + "\r\n" +
                    " mail:\t " + mailEditBox.Text + "\r\n" + "\r\n" +
                    "Deklaruje przystπpienie do egazminu " + value1 + " do " + textCze
                    + "\r\n" + "\r\n" +
                    "Oznaczenie kwalifikacji zgodne z podstawπ programowπ: " + comboBoxRodzaj.Text + "\r\n" +
                    "Nazwa kwalifikacji: " + nazwaegz + "." + "\r\n" + "\r\n" +
                    "Symbol cyfrowy zawodu: " + cyfrowy + "\r\n" +
                    "Nazwa zawodu: " + nazwaZaw;

                SWyswietl = textBoxWyswietl.Text;
            }


        }

        private void Deklaracja_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "Deklaracja_Egzaminu.txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());

                

                    writer.WriteLine(textBoxWyswietl.Text);

                

                writer.Dispose();

                writer.Close();

            }
        }

        private void NazwiskoEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
            NazwiskoEditBox.BackColor = Color.White; 
        }
        private void ImieEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImieEditBox.BackColor = Color.White;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void MiejscEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MiejscEditBox.BackColor = Color.White;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void MiejsceEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MiejsceEditBox.BackColor = Color.White;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void kodPocztowyEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            kodPocztowyEditBox.BackColor = Color.White;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void pocztaEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            pocztaEditBox.BackColor = Color.White;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }




        private void DataEditBox_KeyPress(object sender, KeyPressEventArgs e)//only numbers
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            DataEditBox.BackColor = Color.White;

        }
        private void PeselEditBox_KeyPress(object sender, KeyPressEventArgs e)//only numbers
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            PeselEditBox.BackColor = Color.White;

        }



        private void UlicaEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UlicaEditBox.BackColor = Color.White;
        }
        private void telefonEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            telefonEditBox.BackColor = Color.White;
        }
        private void mailEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            mailEditBox.BackColor = Color.White;
        }

       
            
        


    }
}