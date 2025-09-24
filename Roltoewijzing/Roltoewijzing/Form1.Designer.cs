namespace Roltoewijzing
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
            this.code_abel1 = new System.Windows.Forms.Label();
            this.rol_label1 = new System.Windows.Forms.Label();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.antwoordrol_textBox1 = new System.Windows.Forms.TextBox();
            this.melding_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code_abel1
            // 
            this.code_abel1.AutoSize = true;
            this.code_abel1.Location = new System.Drawing.Point(437, 151);
            this.code_abel1.Name = "code_abel1";
            this.code_abel1.Size = new System.Drawing.Size(43, 16);
            this.code_abel1.TabIndex = 0;
            this.code_abel1.Text = "Code:";
            // 
            // rol_label1
            // 
            this.rol_label1.AutoSize = true;
            this.rol_label1.Location = new System.Drawing.Point(449, 199);
            this.rol_label1.Name = "rol_label1";
            this.rol_label1.Size = new System.Drawing.Size(31, 16);
            this.rol_label1.TabIndex = 1;
            this.rol_label1.Text = "Rol:";
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(495, 145);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(156, 22);
            this.code_textBox.TabIndex = 2;
            // 
            // antwoordrol_textBox1
            // 
            this.antwoordrol_textBox1.Location = new System.Drawing.Point(495, 199);
            this.antwoordrol_textBox1.Name = "antwoordrol_textBox1";
            this.antwoordrol_textBox1.Size = new System.Drawing.Size(156, 22);
            this.antwoordrol_textBox1.TabIndex = 3;
            // 
            // melding_button1
            // 
            this.melding_button1.Location = new System.Drawing.Point(495, 174);
            this.melding_button1.Name = "melding_button1";
            this.melding_button1.Size = new System.Drawing.Size(156, 23);
            this.melding_button1.TabIndex = 4;
            this.melding_button1.Text = "Melding";
            this.melding_button1.UseVisualStyleBackColor = true;
            this.melding_button1.Click += new System.EventHandler(this.melding_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.melding_button1);
            this.Controls.Add(this.antwoordrol_textBox1);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.rol_label1);
            this.Controls.Add(this.code_abel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code_abel1;
        private System.Windows.Forms.Label rol_label1;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.TextBox antwoordrol_textBox1;
        private System.Windows.Forms.Button melding_button1;
    }
}

