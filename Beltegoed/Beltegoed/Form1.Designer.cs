namespace Beltegoed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.geefmelding_label1 = new System.Windows.Forms.Label();
            this.antwoord_label2 = new System.Windows.Forms.Label();
            this.beltegoed_textBox1 = new System.Windows.Forms.TextBox();
            this.antwoord_textBox1 = new System.Windows.Forms.TextBox();
            this.tegoed_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geefmelding_label1
            // 
            this.geefmelding_label1.AutoSize = true;
            this.geefmelding_label1.Location = new System.Drawing.Point(412, 138);
            this.geefmelding_label1.Name = "geefmelding_label1";
            this.geefmelding_label1.Size = new System.Drawing.Size(102, 16);
            this.geefmelding_label1.TabIndex = 0;
            this.geefmelding_label1.Text = "Geef Beltegoed";
            this.geefmelding_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // antwoord_label2
            // 
            this.antwoord_label2.AutoSize = true;
            this.antwoord_label2.Location = new System.Drawing.Point(412, 196);
            this.antwoord_label2.Name = "antwoord_label2";
            this.antwoord_label2.Size = new System.Drawing.Size(55, 16);
            this.antwoord_label2.TabIndex = 1;
            this.antwoord_label2.Text = "Melding";
            // 
            // beltegoed_textBox1
            // 
            this.beltegoed_textBox1.Location = new System.Drawing.Point(546, 138);
            this.beltegoed_textBox1.Name = "beltegoed_textBox1";
            this.beltegoed_textBox1.Size = new System.Drawing.Size(100, 22);
            this.beltegoed_textBox1.TabIndex = 2;
            // 
            // antwoord_textBox1
            // 
            this.antwoord_textBox1.Location = new System.Drawing.Point(536, 196);
            this.antwoord_textBox1.Name = "antwoord_textBox1";
            this.antwoord_textBox1.ReadOnly = true;
            this.antwoord_textBox1.Size = new System.Drawing.Size(167, 22);
            this.antwoord_textBox1.TabIndex = 3;
            this.antwoord_textBox1.TextChanged += new System.EventHandler(this.antwoord_textBox1_TextChanged);
            // 
            // tegoed_button1
            // 
            this.tegoed_button1.Location = new System.Drawing.Point(536, 167);
            this.tegoed_button1.Name = "tegoed_button1";
            this.tegoed_button1.Size = new System.Drawing.Size(125, 23);
            this.tegoed_button1.TabIndex = 4;
            this.tegoed_button1.Text = "Geef Melding";
            this.tegoed_button1.UseVisualStyleBackColor = true;
            this.tegoed_button1.Click += new System.EventHandler(this.tegoed_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tegoed_button1);
            this.Controls.Add(this.antwoord_textBox1);
            this.Controls.Add(this.beltegoed_textBox1);
            this.Controls.Add(this.antwoord_label2);
            this.Controls.Add(this.geefmelding_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label geefmelding_label1;
        private System.Windows.Forms.Label antwoord_label2;
        private System.Windows.Forms.TextBox beltegoed_textBox1;
        private System.Windows.Forms.TextBox antwoord_textBox1;
        private System.Windows.Forms.Button tegoed_button1;
    }
}

