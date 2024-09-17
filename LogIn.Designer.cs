namespace Assignment2
{
    partial class LogIn
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
            IdTextBox = new TextBox();
            LogInLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            passwordTextBox = new TextBox();
            LogInButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(178, 206);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 0;
            // 
            // LogInLabel
            // 
            LogInLabel.AutoSize = true;
            LogInLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LogInLabel.Location = new Point(190, 163);
            LogInLabel.Name = "LogInLabel";
            LogInLabel.Size = new Size(69, 25);
            LogInLabel.TabIndex = 1;
            LogInLabel.Text = "Log In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 209);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 256);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(178, 248);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.KeyDown += passwordTextBox_KeyDown;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(178, 293);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(100, 28);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.fruityLogo;
            pictureBox1.Location = new Point(144, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(451, 435);
            Controls.Add(pictureBox1);
            Controls.Add(LogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogInLabel);
            Controls.Add(IdTextBox);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdTextBox;
        private Label LogInLabel;
        private Label label1;
        private Label label2;
        private TextBox passwordTextBox;
        private Button LogInButton;
        private PictureBox pictureBox1;
    }
}