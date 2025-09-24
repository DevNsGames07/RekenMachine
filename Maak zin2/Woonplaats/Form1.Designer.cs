namespace Woonplaats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reistijd_button = new System.Windows.Forms.Button();
            this.anwoord_textbox = new System.Windows.Forms.TextBox();
            this.voornaam_textbox = new System.Windows.Forms.TextBox();
            this.woonplaats_textbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Woonplaats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reistijd langer of korter dan een half uur:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // reistijd_button
            // 
            this.reistijd_button.Location = new System.Drawing.Point(347, 296);
            this.reistijd_button.Name = "reistijd_button";
            this.reistijd_button.Size = new System.Drawing.Size(125, 54);
            this.reistijd_button.TabIndex = 3;
            this.reistijd_button.Text = "Reistijd";
            this.reistijd_button.UseVisualStyleBackColor = true;
            this.reistijd_button.Click += new System.EventHandler(this.reistijd_button_Click);
            // 
            // anwoord_textbox
            // 
            this.anwoord_textbox.Location = new System.Drawing.Point(301, 356);
            this.anwoord_textbox.Multiline = true;
            this.anwoord_textbox.Name = "anwoord_textbox";
            this.anwoord_textbox.ReadOnly = true;
            this.anwoord_textbox.Size = new System.Drawing.Size(215, 82);
            this.anwoord_textbox.TabIndex = 4;
            this.anwoord_textbox.TextChanged += new System.EventHandler(this.anwoord_textbox_TextChanged);
            // 
            // voornaam_textbox
            // 
            this.voornaam_textbox.Location = new System.Drawing.Point(405, 145);
            this.voornaam_textbox.Name = "voornaam_textbox";
            this.voornaam_textbox.Size = new System.Drawing.Size(100, 22);
            this.voornaam_textbox.TabIndex = 5;
            this.voornaam_textbox.TextChanged += new System.EventHandler(this.voornaam_textbox_TextChanged);
            // 
            // woonplaats_textbox
            // 
            this.woonplaats_textbox.Location = new System.Drawing.Point(406, 171);
            this.woonplaats_textbox.Name = "woonplaats_textbox";
            this.woonplaats_textbox.Size = new System.Drawing.Size(100, 22);
            this.woonplaats_textbox.TabIndex = 6;
            this.woonplaats_textbox.TextChanged += new System.EventHandler(this.woonplaats_textbox_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Langer",
            "Kort"});
            this.listBox1.Location = new System.Drawing.Point(370, 232);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 52);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.woonplaats_textbox);
            this.Controls.Add(this.voornaam_textbox);
            this.Controls.Add(this.anwoord_textbox);
            this.Controls.Add(this.reistijd_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reistijd_button;
        private System.Windows.Forms.TextBox anwoord_textbox;
        private System.Windows.Forms.TextBox voornaam_textbox;
        private System.Windows.Forms.TextBox woonplaats_textbox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

