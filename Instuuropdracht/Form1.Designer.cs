namespace HelloWorldApp1
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
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.showmessage_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(327, 337);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(242, 22);
            this.Message_textBox.TabIndex = 0;
            this.Message_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // showmessage_button
            // 
            this.showmessage_button.Location = new System.Drawing.Point(374, 186);
            this.showmessage_button.Name = "showmessage_button";
            this.showmessage_button.Size = new System.Drawing.Size(132, 68);
            this.showmessage_button.TabIndex = 1;
            this.showmessage_button.Text = "Say Hi!";
            this.showmessage_button.UseVisualStyleBackColor = true;
            this.showmessage_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showmessage_button);
            this.Controls.Add(this.Message_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Button showmessage_button;
    }
}

