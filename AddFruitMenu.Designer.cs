namespace Assignment2
{
    partial class AddFruitMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFruitMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            inventoryGrid = new DataGridView();
            toolStrip1 = new ToolStrip();
            homeButton = new ToolStripButton();
            fruitId = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            organic = new DataGridViewComboBoxColumn();
            colour = new DataGridViewTextBoxColumn();
            fAddButton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryGrid
            // 
            inventoryGrid.AllowUserToAddRows = false;
            inventoryGrid.AllowUserToResizeColumns = false;
            inventoryGrid.BackgroundColor = Color.White;
            inventoryGrid.BorderStyle = BorderStyle.None;
            inventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Columns.AddRange(new DataGridViewColumn[] { fruitId, name, price, stock, organic, colour, fAddButton });
            inventoryGrid.Location = new Point(12, 28);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.RowHeadersVisible = false;
            inventoryGrid.RowHeadersWidth = 51;
            inventoryGrid.RowTemplate.Height = 25;
            inventoryGrid.Size = new Size(699, 58);
            inventoryGrid.TabIndex = 14;
            inventoryGrid.CellContentClick += inventoryGrid_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Items.AddRange(new ToolStripItem[] { homeButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(713, 25);
            toolStrip1.TabIndex = 17;
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
            // fruitId
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            fruitId.DefaultCellStyle = dataGridViewCellStyle1;
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
            price.HeaderText = "Price";
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
            organic.Items.AddRange(new object[] { "True", "False" });
            organic.MinimumWidth = 6;
            organic.Name = "organic";
            organic.Resizable = DataGridViewTriState.False;
            organic.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colour
            // 
            colour.HeaderText = "Colour";
            colour.MinimumWidth = 6;
            colour.Name = "colour";
            colour.Resizable = DataGridViewTriState.False;
            colour.Width = 125;
            // 
            // fAddButton
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 255);
            fAddButton.DefaultCellStyle = dataGridViewCellStyle2;
            fAddButton.HeaderText = "";
            fAddButton.MinimumWidth = 6;
            fAddButton.Name = "fAddButton";
            fAddButton.ReadOnly = true;
            fAddButton.Resizable = DataGridViewTriState.False;
            fAddButton.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AddFruitMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 113);
            Controls.Add(toolStrip1);
            Controls.Add(inventoryGrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddFruitMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFruitMenu";
            Load += AddFruitMenu_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView inventoryGrid;
        private ToolStrip toolStrip1;
        private ToolStripButton homeButton;
        private DataGridViewTextBoxColumn fruitId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewComboBoxColumn organic;
        private DataGridViewTextBoxColumn colour;
        private DataGridViewButtonColumn fAddButton;
    }
}