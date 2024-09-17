namespace Assignment2
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            LogOutButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            UserNameLabel = new ToolStripLabel();
            InventoryButton = new ToolStripDropDownButton();
            organicToolStripMenuItem = new ToolStripMenuItem();
            nonOrganicToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            CustomerButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ReportButton = new ToolStripButton();
            inventoryGrid = new DataGridView();
            addCButton = new Button();
            addFButton = new Button();
            deleteCButton = new Button();
            deleteFButton = new Button();
            CustomerGrid = new DataGridView();
            SearchCButton = new Button();
            SearchCTextBox = new TextBox();
            SearchFButton = new Button();
            SearchFTextBox = new TextBox();
            checkFruit = new DataGridViewCheckBoxColumn();
            fruitId = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            organic = new DataGridViewTextBoxColumn();
            colour = new DataGridViewTextBoxColumn();
            fEditButton = new DataGridViewButtonColumn();
            check = new DataGridViewCheckBoxColumn();
            cID = new DataGridViewTextBoxColumn();
            fName = new DataGridViewTextBoxColumn();
            lName = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            balance = new DataGridViewTextBoxColumn();
            cEditButton = new DataGridViewButtonColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { LogOutButton, toolStripSeparator2, UserNameLabel, InventoryButton, toolStripSeparator1, CustomerButton, toolStripSeparator3, ReportButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(738, 25);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // UserNameLabel
            // 
            UserNameLabel.Alignment = ToolStripItemAlignment.Right;
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(90, 22);
            UserNameLabel.Text = "logged in name";
            // 
            // InventoryButton
            // 
            InventoryButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            InventoryButton.DropDownItems.AddRange(new ToolStripItem[] { organicToolStripMenuItem, nonOrganicToolStripMenuItem });
            InventoryButton.Image = (Image)resources.GetObject("InventoryButton.Image");
            InventoryButton.ImageTransparentColor = Color.Magenta;
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(70, 22);
            InventoryButton.Text = "Inventory";
            InventoryButton.Click += InventoryButton_Click;
            // 
            // organicToolStripMenuItem
            // 
            organicToolStripMenuItem.Name = "organicToolStripMenuItem";
            organicToolStripMenuItem.Size = new Size(144, 22);
            organicToolStripMenuItem.Text = "Organic";
            organicToolStripMenuItem.Click += organicToolStripMenuItem_Click;
            // 
            // nonOrganicToolStripMenuItem
            // 
            nonOrganicToolStripMenuItem.Name = "nonOrganicToolStripMenuItem";
            nonOrganicToolStripMenuItem.Size = new Size(144, 22);
            nonOrganicToolStripMenuItem.Text = "Non-Organic";
            nonOrganicToolStripMenuItem.Click += nonOrganicToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // CustomerButton
            // 
            CustomerButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            CustomerButton.Image = (Image)resources.GetObject("CustomerButton.Image");
            CustomerButton.ImageTransparentColor = Color.Magenta;
            CustomerButton.Name = "CustomerButton";
            CustomerButton.Size = new Size(63, 22);
            CustomerButton.Text = "Customer";
            CustomerButton.Click += CustomerButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // ReportButton
            // 
            ReportButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageTransparentColor = Color.Magenta;
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(46, 22);
            ReportButton.Text = "Report";
            ReportButton.Click += ReportButton_Click;
            // 
            // inventoryGrid
            // 
            inventoryGrid.AllowUserToAddRows = false;
            inventoryGrid.AllowUserToResizeColumns = false;
            inventoryGrid.BackgroundColor = SystemColors.Control;
            inventoryGrid.BorderStyle = BorderStyle.None;
            inventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Columns.AddRange(new DataGridViewColumn[] { checkFruit, fruitId, name, price, stock, organic, colour, fEditButton });
            inventoryGrid.Location = new Point(11, 57);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.RowHeadersVisible = false;
            inventoryGrid.RowHeadersWidth = 51;
            inventoryGrid.RowTemplate.Height = 25;
            inventoryGrid.Size = new Size(725, 381);
            inventoryGrid.TabIndex = 13;
            inventoryGrid.CellContentClick += inventoryGrid_CellContentClick;
            // 
            // addCButton
            // 
            addCButton.Location = new Point(500, 28);
            addCButton.Name = "addCButton";
            addCButton.Size = new Size(107, 23);
            addCButton.TabIndex = 15;
            addCButton.Text = "Add Customer";
            addCButton.UseVisualStyleBackColor = true;
            addCButton.Click += addCButton_Click;
            // 
            // addFButton
            // 
            addFButton.Location = new Point(500, 29);
            addFButton.Name = "addFButton";
            addFButton.Size = new Size(107, 23);
            addFButton.TabIndex = 16;
            addFButton.Text = "Add Fruit";
            addFButton.UseVisualStyleBackColor = true;
            addFButton.Click += addFButton_Click;
            // 
            // deleteCButton
            // 
            deleteCButton.Location = new Point(612, 28);
            deleteCButton.Name = "deleteCButton";
            deleteCButton.Size = new Size(107, 23);
            deleteCButton.TabIndex = 17;
            deleteCButton.Text = "Delete Customer";
            deleteCButton.UseVisualStyleBackColor = true;
            deleteCButton.Click += deleteCButton_Click;
            // 
            // deleteFButton
            // 
            deleteFButton.Location = new Point(612, 29);
            deleteFButton.Name = "deleteFButton";
            deleteFButton.Size = new Size(107, 23);
            deleteFButton.TabIndex = 18;
            deleteFButton.Text = "Delete Fruit";
            deleteFButton.UseVisualStyleBackColor = true;
            deleteFButton.Click += deleteFButton_Click;
            // 
            // CustomerGrid
            // 
            CustomerGrid.AllowUserToAddRows = false;
            CustomerGrid.AllowUserToResizeColumns = false;
            CustomerGrid.BackgroundColor = Color.White;
            CustomerGrid.BorderStyle = BorderStyle.None;
            CustomerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGrid.Columns.AddRange(new DataGridViewColumn[] { check, cID, fName, lName, dob, balance, cEditButton });
            CustomerGrid.Location = new Point(11, 58);
            CustomerGrid.Name = "CustomerGrid";
            CustomerGrid.RowHeadersVisible = false;
            CustomerGrid.RowHeadersWidth = 51;
            CustomerGrid.RowTemplate.Height = 25;
            CustomerGrid.Size = new Size(725, 319);
            CustomerGrid.TabIndex = 14;
            CustomerGrid.CellContentClick += CustomerGrid_CellContentClick;
            // 
            // SearchCButton
            // 
            SearchCButton.Location = new Point(292, 28);
            SearchCButton.Name = "SearchCButton";
            SearchCButton.Size = new Size(75, 23);
            SearchCButton.TabIndex = 22;
            SearchCButton.Text = "Search";
            SearchCButton.UseVisualStyleBackColor = true;
            SearchCButton.Click += SearchCButton_Click;
            // 
            // SearchCTextBox
            // 
            SearchCTextBox.Location = new Point(12, 28);
            SearchCTextBox.Name = "SearchCTextBox";
            SearchCTextBox.Size = new Size(265, 23);
            SearchCTextBox.TabIndex = 21;
            SearchCTextBox.KeyDown += SearchCTextBox_KeyDown;
            // 
            // SearchFButton
            // 
            SearchFButton.Location = new Point(292, 28);
            SearchFButton.Name = "SearchFButton";
            SearchFButton.Size = new Size(75, 23);
            SearchFButton.TabIndex = 24;
            SearchFButton.Text = "Search";
            SearchFButton.UseVisualStyleBackColor = true;
            SearchFButton.Click += SearchFButton_Click;
            // 
            // SearchFTextBox
            // 
            SearchFTextBox.Location = new Point(11, 29);
            SearchFTextBox.Name = "SearchFTextBox";
            SearchFTextBox.Size = new Size(265, 23);
            SearchFTextBox.TabIndex = 23;
            SearchFTextBox.KeyDown += SearchFTextBox_KeyDown;
            // 
            // checkFruit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.NullValue = false;
            checkFruit.DefaultCellStyle = dataGridViewCellStyle1;
            checkFruit.HeaderText = "";
            checkFruit.MinimumWidth = 6;
            checkFruit.Name = "checkFruit";
            checkFruit.Resizable = DataGridViewTriState.False;
            checkFruit.Width = 25;
            // 
            // fruitId
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            fruitId.DefaultCellStyle = dataGridViewCellStyle2;
            fruitId.HeaderText = "Id";
            fruitId.MinimumWidth = 6;
            fruitId.Name = "fruitId";
            fruitId.ReadOnly = true;
            fruitId.Resizable = DataGridViewTriState.False;
            fruitId.Width = 40;
            // 
            // name
            // 
            name.HeaderText = "Fruit Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Resizable = DataGridViewTriState.False;
            name.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price ($)";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Resizable = DataGridViewTriState.False;
            // 
            // stock
            // 
            stock.HeaderText = "Quantity";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.Resizable = DataGridViewTriState.False;
            // 
            // organic
            // 
            organic.HeaderText = "Organic";
            organic.MinimumWidth = 6;
            organic.Name = "organic";
            organic.Resizable = DataGridViewTriState.False;
            // 
            // colour
            // 
            colour.HeaderText = "Colour";
            colour.MinimumWidth = 6;
            colour.Name = "colour";
            colour.Resizable = DataGridViewTriState.False;
            colour.Width = 125;
            // 
            // fEditButton
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.ForeColor = Color.White;
            fEditButton.DefaultCellStyle = dataGridViewCellStyle3;
            fEditButton.HeaderText = "";
            fEditButton.MinimumWidth = 6;
            fEditButton.Name = "fEditButton";
            fEditButton.ReadOnly = true;
            fEditButton.Resizable = DataGridViewTriState.False;
            fEditButton.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // check
            // 
            check.HeaderText = "";
            check.MinimumWidth = 6;
            check.Name = "check";
            check.Resizable = DataGridViewTriState.False;
            check.SortMode = DataGridViewColumnSortMode.Automatic;
            check.Width = 25;
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
            balance.Width = 115;
            // 
            // cEditButton
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 255);
            cEditButton.DefaultCellStyle = dataGridViewCellStyle4;
            cEditButton.HeaderText = "";
            cEditButton.MinimumWidth = 6;
            cEditButton.Name = "cEditButton";
            cEditButton.ReadOnly = true;
            cEditButton.Resizable = DataGridViewTriState.False;
            cEditButton.Text = "";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(738, 450);
            Controls.Add(SearchFButton);
            Controls.Add(SearchFTextBox);
            Controls.Add(SearchCButton);
            Controls.Add(SearchCTextBox);
            Controls.Add(addFButton);
            Controls.Add(deleteFButton);
            Controls.Add(deleteCButton);
            Controls.Add(CustomerGrid);
            Controls.Add(inventoryGrid);
            Controls.Add(addCButton);
            Controls.Add(toolStrip1);
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripLabel UserNameLabel;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView inventoryGrid;
        private Button addCButton;
        private Button addFButton;
        private Button deleteCButton;
        private Button deleteFButton;
        private DataGridView CustomerGrid;
        private ToolStripButton LogOutButton;
        private ToolStripSeparator toolStripSeparator2;
        private Button SearchCButton;
        private TextBox SearchCTextBox;
        private Button SearchFButton;
        private TextBox SearchFTextBox;
        private ToolStripButton ReportButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton InventoryButton;
        private ToolStripMenuItem organicToolStripMenuItem;
        private ToolStripMenuItem nonOrganicToolStripMenuItem;
        private ToolStripButton CustomerButton;
        private DataGridViewCheckBoxColumn checkFruit;
        private DataGridViewTextBoxColumn fruitId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn organic;
        private DataGridViewTextBoxColumn colour;
        private DataGridViewButtonColumn fEditButton;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn fName;
        private DataGridViewTextBoxColumn lName;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn balance;
        private DataGridViewButtonColumn cEditButton;
    }
}