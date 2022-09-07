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
            this.groupBoxDaneUcznia.SuspendLayout();
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
            this.groupBoxDaneUcznia.Controls.Add(this.label5);
            this.groupBoxDaneUcznia.Controls.Add(this.label4);
            this.groupBoxDaneUcznia.Controls.Add(this.label3);
            this.groupBoxDaneUcznia.Controls.Add(this.label2);
            this.groupBoxDaneUcznia.Location = new System.Drawing.Point(109, 102);
            this.groupBoxDaneUcznia.Name = "groupBoxDaneUcznia";
            this.groupBoxDaneUcznia.Size = new System.Drawing.Size(352, 206);
            this.groupBoxDaneUcznia.TabIndex = 2;
            this.groupBoxDaneUcznia.TabStop = false;
            this.groupBoxDaneUcznia.Text = "Dane osobowe ucznia";
            // 
            // groupBoxAdres
            // 
            this.groupBoxAdres.Location = new System.Drawing.Point(109, 355);
            this.groupBoxAdres.Name = "groupBoxAdres";
            this.groupBoxAdres.Size = new System.Drawing.Size(352, 206);
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
    }
}