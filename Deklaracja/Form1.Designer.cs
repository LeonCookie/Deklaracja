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
            this.groupBoxDaneUcznia.Location = new System.Drawing.Point(109, 102);
            this.groupBoxDaneUcznia.Name = "groupBoxDaneUcznia";
            this.groupBoxDaneUcznia.Size = new System.Drawing.Size(300, 150);
            this.groupBoxDaneUcznia.TabIndex = 2;
            this.groupBoxDaneUcznia.TabStop = false;
            this.groupBoxDaneUcznia.Text = "Dane osobowe ucznia";
            // 
            // groupBoxAdres
            // 
            this.groupBoxAdres.Location = new System.Drawing.Point(109, 280);
            this.groupBoxAdres.Name = "groupBoxAdres";
            this.groupBoxAdres.Size = new System.Drawing.Size(300, 150);
            this.groupBoxAdres.TabIndex = 3;
            this.groupBoxAdres.TabStop = false;
            this.groupBoxAdres.Text = "Adres korespondencyjny";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label DeklaracjaLabel;
        private GroupBox groupBoxDaneUcznia;
        private GroupBox groupBoxAdres;
    }
}