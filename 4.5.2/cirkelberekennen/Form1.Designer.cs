namespace cirkelberekennen
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
            this.input_label1 = new System.Windows.Forms.Label();
            this.omtrek_label2 = new System.Windows.Forms.Label();
            this.oppervlakte_label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.straal_textBox1 = new System.Windows.Forms.TextBox();
            this.omtrek_textBox2 = new System.Windows.Forms.TextBox();
            this.oppervlakte_textBox3 = new System.Windows.Forms.TextBox();
            this.aantal_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_label1
            // 
            this.input_label1.AutoSize = true;
            this.input_label1.Location = new System.Drawing.Point(370, 137);
            this.input_label1.Name = "input_label1";
            this.input_label1.Size = new System.Drawing.Size(133, 16);
            this.input_label1.TabIndex = 0;
            this.input_label1.Text = "Vul hier een aantal in:";
            this.input_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // omtrek_label2
            // 
            this.omtrek_label2.AutoSize = true;
            this.omtrek_label2.Location = new System.Drawing.Point(439, 207);
            this.omtrek_label2.Name = "omtrek_label2";
            this.omtrek_label2.Size = new System.Drawing.Size(53, 16);
            this.omtrek_label2.TabIndex = 1;
            this.omtrek_label2.Text = "Omtrek:";
            // 
            // oppervlakte_label3
            // 
            this.oppervlakte_label3.AutoSize = true;
            this.oppervlakte_label3.Location = new System.Drawing.Point(408, 244);
            this.oppervlakte_label3.Name = "oppervlakte_label3";
            this.oppervlakte_label3.Size = new System.Drawing.Size(84, 16);
            this.oppervlakte_label3.TabIndex = 2;
            this.oppervlakte_label3.Text = "Oppervlakte:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bereken de omtrek en de opppervlakte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // straal_textBox1
            // 
            this.straal_textBox1.Location = new System.Drawing.Point(0, 0);
            this.straal_textBox1.Name = "straal_textBox1";
            this.straal_textBox1.Size = new System.Drawing.Size(100, 22);
            this.straal_textBox1.TabIndex = 7;
            // 
            // omtrek_textBox2
            // 
            this.omtrek_textBox2.Location = new System.Drawing.Point(509, 204);
            this.omtrek_textBox2.Name = "omtrek_textBox2";
            this.omtrek_textBox2.Size = new System.Drawing.Size(100, 22);
            this.omtrek_textBox2.TabIndex = 5;
            this.omtrek_textBox2.TextChanged += new System.EventHandler(this.omtrek_textBox2_TextChanged);
            // 
            // oppervlakte_textBox3
            // 
            this.oppervlakte_textBox3.Location = new System.Drawing.Point(509, 244);
            this.oppervlakte_textBox3.Name = "oppervlakte_textBox3";
            this.oppervlakte_textBox3.Size = new System.Drawing.Size(100, 22);
            this.oppervlakte_textBox3.TabIndex = 6;
            this.oppervlakte_textBox3.TextChanged += new System.EventHandler(this.oppervlakte_textBox3_TextChanged);
            // 
            // aantal_textBox1
            // 
            this.aantal_textBox1.Location = new System.Drawing.Point(510, 130);
            this.aantal_textBox1.Name = "aantal_textBox1";
            this.aantal_textBox1.Size = new System.Drawing.Size(100, 22);
            this.aantal_textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aantal_textBox1);
            this.Controls.Add(this.oppervlakte_textBox3);
            this.Controls.Add(this.omtrek_textBox2);
            this.Controls.Add(this.straal_textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oppervlakte_label3);
            this.Controls.Add(this.omtrek_label2);
            this.Controls.Add(this.input_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_label1;
        private System.Windows.Forms.Label omtrek_label2;
        private System.Windows.Forms.Label oppervlakte_label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox straal_textBox1;
        private System.Windows.Forms.TextBox omtrek_textBox2;
        private System.Windows.Forms.TextBox oppervlakte_textBox3;
        private System.Windows.Forms.TextBox aantal_textBox1;
    }
}

