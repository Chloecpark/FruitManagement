namespace Assignment2
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            CartButton = new Button();
            toolStrip1 = new ToolStrip();
            HomeButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            organicMenuItem = new ToolStripMenuItem();
            organicSubMenuItem = new ToolStripMenuItem();
            nonOrganicSubMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            LogOutButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            myAccountButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            UserNameLabel = new ToolStripLabel();
            FAQButton = new ToolStripButton();
            AddToButton = new Button();
            fruitTable = new DataGridView();
            check = new DataGridViewCheckBoxColumn();
            FruitId = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewComboBoxColumn();
            organic = new DataGridViewTextBoxColumn();
            colour = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fruitTable).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(13, 48);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(306, 23);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.KeyDown += SearchTextBox_KeyDown;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(325, 44);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(80, 29);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // CartButton
            // 
            CartButton.Location = new Point(598, 44);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(82, 29);
            CartButton.TabIndex = 3;
            CartButton.Text = "Cart";
            CartButton.UseVisualStyleBackColor = true;
            CartButton.Click += CartButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { HomeButton, toolStripSeparator2, toolStripDropDownButton1, toolStripSeparator1, LogOutButton, toolStripSeparator4, myAccountButton, toolStripSeparator3, UserNameLabel, FAQButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(697, 27);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // HomeButton
            // 
            HomeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.ImageTransparentColor = Color.Magenta;
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(44, 24);
            HomeButton.Text = "Home";
            HomeButton.Click += HomeButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { organicMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(70, 24);
            toolStripDropDownButton1.Text = "Inventory";
            // 
            // organicMenuItem
            // 
            organicMenuItem.DropDownItems.AddRange(new ToolStripItem[] { organicSubMenuItem, nonOrganicSubMenuItem });
            organicMenuItem.Name = "organicMenuItem";
            organicMenuItem.Size = new Size(119, 22);
            organicMenuItem.Text = "Filter by:";
            // 
            // organicSubMenuItem
            // 
            organicSubMenuItem.Name = "organicSubMenuItem";
            organicSubMenuItem.Size = new Size(144, 22);
            organicSubMenuItem.Text = "Organic";
            organicSubMenuItem.Click += organicSubMenuItem_Click;
            // 
            // nonOrganicSubMenuItem
            // 
            nonOrganicSubMenuItem.Name = "nonOrganicSubMenuItem";
            nonOrganicSubMenuItem.Size = new Size(144, 22);
            nonOrganicSubMenuItem.Text = "Non-Organic";
            nonOrganicSubMenuItem.Click += nonOrganicSubMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // LogOutButton
            // 
            LogOutButton.Alignment = ToolStripItemAlignment.Right;
            LogOutButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LogOutButton.Image = (Image)resources.GetObject("LogOutButton.Image");
            LogOutButton.ImageTransparentColor = Color.Magenta;
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(54, 24);
            LogOutButton.Text = "Log Out";
            LogOutButton.Click += LogOutButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // myAccountButton
            // 
            myAccountButton.Alignment = ToolStripItemAlignment.Right;
            myAccountButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            myAccountButton.Image = (Image)resources.GetObject("myAccountButton.Image");
            myAccountButton.ImageTransparentColor = Color.Magenta;
            myAccountButton.Name = "myAccountButton";
            myAccountButton.Size = new Size(24, 24);
            myAccountButton.Text = "My Account";
            myAccountButton.Click += myAccountButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // UserNameLabel
            // 
            UserNameLabel.Alignment = ToolStripItemAlignment.Right;
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(90, 24);
            UserNameLabel.Text = "logged in name";
            // 
            // FAQButton
            // 
            FAQButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FAQButton.Image = (Image)resources.GetObject("FAQButton.Image");
            FAQButton.ImageTransparentColor = Color.Magenta;
            FAQButton.Name = "FAQButton";
            FAQButton.Size = new Size(33, 24);
            FAQButton.Text = "FAQ";
            FAQButton.Click += FAQButton_Click;
            // 
            // AddToButton
            // 
            AddToButton.Location = new Point(572, 429);
            AddToButton.Name = "AddToButton";
            AddToButton.Size = new Size(113, 33);
            AddToButton.TabIndex = 8;
            AddToButton.Text = "Add to Cart";
            AddToButton.UseVisualStyleBackColor = true;
            AddToButton.Click += AddToButton_Click;
            // 
            // fruitTable
            // 
            fruitTable.AllowDrop = true;
            fruitTable.AllowUserToAddRows = false;
            fruitTable.AllowUserToDeleteRows = false;
            fruitTable.AllowUserToResizeColumns = false;
            fruitTable.BackgroundColor = Color.White;
            fruitTable.BorderStyle = BorderStyle.None;
            fruitTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fruitTable.Columns.AddRange(new DataGridViewColumn[] { check, FruitId, name, price, quantity, organic, colour });
            fruitTable.Location = new Point(12, 96);
            fruitTable.Name = "fruitTable";
            fruitTable.RowHeadersVisible = false;
            fruitTable.RowHeadersWidth = 51;
            fruitTable.RowTemplate.Height = 25;
            fruitTable.Size = new Size(668, 315);
            fruitTable.TabIndex = 9;
            fruitTable.TabStop = false;
            // 
            // check
            // 
            check.Frozen = true;
            check.HeaderText = "";
            check.MinimumWidth = 6;
            check.Name = "check";
            check.Resizable = DataGridViewTriState.False;
            check.Width = 25;
            // 
            // FruitId
            // 
            FruitId.Frozen = true;
            FruitId.HeaderText = "ID";
            FruitId.MinimumWidth = 6;
            FruitId.Name = "FruitId";
            FruitId.ReadOnly = true;
            FruitId.Width = 40;
            // 
            // name
            // 
            name.Frozen = true;
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            name.Width = 125;
            // 
            // price
            // 
            price.Frozen = true;
            price.HeaderText = "Price ($)";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Resizable = DataGridViewTriState.False;
            price.Width = 125;
            // 
            // quantity
            // 
            quantity.Frozen = true;
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Resizable = DataGridViewTriState.False;
            quantity.SortMode = DataGridViewColumnSortMode.Automatic;
            quantity.Width = 125;
            // 
            // organic
            // 
            organic.Frozen = true;
            organic.HeaderText = "Organic";
            organic.MinimumWidth = 6;
            organic.Name = "organic";
            organic.ReadOnly = true;
            organic.Resizable = DataGridViewTriState.False;
            organic.Width = 125;
            // 
            // colour
            // 
            colour.Frozen = true;
            colour.HeaderText = "Colour";
            colour.MinimumWidth = 6;
            colour.Name = "colour";
            colour.ReadOnly = true;
            colour.Resizable = DataGridViewTriState.False;
            colour.Width = 125;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(697, 474);
            Controls.Add(fruitTable);
            Controls.Add(AddToButton);
            Controls.Add(toolStrip1);
            Controls.Add(CartButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Name = "CustomerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Menu";
            Load += CustomerMenu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fruitTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button CartButton;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel UserNameLabel;
        private ToolStripButton LogOutButton;
        private ToolStripMenuItem organicMenuItem;
        private ToolStripMenuItem organicSubMenuItem;
        private ToolStripMenuItem nonOrganicSubMenuItem;
        private Button AddToButton;
        private DataGridView fruitTable;
        private ToolStripButton HomeButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton myAccountButton;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn FruitId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewComboBoxColumn quantity;
        private DataGridViewTextBoxColumn organic;
        private DataGridViewTextBoxColumn colour;
        private ToolStripButton FAQButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
    }
}