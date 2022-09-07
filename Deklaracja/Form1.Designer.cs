namespace Deklaracja
{
    partial class Deklaracja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deklaracja));
            this.label1 = new System.Windows.Forms.Label();
            this.DeklaracjaLabel = new System.Windows.Forms.Label();
            this.groupBoxDaneUcznia = new System.Windows.Forms.GroupBox();
            this.PeselEditBox = new System.Windows.Forms.TextBox();
            this.MiejsceEditBox = new System.Windows.Forms.TextBox();
            this.DataEditBox = new System.Windows.Forms.TextBox();
            this.ImieEditBox = new System.Windows.Forms.TextBox();
            this.NazwiskoEditBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAdres = new System.Windows.Forms.GroupBox();
            this.telefonEditBox = new System.Windows.Forms.TextBox();
            this.mailEditBox = new System.Windows.Forms.TextBox();
            this.pocztaEditBox = new System.Windows.Forms.TextBox();
            this.kodPocztowyEditBox = new System.Windows.Forms.TextBox();
            this.UlicaEditBox = new System.Windows.Forms.TextBox();
            this.MiejscEditBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RadioButtonInf = new System.Windows.Forms.RadioButton();
            this.radioButtonProg = new System.Windows.Forms.RadioButton();
            this.radioButtonPierw = new System.Windows.Forms.RadioButton();
            this.radioButtonKolejny = new System.Windows.Forms.RadioButton();
            this.checkBoxPisemny = new System.Windows.Forms.CheckBox();
            this.checkBoxPraktyczny = new System.Windows.Forms.CheckBox();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.comboBoxTermin = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRodzaj = new System.Windows.Forms.ComboBox();
            this.textBoxWyswietl = new System.Windows.Forms.TextBox();
            this.labelNazwaEgzaminu = new System.Windows.Forms.Label();
            this.groupBoxDaneUcznia.SuspendLayout();
            this.groupBoxAdres.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            // 
            // DeklaracjaLabel
            // 
            this.DeklaracjaLabel.AutoSize = true;
            this.DeklaracjaLabel.Location = new System.Drawing.Point(279, 36);
            this.DeklaracjaLabel.Name = "DeklaracjaLabel";
            this.DeklaracjaLabel.Size = new System.Drawing.Size(373, 25);
            this.DeklaracjaLabel.TabIndex = 1;
            this.DeklaracjaLabel.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            // 
            // groupBoxDaneUcznia
            // 
            this.groupBoxDaneUcznia.Controls.Add(this.PeselEditBox);
            this.groupBoxDaneUcznia.Controls.Add(this.MiejsceEditBox);
            this.groupBoxDaneUcznia.Controls.Add(this.DataEditBox);
            this.groupBoxDaneUcznia.Controls.Add(this.ImieEditBox);
            this.groupBoxDaneUcznia.Controls.Add(this.NazwiskoEditBox);
            this.groupBoxDaneUcznia.Controls.Add(this.label5);
            this.groupBoxDaneUcznia.Controls.Add(this.label4);
            this.groupBoxDaneUcznia.Controls.Add(this.label3);
            this.groupBoxDaneUcznia.Controls.Add(this.label2);
            this.groupBoxDaneUcznia.Location = new System.Drawing.Point(12, 98);
            this.groupBoxDaneUcznia.Name = "groupBoxDaneUcznia";
            this.groupBoxDaneUcznia.Size = new System.Drawing.Size(874, 212);
            this.groupBoxDaneUcznia.TabIndex = 2;
            this.groupBoxDaneUcznia.TabStop = false;
            this.groupBoxDaneUcznia.Text = "Dane osobowe ucznia";
            // 
            // PeselEditBox
            // 
            this.PeselEditBox.Location = new System.Drawing.Point(323, 178);
            this.PeselEditBox.MaxLength = 11;
            this.PeselEditBox.Name = "PeselEditBox";
            this.PeselEditBox.Size = new System.Drawing.Size(223, 31);
            this.PeselEditBox.TabIndex = 8;
            this.PeselEditBox.TextChanged += new System.EventHandler(this.PeselEditBox_TextChanged);
            this.PeselEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataEditBox_KeyPress);
            // 
            // MiejsceEditBox
            // 
            this.MiejsceEditBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MiejsceEditBox.Location = new System.Drawing.Point(551, 127);
            this.MiejsceEditBox.Name = "MiejsceEditBox";
            this.MiejsceEditBox.Size = new System.Drawing.Size(299, 31);
            this.MiejsceEditBox.TabIndex = 7;
            this.MiejsceEditBox.TextChanged += new System.EventHandler(this.MiejsceEditBox_TextChanged);
            this.MiejsceEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoEditBox_KeyPress);
            // 
            // DataEditBox
            // 
            this.DataEditBox.Location = new System.Drawing.Point(323, 127);
            this.DataEditBox.Name = "DataEditBox";
            this.DataEditBox.Size = new System.Drawing.Size(148, 31);
            this.DataEditBox.TabIndex = 6;
            this.DataEditBox.TextChanged += new System.EventHandler(this.DataEditBox_TextChanged);
            this.DataEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataEditBox_KeyPress);
            // 
            // ImieEditBox
            // 
            this.ImieEditBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ImieEditBox.Location = new System.Drawing.Point(322, 83);
            this.ImieEditBox.Name = "ImieEditBox";
            this.ImieEditBox.Size = new System.Drawing.Size(528, 31);
            this.ImieEditBox.TabIndex = 5;
            this.ImieEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoEditBox_KeyPress);
            // 
            // NazwiskoEditBox
            // 
            this.NazwiskoEditBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NazwiskoEditBox.Location = new System.Drawing.Point(323, 43);
            this.NazwiskoEditBox.Name = "NazwiskoEditBox";
            this.NazwiskoEditBox.Size = new System.Drawing.Size(528, 31);
            this.NazwiskoEditBox.TabIndex = 4;
            this.NazwiskoEditBox.TextChanged += new System.EventHandler(this.NazwiskoEditBox_TextChanged);
            this.NazwiskoEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoEditBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numer PESEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data i miejsce urodzenia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imię (imiona):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBoxAdres
            // 
            this.groupBoxAdres.Controls.Add(this.telefonEditBox);
            this.groupBoxAdres.Controls.Add(this.mailEditBox);
            this.groupBoxAdres.Controls.Add(this.pocztaEditBox);
            this.groupBoxAdres.Controls.Add(this.kodPocztowyEditBox);
            this.groupBoxAdres.Controls.Add(this.UlicaEditBox);
            this.groupBoxAdres.Controls.Add(this.MiejscEditBox);
            this.groupBoxAdres.Controls.Add(this.label10);
            this.groupBoxAdres.Controls.Add(this.label6);
            this.groupBoxAdres.Controls.Add(this.label7);
            this.groupBoxAdres.Controls.Add(this.label8);
            this.groupBoxAdres.Controls.Add(this.label9);
            this.groupBoxAdres.Location = new System.Drawing.Point(12, 332);
            this.groupBoxAdres.Name = "groupBoxAdres";
            this.groupBoxAdres.Size = new System.Drawing.Size(874, 206);
            this.groupBoxAdres.TabIndex = 3;
            this.groupBoxAdres.TabStop = false;
            this.groupBoxAdres.Text = "Adres korespondencyjny";
            // 
            // telefonEditBox
            // 
            this.telefonEditBox.Location = new System.Drawing.Point(322, 165);
            this.telefonEditBox.Name = "telefonEditBox";
            this.telefonEditBox.Size = new System.Drawing.Size(149, 31);
            this.telefonEditBox.TabIndex = 14;
            // 
            // mailEditBox
            // 
            this.mailEditBox.Location = new System.Drawing.Point(586, 165);
            this.mailEditBox.Name = "mailEditBox";
            this.mailEditBox.Size = new System.Drawing.Size(265, 31);
            this.mailEditBox.TabIndex = 13;
            // 
            // pocztaEditBox
            // 
            this.pocztaEditBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pocztaEditBox.Location = new System.Drawing.Point(478, 123);
            this.pocztaEditBox.Name = "pocztaEditBox";
            this.pocztaEditBox.Size = new System.Drawing.Size(372, 31);
            this.pocztaEditBox.TabIndex = 12;
            this.pocztaEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoEditBox_KeyPress);
            // 
            // kodPocztowyEditBox
            // 
            this.kodPocztowyEditBox.Location = new System.Drawing.Point(323, 123);
            this.kodPocztowyEditBox.Name = "kodPocztowyEditBox";
            this.kodPocztowyEditBox.Size = new System.Drawing.Size(118, 31);
            this.kodPocztowyEditBox.TabIndex = 11;
            this.kodPocztowyEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataEditBox_KeyPress);
            // 
            // UlicaEditBox
            // 
            this.UlicaEditBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UlicaEditBox.Location = new System.Drawing.Point(323, 86);
            this.UlicaEditBox.Name = "UlicaEditBox";
            this.UlicaEditBox.Size = new System.Drawing.Size(527, 31);
            this.UlicaEditBox.TabIndex = 10;
            // 
            // MiejscEditBox
            // 
            this.MiejscEditBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MiejscEditBox.Location = new System.Drawing.Point(323, 42);
            this.MiejscEditBox.Name = "MiejscEditBox";
            this.MiejscEditBox.Size = new System.Drawing.Size(528, 31);
            this.MiejscEditBox.TabIndex = 9;
            this.MiejscEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoEditBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "mail:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "nr telefonu z kierunkowym:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "kod pocztowy i poczta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "ulica i numer domu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "miejscowość:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 559);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(637, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "przeprowadzanego w terminie";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1047, 357);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(8, 8);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // RadioButtonInf
            // 
            this.RadioButtonInf.AutoSize = true;
            this.RadioButtonInf.Location = new System.Drawing.Point(245, 659);
            this.RadioButtonInf.Name = "RadioButtonInf";
            this.RadioButtonInf.Size = new System.Drawing.Size(184, 29);
            this.RadioButtonInf.TabIndex = 8;
            this.RadioButtonInf.TabStop = true;
            this.RadioButtonInf.Text = "technik informatyk";
            this.RadioButtonInf.UseVisualStyleBackColor = true;
            this.RadioButtonInf.CheckedChanged += new System.EventHandler(this.RadioButtonInf_CheckedChanged);
            // 
            // radioButtonProg
            // 
            this.radioButtonProg.AutoSize = true;
            this.radioButtonProg.Location = new System.Drawing.Point(583, 659);
            this.radioButtonProg.Name = "radioButtonProg";
            this.radioButtonProg.Size = new System.Drawing.Size(195, 29);
            this.radioButtonProg.TabIndex = 9;
            this.radioButtonProg.TabStop = true;
            this.radioButtonProg.Text = "technik programista";
            this.radioButtonProg.UseVisualStyleBackColor = true;
            this.radioButtonProg.CheckedChanged += new System.EventHandler(this.radioButtonProg_CheckedChanged);
            // 
            // radioButtonPierw
            // 
            this.radioButtonPierw.AutoSize = true;
            this.radioButtonPierw.Location = new System.Drawing.Point(21, 47);
            this.radioButtonPierw.Name = "radioButtonPierw";
            this.radioButtonPierw.Size = new System.Drawing.Size(160, 29);
            this.radioButtonPierw.TabIndex = 10;
            this.radioButtonPierw.TabStop = true;
            this.radioButtonPierw.Text = "po raz pierwszy";
            this.radioButtonPierw.UseVisualStyleBackColor = true;
            this.radioButtonPierw.CheckedChanged += new System.EventHandler(this.radioButtonPierw_CheckedChanged);
            // 
            // radioButtonKolejny
            // 
            this.radioButtonKolejny.AutoSize = true;
            this.radioButtonKolejny.Location = new System.Drawing.Point(221, 49);
            this.radioButtonKolejny.Name = "radioButtonKolejny";
            this.radioButtonKolejny.Size = new System.Drawing.Size(148, 29);
            this.radioButtonKolejny.TabIndex = 11;
            this.radioButtonKolejny.TabStop = true;
            this.radioButtonKolejny.Text = "po raz kolejny";
            this.radioButtonKolejny.UseVisualStyleBackColor = true;
            this.radioButtonKolejny.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBoxPisemny
            // 
            this.checkBoxPisemny.AutoSize = true;
            this.checkBoxPisemny.Enabled = false;
            this.checkBoxPisemny.Location = new System.Drawing.Point(606, 843);
            this.checkBoxPisemny.Name = "checkBoxPisemny";
            this.checkBoxPisemny.Size = new System.Drawing.Size(109, 29);
            this.checkBoxPisemny.TabIndex = 12;
            this.checkBoxPisemny.Text = " Pisemny";
            this.checkBoxPisemny.UseVisualStyleBackColor = true;
            // 
            // checkBoxPraktyczny
            // 
            this.checkBoxPraktyczny.AutoSize = true;
            this.checkBoxPraktyczny.Enabled = false;
            this.checkBoxPraktyczny.Location = new System.Drawing.Point(736, 844);
            this.checkBoxPraktyczny.Name = "checkBoxPraktyczny";
            this.checkBoxPraktyczny.Size = new System.Drawing.Size(127, 29);
            this.checkBoxPraktyczny.TabIndex = 13;
            this.checkBoxPraktyczny.Text = "Praktyczny ";
            this.checkBoxPraktyczny.UseVisualStyleBackColor = true;
            this.checkBoxPraktyczny.CheckedChanged += new System.EventHandler(this.checkBoxPraktyczny_CheckedChanged);
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(606, 912);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(256, 34);
            this.buttonZatwierdz.TabIndex = 14;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(1017, 912);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(256, 34);
            this.buttonWyczysc.TabIndex = 15;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(1361, 912);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(256, 34);
            this.buttonZapisz.TabIndex = 16;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            // 
            // comboBoxTermin
            // 
            this.comboBoxTermin.FormattingEnabled = true;
            this.comboBoxTermin.Items.AddRange(new object[] {
            "Styczeń",
            "Czerwiec"});
            this.comboBoxTermin.Location = new System.Drawing.Point(490, 598);
            this.comboBoxTermin.Name = "comboBoxTermin";
            this.comboBoxTermin.Size = new System.Drawing.Size(182, 33);
            this.comboBoxTermin.TabIndex = 17;
            this.comboBoxTermin.SelectedIndexChanged += new System.EventHandler(this.comboBoxTermin_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPierw);
            this.panel1.Controls.Add(this.radioButtonKolejny);
            this.panel1.Location = new System.Drawing.Point(158, 796);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 150);
            this.panel1.TabIndex = 18;
            // 
            // comboBoxRodzaj
            // 
            this.comboBoxRodzaj.Enabled = false;
            this.comboBoxRodzaj.FormattingEnabled = true;
            this.comboBoxRodzaj.Location = new System.Drawing.Point(158, 719);
            this.comboBoxRodzaj.Name = "comboBoxRodzaj";
            this.comboBoxRodzaj.Size = new System.Drawing.Size(182, 33);
            this.comboBoxRodzaj.TabIndex = 19;
            this.comboBoxRodzaj.SelectedIndexChanged += new System.EventHandler(this.comboBoxRodzaj_SelectedIndexChanged);
            // 
            // textBoxWyswietl
            // 
            this.textBoxWyswietl.Location = new System.Drawing.Point(1017, 36);
            this.textBoxWyswietl.MaximumSize = new System.Drawing.Size(600, 570);
            this.textBoxWyswietl.MinimumSize = new System.Drawing.Size(600, 850);
            this.textBoxWyswietl.Multiline = true;
            this.textBoxWyswietl.Name = "textBoxWyswietl";
            this.textBoxWyswietl.Size = new System.Drawing.Size(600, 850);
            this.textBoxWyswietl.TabIndex = 20;
            // 
            // labelNazwaEgzaminu
            // 
            this.labelNazwaEgzaminu.AutoSize = true;
            this.labelNazwaEgzaminu.Location = new System.Drawing.Point(379, 727);
            this.labelNazwaEgzaminu.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelNazwaEgzaminu.Name = "labelNazwaEgzaminu";
            this.labelNazwaEgzaminu.Size = new System.Drawing.Size(0, 25);
            this.labelNazwaEgzaminu.TabIndex = 21;
            // 
            // Deklaracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 978);
            this.Controls.Add(this.labelNazwaEgzaminu);
            this.Controls.Add(this.textBoxWyswietl);
            this.Controls.Add(this.comboBoxRodzaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxTermin);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonZatwierdz);
            this.Controls.Add(this.checkBoxPraktyczny);
            this.Controls.Add(this.checkBoxPisemny);
            this.Controls.Add(this.radioButtonProg);
            this.Controls.Add(this.RadioButtonInf);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxAdres);
            this.Controls.Add(this.groupBoxDaneUcznia);
            this.Controls.Add(this.DeklaracjaLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Deklaracja";
            this.Text = "Deklaracja";
            this.Load += new System.EventHandler(this.Deklaracja_Load);
            this.groupBoxDaneUcznia.ResumeLayout(false);
            this.groupBoxDaneUcznia.PerformLayout();
            this.groupBoxAdres.ResumeLayout(false);
            this.groupBoxAdres.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label DeklaracjaLabel;
        private GroupBox groupBoxDaneUcznia;
        private GroupBox groupBoxAdres;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox PeselEditBox;
        private TextBox MiejsceEditBox;
        private TextBox DataEditBox;
        private TextBox ImieEditBox;
        private TextBox NazwiskoEditBox;
        private TextBox MiejscEditBox;
        private TextBox pocztaEditBox;
        private TextBox kodPocztowyEditBox;
        private TextBox UlicaEditBox;
        private TextBox telefonEditBox;
        private TextBox mailEditBox;
        private Label label11;
        private Label label12;
        private ListView listView1;
        private RadioButton RadioButtonInf;
        private RadioButton radioButtonProg;
        private RadioButton radioButtonPierw;
        private RadioButton radioButtonKolejny;
        private CheckBox checkBoxPisemny;
        private CheckBox checkBoxPraktyczny;
        private Button buttonZatwierdz;
        private Button buttonWyczysc;
        private Button buttonZapisz;
        private ComboBox comboBoxTermin;
        private Panel panel1;
        private ComboBox comboBoxRodzaj;
        private TextBox textBoxWyswietl;
        private Label labelNazwaEgzaminu;
    }
}