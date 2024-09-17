namespace Assignment2
{
    partial class CartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartWindow));
            cartGrid = new DataGridView();
            fID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            organic = new DataGridViewTextBoxColumn();
            colour = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            totalPriceLabel = new Label();
            checkOutButton = new Button();
            toolStrip1 = new ToolStrip();
            homeButton = new ToolStripButton();
            balanceLabel = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.AllowUserToDeleteRows = false;
            cartGrid.AllowUserToResizeColumns = false;
            cartGrid.BackgroundColor = Color.White;
            cartGrid.BorderStyle = BorderStyle.None;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Columns.AddRange(new DataGridViewColumn[] { fID, name, quantity, price, organic, colour, totalPrice });
            cartGrid.Location = new Point(12, 28);
            cartGrid.Name = "cartGrid";
            cartGrid.ReadOnly = true;
            cartGrid.RowHeadersVisible = false;
            cartGrid.RowHeadersWidth = 51;
            cartGrid.RowTemplate.Height = 25;
            cartGrid.Size = new Size(728, 238);
            cartGrid.TabIndex = 0;
            // 
            // fID
            // 
            fID.HeaderText = "ID";
            fID.MinimumWidth = 6;
            fID.Name = "fID";
            fID.ReadOnly = true;
            fID.Width = 50;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Resizable = DataGridViewTriState.True;
            // 
            // price
            // 
            price.HeaderText = "Price ($)";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // organic
            // 
            organic.HeaderText = "Organic";
            organic.MinimumWidth = 6;
            organic.Name = "organic";
            organic.ReadOnly = true;
            // 
            // colour
            // 
            colour.HeaderText = "Colour";
            colour.MinimumWidth = 6;
            colour.Name = "colour";
            colour.ReadOnly = true;
            colour.Width = 125;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "Total Price ($)";
            totalPrice.MinimumWidth = 6;
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Width = 125;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(475, 269);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(91, 21);
            totalPriceLabel.TabIndex = 2;
            totalPriceLabel.Text = "Total Price : ";
            // 
            // checkOutButton
            // 
            checkOutButton.BackColor = Color.White;
            checkOutButton.Location = new Point(636, 265);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(104, 30);
            checkOutButton.TabIndex = 4;
            checkOutButton.Text = "Check Out";
            checkOutButton.UseVisualStyleBackColor = false;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { homeButton, balanceLabel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(752, 25);
            toolStrip1.TabIndex = 5;
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
            // balanceLabel
            // 
            balanceLabel.Alignment = ToolStripItemAlignment.Right;
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(112, 22);
            balanceLabel.Text = "Customer Balance : ";
            // 
            // CartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(752, 315);
            Controls.Add(toolStrip1);
            Controls.Add(checkOutButton);
            Controls.Add(totalPriceLabel);
            Controls.Add(cartGrid);
            Name = "CartWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += CartWindow_Load;
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cartGrid;
        private Label totalPriceLabel;
        private Button checkOutButton;
        private ToolStrip toolStrip1;
        private ToolStripButton homeButton;
        private ToolStripLabel balanceLabel;
        private DataGridViewTextBoxColumn fID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn organic;
        private DataGridViewTextBoxColumn colour;
        private DataGridViewTextBoxColumn totalPrice;
    }
}