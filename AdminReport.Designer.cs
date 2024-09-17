namespace Assignment2
{
    partial class AdminReport
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
            ReportLabel = new Label();
            InventoryValue = new Label();
            NumOfCust = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ReportLabel
            // 
            ReportLabel.AutoSize = true;
            ReportLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ReportLabel.Location = new Point(52, 10);
            ReportLabel.Name = "ReportLabel";
            ReportLabel.Size = new Size(133, 47);
            ReportLabel.TabIndex = 0;
            ReportLabel.Text = "Report";
            // 
            // InventoryValue
            // 
            InventoryValue.AutoSize = true;
            InventoryValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            InventoryValue.Location = new Point(12, 78);
            InventoryValue.Name = "InventoryValue";
            InventoryValue.Size = new Size(70, 25);
            InventoryValue.TabIndex = 1;
            InventoryValue.Text = "Money";
            // 
            // NumOfCust
            // 
            NumOfCust.AutoSize = true;
            NumOfCust.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NumOfCust.Location = new Point(12, 120);
            NumOfCust.Name = "NumOfCust";
            NumOfCust.Size = new Size(142, 25);
            NumOfCust.TabIndex = 2;
            NumOfCust.Text = "NumCustomers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.business_report;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(353, 168);
            Controls.Add(pictureBox1);
            Controls.Add(NumOfCust);
            Controls.Add(InventoryValue);
            Controls.Add(ReportLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminReport";
            Load += AdminReport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReportLabel;
        private Label InventoryValue;
        private Label NumOfCust;
        private PictureBox pictureBox1;
    }
}