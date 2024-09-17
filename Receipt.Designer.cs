namespace Assignment2
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            orderCompleted = new Label();
            issueDateLabel = new Label();
            nameLabel = new Label();
            descriptionLabel = new Label();
            totalPriceLabel = new Label();
            balanceLabel = new Label();
            toolStrip1 = new ToolStrip();
            homeButton = new ToolStripButton();
            descriptionFrom = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // orderCompleted
            // 
            orderCompleted.AutoSize = true;
            orderCompleted.FlatStyle = FlatStyle.System;
            orderCompleted.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            orderCompleted.Location = new Point(59, 20);
            orderCompleted.Name = "orderCompleted";
            orderCompleted.Size = new Size(323, 50);
            orderCompleted.TabIndex = 0;
            orderCompleted.Text = "Order Complete !";
            // 
            // issueDateLabel
            // 
            issueDateLabel.AutoSize = true;
            issueDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            issueDateLabel.Location = new Point(12, 88);
            issueDateLabel.Name = "issueDateLabel";
            issueDateLabel.Size = new Size(92, 21);
            issueDateLabel.TabIndex = 1;
            issueDateLabel.Text = "Issue Date : ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 114);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(135, 21);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Customer Name : ";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(12, 235);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(178, 21);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Name \\t\\t Qnty \\t\\t Total\r\n";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(369, 88);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(140, 30);
            totalPriceLabel.TabIndex = 4;
            totalPriceLabel.Text = "Total Price : ";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.Location = new Point(369, 118);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(74, 21);
            balanceLabel.TabIndex = 5;
            balanceLabel.Text = "Balance : ";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { homeButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(601, 25);
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
            // descriptionFrom
            // 
            descriptionFrom.AutoSize = true;
            descriptionFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionFrom.Location = new Point(12, 151);
            descriptionFrom.Name = "descriptionFrom";
            descriptionFrom.Size = new Size(461, 84);
            descriptionFrom.TabIndex = 18;
            descriptionFrom.Text = "Description\r\n=========================================\r\nName           Quantity           Price($)           Total($)\r\n--------------------------------------------------------------------------\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.check;
            pictureBox1.Location = new Point(12, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(601, 450);
            Controls.Add(pictureBox1);
            Controls.Add(descriptionFrom);
            Controls.Add(toolStrip1);
            Controls.Add(balanceLabel);
            Controls.Add(totalPriceLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(issueDateLabel);
            Controls.Add(orderCompleted);
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            Load += Receipt_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderCompleted;
        private Label issueDateLabel;
        private Label nameLabel;
        private Label descriptionLabel;
        private Label totalPriceLabel;
        private Label balanceLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton homeButton;
        private Label descriptionFrom;
        private PictureBox pictureBox1;
    }
}