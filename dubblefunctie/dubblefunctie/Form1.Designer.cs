namespace dubblefunctie
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
            this.getal1_textBox1 = new System.Windows.Forms.TextBox();
            this.getal2_textBox2 = new System.Windows.Forms.TextBox();
            this.vedubbel_textBox3 = new System.Windows.Forms.TextBox();
            this.driedubbel_textBox4 = new System.Windows.Forms.TextBox();
            this.bereken_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getal1_textBox1
            // 
            this.getal1_textBox1.Location = new System.Drawing.Point(337, 186);
            this.getal1_textBox1.Name = "getal1_textBox1";
            this.getal1_textBox1.Size = new System.Drawing.Size(100, 22);
            this.getal1_textBox1.TabIndex = 0;
            // 
            // getal2_textBox2
            // 
            this.getal2_textBox2.Location = new System.Drawing.Point(337, 225);
            this.getal2_textBox2.Name = "getal2_textBox2";
            this.getal2_textBox2.Size = new System.Drawing.Size(100, 22);
            this.getal2_textBox2.TabIndex = 1;
            // 
            // vedubbel_textBox3
            // 
            this.vedubbel_textBox3.Location = new System.Drawing.Point(566, 183);
            this.vedubbel_textBox3.Name = "vedubbel_textBox3";
            this.vedubbel_textBox3.Size = new System.Drawing.Size(100, 22);
            this.vedubbel_textBox3.TabIndex = 2;
            this.vedubbel_textBox3.TextChanged += new System.EventHandler(this.vedubbel_textBox3_TextChanged);
            // 
            // driedubbel_textBox4
            // 
            this.driedubbel_textBox4.Location = new System.Drawing.Point(566, 224);
            this.driedubbel_textBox4.Name = "driedubbel_textBox4";
            this.driedubbel_textBox4.Size = new System.Drawing.Size(100, 22);
            this.driedubbel_textBox4.TabIndex = 3;
            // 
            // bereken_button1
            // 
            this.bereken_button1.Location = new System.Drawing.Point(461, 275);
            this.bereken_button1.Name = "bereken_button1";
            this.bereken_button1.Size = new System.Drawing.Size(75, 23);
            this.bereken_button1.TabIndex = 4;
            this.bereken_button1.Text = "bereken";
            this.bereken_button1.UseVisualStyleBackColor = true;
            this.bereken_button1.Click += new System.EventHandler(this.bereken_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Getal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Getal2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verdubbel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "driedubbel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bereken_button1);
            this.Controls.Add(this.driedubbel_textBox4);
            this.Controls.Add(this.vedubbel_textBox3);
            this.Controls.Add(this.getal2_textBox2);
            this.Controls.Add(this.getal1_textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getal1_textBox1;
        private System.Windows.Forms.TextBox getal2_textBox2;
        private System.Windows.Forms.TextBox vedubbel_textBox3;
        private System.Windows.Forms.TextBox driedubbel_textBox4;
        private System.Windows.Forms.Button bereken_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

