namespace Assignment2
{
    partial class MyAccount
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            groupBox1 = new GroupBox();
            saveChangeButton = new Button();
            printBalanceLabel = new Label();
            printIdLabel = new Label();
            lNameTextBox = new TextBox();
            fNameTextBox = new TextBox();
            balanceLable = new Label();
            dateTimePicker = new DateTimePicker();
            dobLabel = new Label();
            lNameLabel = new Label();
            firstNameLable = new Label();
            nameLabel = new Label();
            toolStrip1 = new ToolStrip();
            homeButton = new ToolStripButton();
            LogOutButton = new ToolStripButton();
            groupBox2 = new GroupBox();
            changePWbutton = new Button();
            changePWTextBox = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveChangeButton);
            groupBox1.Controls.Add(printBalanceLabel);
            groupBox1.Controls.Add(printIdLabel);
            groupBox1.Controls.Add(lNameTextBox);
            groupBox1.Controls.Add(fNameTextBox);
            groupBox1.Controls.Add(balanceLable);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(dobLabel);
            groupBox1.Controls.Add(lNameLabel);
            groupBox1.Controls.Add(firstNameLable);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "My Detail";
            // 
            // saveChangeButton
            // 
            saveChangeButton.Location = new Point(175, 188);
            saveChangeButton.Name = "saveChangeButton";
            saveChangeButton.Size = new Size(123, 29);
            saveChangeButton.TabIndex = 10;
            saveChangeButton.Text = "Save Change";
            saveChangeButton.UseVisualStyleBackColor = true;
            saveChangeButton.Click += saveChangeButton_Click;
            // 
            // printBalanceLabel
            // 
            printBalanceLabel.AutoSize = true;
            printBalanceLabel.Location = new Point(91, 163);
            printBalanceLabel.Name = "printBalanceLabel";
            printBalanceLabel.Size = new Size(76, 15);
            printBalanceLabel.TabIndex = 9;
            printBalanceLabel.Text = "print balance";
            // 
            // printIdLabel
            // 
            printIdLabel.AutoSize = true;
            printIdLabel.Location = new Point(91, 45);
            printIdLabel.Name = "printIdLabel";
            printIdLabel.Size = new Size(45, 15);
            printIdLabel.TabIndex = 8;
            printIdLabel.Text = "print id";
            // 
            // lNameTextBox
            // 
            lNameTextBox.Location = new Point(91, 98);
            lNameTextBox.Name = "lNameTextBox";
            lNameTextBox.Size = new Size(165, 23);
            lNameTextBox.TabIndex = 7;
            // 
            // fNameTextBox
            // 
            fNameTextBox.Location = new Point(91, 69);
            fNameTextBox.Name = "fNameTextBox";
            fNameTextBox.Size = new Size(165, 23);
            fNameTextBox.TabIndex = 6;
            // 
            // balanceLable
            // 
            balanceLable.AutoSize = true;
            balanceLable.Location = new Point(37, 163);
            balanceLable.Name = "balanceLable";
            balanceLable.Size = new Size(57, 15);
            balanceLable.TabIndex = 5;
            balanceLable.Text = "Balance : ";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(91, 127);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(207, 23);
            dateTimePicker.TabIndex = 4;
            dateTimePicker.Value = new DateTime(2023, 10, 29, 2, 53, 20, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(10, 133);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(84, 15);
            dobLabel.TabIndex = 3;
            dobLabel.Text = "Date Of Birth : ";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new Point(22, 101);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new Size(72, 15);
            lNameLabel.TabIndex = 2;
            lNameLabel.Text = "Last Name : ";
            // 
            // firstNameLable
            // 
            firstNameLable.AutoSize = true;
            firstNameLable.Location = new Point(21, 72);
            firstNameLable.Name = "firstNameLable";
            firstNameLable.Size = new Size(70, 15);
            firstNameLable.TabIndex = 1;
            firstNameLable.Text = "First Name :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(67, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(27, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "ID : ";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { homeButton, LogOutButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(354, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // homeButton
            // 
            homeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.ImageTransparentColor = Color.Magenta;
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(44, 22);
            homeButton.Text = "Home";
            homeButton.Click += homeButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Alignment = ToolStripItemAlignment.Right;
            LogOutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LogOutButton.Image = (Image)resources.GetObject("LogOutButton.Image");
            LogOutButton.ImageTransparentColor = Color.Magenta;
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(54, 22);
            LogOutButton.Text = "Log Out";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(changePWbutton);
            groupBox2.Controls.Add(changePWTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 131);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Change Password";
            // 
            // changePWbutton
            // 
            changePWbutton.Location = new Point(175, 78);
            changePWbutton.Name = "changePWbutton";
            changePWbutton.Size = new Size(123, 29);
            changePWbutton.TabIndex = 9;
            changePWbutton.Text = "Change Password";
            changePWbutton.UseVisualStyleBackColor = true;
            changePWbutton.Click += changePWbutton_Click;
            // 
            // changePWTextBox
            // 
            changePWTextBox.Location = new Point(119, 39);
            changePWTextBox.Name = "changePWTextBox";
            changePWTextBox.Size = new Size(179, 23);
            changePWTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 6;
            label1.Text = "Change Password : ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MyAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(354, 434);
            Controls.Add(groupBox2);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Name = "MyAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyAccount";
            Load += MyAccount_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label balanceLable;
        private DateTimePicker dateTimePicker;
        private Label dobLabel;
        private Label lNameLabel;
        private Label firstNameLable;
        private Label nameLabel;
        private Label printBalanceLabel;
        private Label printIdLabel;
        private TextBox lNameTextBox;
        private TextBox fNameTextBox;
        private ToolStrip toolStrip1;
        private ToolStripButton homeButton;
        private GroupBox groupBox2;
        private ToolStripButton LogOutButton;
        private TextBox changePWTextBox;
        private Label label1;
        private Button changePWbutton;
        private Button saveChangeButton;
        private ErrorProvider errorProvider1;
    }
}