using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class AdminReport : Form
    {
        private double inventoryValue;
        private int numOfCusts;
        public AdminReport(double inventoryValue, int numOfCusts)
        {
            InitializeComponent();
            this.inventoryValue = inventoryValue;
            this.numOfCusts = numOfCusts;
        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
            InventoryValue.Text = $"Total inventory value ($): {inventoryValue.ToString()}";
            NumOfCust.Text = $"Total number of customer(s): {numOfCusts.ToString()}";
        }
    }
}
