

namespace Simple_Form
{
    partial class Welcome
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeBtn = new Button();
            SuspendLayout();
            // 
            // WelcomeBtn
            // 
            WelcomeBtn.BackColor = SystemColors.ControlDarkDark;
            WelcomeBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeBtn.ForeColor = SystemColors.ButtonHighlight;
            WelcomeBtn.Location = new Point(285, 258);
            WelcomeBtn.Name = "WelcomeBtn";
            WelcomeBtn.Size = new Size(218, 44);
            WelcomeBtn.TabIndex = 0;
            WelcomeBtn.Text = "Get Started";
            WelcomeBtn.UseVisualStyleBackColor = false;
            WelcomeBtn.Click += this.WelcomeBtn_Click;
            
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeBtn);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
        }

        



        #endregion

        private Button WelcomeBtn;
    }
}
