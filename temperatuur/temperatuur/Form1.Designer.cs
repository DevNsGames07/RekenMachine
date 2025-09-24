namespace temperatuur
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
            this.temp_attextBox1 = new System.Windows.Forms.TextBox();
            this.fahrenheit_textBox1 = new System.Windows.Forms.TextBox();
            this.kelvin_textBox2 = new System.Windows.Forms.TextBox();
            this.temp_label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bereken_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temp_attextBox1
            // 
            this.temp_attextBox1.Location = new System.Drawing.Point(416, 203);
            this.temp_attextBox1.Name = "temp_attextBox1";
            this.temp_attextBox1.Size = new System.Drawing.Size(100, 22);
            this.temp_attextBox1.TabIndex = 0;
            this.temp_attextBox1.TextChanged += new System.EventHandler(this.temp_attextBox1_TextChanged);
            // 
            // fahrenheit_textBox1
            // 
            this.fahrenheit_textBox1.Location = new System.Drawing.Point(416, 231);
            this.fahrenheit_textBox1.Name = "fahrenheit_textBox1";
            this.fahrenheit_textBox1.Size = new System.Drawing.Size(100, 22);
            this.fahrenheit_textBox1.TabIndex = 1;
            this.fahrenheit_textBox1.TextChanged += new System.EventHandler(this.fahrenheit_textBox1_TextChanged);
            // 
            // kelvin_textBox2
            // 
            this.kelvin_textBox2.Location = new System.Drawing.Point(416, 260);
            this.kelvin_textBox2.Name = "kelvin_textBox2";
            this.kelvin_textBox2.Size = new System.Drawing.Size(100, 22);
            this.kelvin_textBox2.TabIndex = 2;
            this.kelvin_textBox2.TextChanged += new System.EventHandler(this.kelvin_textBox2_TextChanged);
            // 
            // temp_label1
            // 
            this.temp_label1.AutoSize = true;
            this.temp_label1.Location = new System.Drawing.Point(292, 209);
            this.temp_label1.Name = "temp_label1";
            this.temp_label1.Size = new System.Drawing.Size(79, 16);
            this.temp_label1.TabIndex = 3;
            this.temp_label1.Text = "Tempratuur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Graden Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Graden Klevin";
            // 
            // bereken_button1
            // 
            this.bereken_button1.Location = new System.Drawing.Point(471, 289);
            this.bereken_button1.Name = "bereken_button1";
            this.bereken_button1.Size = new System.Drawing.Size(75, 23);
            this.bereken_button1.TabIndex = 6;
            this.bereken_button1.Text = "Bereken";
            this.bereken_button1.UseVisualStyleBackColor = true;
            this.bereken_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.bereken_button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.temp_label1);
            this.Controls.Add(this.kelvin_textBox2);
            this.Controls.Add(this.fahrenheit_textBox1);
            this.Controls.Add(this.temp_attextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temp_attextBox1;
        private System.Windows.Forms.TextBox fahrenheit_textBox1;
        private System.Windows.Forms.TextBox kelvin_textBox2;
        private System.Windows.Forms.Label temp_label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bereken_button1;
    }
}

