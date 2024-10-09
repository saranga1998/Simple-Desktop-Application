namespace Simple_Form
{
    partial class Paper
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            codetxt = new TextBox();
            titletxt = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            NamecomboBox = new ComboBox();
            btnLogout = new Button();
            statustxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 91);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 0;
            label1.Text = "Lecture name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 137);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 1;
            label2.Text = "Course code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 187);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Course Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 238);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 3;
            label4.Text = "Date Received";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(98, 278);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(510, 361);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 5;
            button1.Text = "Add Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // codetxt
            // 
            codetxt.Location = new Point(299, 133);
            codetxt.Name = "codetxt";
            codetxt.Size = new Size(249, 27);
            codetxt.TabIndex = 6;
            // 
            // titletxt
            // 
            titletxt.Location = new Point(299, 183);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(249, 27);
            titletxt.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(298, 238);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // NamecomboBox
            // 
            NamecomboBox.FormattingEnabled = true;
            NamecomboBox.Location = new Point(298, 86);
            NamecomboBox.Name = "NamecomboBox";
            NamecomboBox.Size = new Size(250, 28);
            NamecomboBox.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(684, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button2_Click;
            // 
            // statustxt
            // 
            statustxt.Location = new Point(298, 278);
            statustxt.Name = "statustxt";
            statustxt.Size = new Size(249, 27);
            statustxt.TabIndex = 11;
            // 
            // Paper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statustxt);
            Controls.Add(btnLogout);
            Controls.Add(NamecomboBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(titletxt);
            Controls.Add(codetxt);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Paper";
            Text = "Paper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button btnLogout;
        private TextBox codetxt;
        private TextBox titletxt;
        private DateTimePicker dateTimePicker1;
        private ComboBox NamecomboBox;
        private TextBox statustxt;
    }
}