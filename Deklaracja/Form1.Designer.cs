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
            this.groupBoxAdres = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NazwiskoEditBox = new System.Windows.Forms.TextBox();
            this.ImieEditBox = new System.Windows.Forms.TextBox();
            this.DataEditBox = new System.Windows.Forms.TextBox();
            this.MiejsceEditBox = new System.Windows.Forms.TextBox();
            this.PeselEditBox = new System.Windows.Forms.TextBox();
            this.groupBoxDaneUcznia.SuspendLayout();
            this.groupBoxAdres.SuspendLayout();
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
            this.DeklaracjaLabel.Location = new System.Drawing.Point(176, 32);
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
            this.groupBoxDaneUcznia.Location = new System.Drawing.Point(109, 102);
            this.groupBoxDaneUcznia.Name = "groupBoxDaneUcznia";
            this.groupBoxDaneUcznia.Size = new System.Drawing.Size(734, 212);
            this.groupBoxDaneUcznia.TabIndex = 2;
            this.groupBoxDaneUcznia.TabStop = false;
            this.groupBoxDaneUcznia.Text = "Dane osobowe ucznia";
            // 
            // groupBoxAdres
            // 
            this.groupBoxAdres.Controls.Add(this.label10);
            this.groupBoxAdres.Controls.Add(this.label6);
            this.groupBoxAdres.Controls.Add(this.label7);
            this.groupBoxAdres.Controls.Add(this.label8);
            this.groupBoxAdres.Controls.Add(this.label9);
            this.groupBoxAdres.Location = new System.Drawing.Point(109, 355);
            this.groupBoxAdres.Name = "groupBoxAdres";
            this.groupBoxAdres.Size = new System.Drawing.Size(734, 206);
            this.groupBoxAdres.TabIndex = 3;
            this.groupBoxAdres.TabStop = false;
            this.groupBoxAdres.Text = "Adres korespondencyjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data i miejsce urodzenia:";
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
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "ulica i numer domu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "miejscowość:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "mail";
            // 
            // NazwiskoEditBox
            // 
            this.NazwiskoEditBox.Location = new System.Drawing.Point(323, 43);
            this.NazwiskoEditBox.Name = "NazwiskoEditBox";
            this.NazwiskoEditBox.Size = new System.Drawing.Size(385, 31);
            this.NazwiskoEditBox.TabIndex = 4;
            // 
            // ImieEditBox
            // 
            this.ImieEditBox.Location = new System.Drawing.Point(323, 80);
            this.ImieEditBox.Name = "ImieEditBox";
            this.ImieEditBox.Size = new System.Drawing.Size(385, 31);
            this.ImieEditBox.TabIndex = 5;
            // 
            // DataEditBox
            // 
            this.DataEditBox.Location = new System.Drawing.Point(323, 127);
            this.DataEditBox.Name = "DataEditBox";
            this.DataEditBox.Size = new System.Drawing.Size(117, 31);
            this.DataEditBox.TabIndex = 6;
            // 
            // MiejsceEditBox
            // 
            this.MiejsceEditBox.Location = new System.Drawing.Point(464, 127);
            this.MiejsceEditBox.Name = "MiejsceEditBox";
            this.MiejsceEditBox.Size = new System.Drawing.Size(244, 31);
            this.MiejsceEditBox.TabIndex = 7;
            this.MiejsceEditBox.TextChanged += new System.EventHandler(this.MiejsceEditBox_TextChanged);
            // 
            // PeselEditBox
            // 
            this.PeselEditBox.Location = new System.Drawing.Point(323, 178);
            this.PeselEditBox.Name = "PeselEditBox";
            this.PeselEditBox.Size = new System.Drawing.Size(161, 31);
            this.PeselEditBox.TabIndex = 8;
            // 
            // Deklaracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 614);
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
    }
}