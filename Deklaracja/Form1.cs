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

        private void radioButtonProg_CheckedChanged(object sender, EventArgs e)
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
    }
}