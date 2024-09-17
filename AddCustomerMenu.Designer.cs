namespace Assignment2
{
    partial class AddCustomerMenu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerMenu));
            CustomerGrid = new DataGridView();
            cID = new DataGridViewTextBoxColumn();
            fName = new DataGridViewTextBoxColumn();
            lName = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            balance = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            cAddButton = new DataGridViewButtonColumn();
            toolStrip1 = new ToolStrip();
            homeButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerGrid
            // 
            CustomerGrid.AllowUserToAddRows = false;
            CustomerGrid.AllowUserToResizeColumns = false;
            CustomerGrid.BackgroundColor = Color.White;
            CustomerGrid.BorderStyle = BorderStyle.None;
            CustomerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGrid.Columns.AddRange(new DataGridViewColumn[] { cID, fName, lName, dob, balance, password, cAddButton });
            CustomerGrid.Location = new Point(12, 32);
            CustomerGrid.Name = "CustomerGrid";
            CustomerGrid.RowHeadersVisible = false;
            CustomerGrid.RowHeadersWidth = 51;
            CustomerGrid.RowTemplate.Height = 25;
            CustomerGrid.Size = new Size(807, 52);
            CustomerGrid.TabIndex = 15;
            CustomerGrid.CellContentClick += CustomerGrid_CellContentClick;
            // 
            // cID
            // 
            cID.HeaderText = "Id";
            cID.MinimumWidth = 6;
            cID.Name = "cID";
            cID.ReadOnly = true;
            cID.Resizable = DataGridViewTriState.False;
            // 
            // fName
            // 
            fName.HeaderText = "First Name";
            fName.MinimumWidth = 6;
            fName.Name = "fName";
            fName.Resizable = DataGridViewTriState.False;
            fName.Width = 125;
            // 
            // lName
            // 
            lName.HeaderText = "Last Name";
            lName.MinimumWidth = 6;
            lName.Name = "lName";
            lName.Resizable = DataGridViewTriState.False;
            lName.Width = 125;
            // 
            // dob
            // 
            dob.HeaderText = "Date of Birth";
            dob.MinimumWidth = 6;
            dob.Name = "dob";
            dob.Resizable = DataGridViewTriState.False;
            dob.Width = 125;
            // 
            // balance
            // 
            balance.HeaderText = "Balance";
            balance.MinimumWidth = 6;
            balance.Name = "balance";
            balance.Resizable = DataGridViewTriState.False;
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // cAddButton
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            cAddButton.DefaultCellStyle = dataGridViewCellStyle1;
            cAddButton.HeaderText = "";
            cAddButton.MinimumWidth = 6;
            cAddButton.Name = "cAddButton";
            cAddButton.ReadOnly = true;
            cAddButton.Resizable = DataGridViewTriState.False;
            cAddButton.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Items.AddRange(new ToolStripItem[] { homeButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(821, 25);
            toolStrip1.TabIndex = 16;
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
            // AddCustomerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(821, 105);
            Controls.Add(toolStrip1);
            Controls.Add(CustomerGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCustomerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomerMenu";
            Load += AddCustomerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CustomerGrid;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn fName;
        private DataGridViewTextBoxColumn lName;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn balance;
        private DataGridViewTextBoxColumn password;
        private DataGridViewButtonColumn cAddButton;
        private ToolStrip toolStrip1;
        private ToolStripButton homeButton;
    }
}