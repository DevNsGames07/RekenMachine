namespace posofnega
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
            this.titel_label1 = new System.Windows.Forms.Label();
            this.vulgetal_label1 = new System.Windows.Forms.Label();
            this.getal_textBox1 = new System.Windows.Forms.TextBox();
            this.check_button1 = new System.Windows.Forms.Button();
            this.anwtoord_label1 = new System.Windows.Forms.Label();
            this.antwoord_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titel_label1
            // 
            this.titel_label1.AutoSize = true;
            this.titel_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_label1.Location = new System.Drawing.Point(284, 88);
            this.titel_label1.Name = "titel_label1";
            this.titel_label1.Size = new System.Drawing.Size(236, 29);
            this.titel_label1.TabIndex = 0;
            this.titel_label1.Text = "Positief of Negatief";
            // 
            // vulgetal_label1
            // 
            this.vulgetal_label1.AutoSize = true;
            this.vulgetal_label1.Location = new System.Drawing.Point(299, 155);
            this.vulgetal_label1.Name = "vulgetal_label1";
            this.vulgetal_label1.Size = new System.Drawing.Size(75, 16);
            this.vulgetal_label1.TabIndex = 1;
            this.vulgetal_label1.Text = "Vul getal in:";
            // 
            // getal_textBox1
            // 
            this.getal_textBox1.Location = new System.Drawing.Point(390, 152);
            this.getal_textBox1.Name = "getal_textBox1";
            this.getal_textBox1.Size = new System.Drawing.Size(130, 22);
            this.getal_textBox1.TabIndex = 2;
            // 
            // check_button1
            // 
            this.check_button1.Location = new System.Drawing.Point(329, 191);
            this.check_button1.Name = "check_button1";
            this.check_button1.Size = new System.Drawing.Size(154, 23);
            this.check_button1.TabIndex = 3;
            this.check_button1.Text = "Positief of Negatief";
            this.check_button1.UseVisualStyleBackColor = true;
            this.check_button1.Click += new System.EventHandler(this.check_button1_Click);
            // 
            // anwtoord_label1
            // 
            this.anwtoord_label1.AutoSize = true;
            this.anwtoord_label1.Location = new System.Drawing.Point(299, 228);
            this.anwtoord_label1.Name = "anwtoord_label1";
            this.anwtoord_label1.Size = new System.Drawing.Size(72, 16);
            this.anwtoord_label1.TabIndex = 4;
            this.anwtoord_label1.Text = "Dit getal is:";
            // 
            // antwoord_textBox1
            // 
            this.antwoord_textBox1.Location = new System.Drawing.Point(390, 225);
            this.antwoord_textBox1.Name = "antwoord_textBox1";
            this.antwoord_textBox1.ReadOnly = true;
            this.antwoord_textBox1.Size = new System.Drawing.Size(130, 22);
            this.antwoord_textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.antwoord_textBox1);
            this.Controls.Add(this.anwtoord_label1);
            this.Controls.Add(this.check_button1);
            this.Controls.Add(this.getal_textBox1);
            this.Controls.Add(this.vulgetal_label1);
            this.Controls.Add(this.titel_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titel_label1;
        private System.Windows.Forms.Label vulgetal_label1;
        private System.Windows.Forms.TextBox getal_textBox1;
        private System.Windows.Forms.Button check_button1;
        private System.Windows.Forms.Label anwtoord_label1;
        private System.Windows.Forms.TextBox antwoord_textBox1;
    }
}

