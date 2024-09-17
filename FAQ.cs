using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Assignment2
{
    public partial class FAQ : Form
    {
        List<string> lines;
        public FAQ()
        {
            InitializeComponent();
            faqLabel.Text = string.Join("\n", GetLine());
        }


        // print FAQ
        private List<string> GetLine()
        {
            lines = new List<string>();

            lines.Add(new string("Q. What payment methods are accepted in the online fruit shop system?"));
            lines.Add(new string("A. The system currently accepts payment methods by balance only."));
            lines.Add(new string(""));
            lines.Add(new string("Q. How do I earn balance in the fruit shop system?"));
            lines.Add(new string("A. You have to physically visit our fruity store to top-up the balance. "));
            lines.Add(new string(""));
            lines.Add(new string("Q. Can I check my balance as a customer?"));
            lines.Add(new string("A. Yes, customers can check their balance in my account page or inquiring with shop staff."));
            lines.Add(new string(""));
            lines.Add(new string("Q. Can the admin adjust my balance?"));
            lines.Add(new string("A. Yes, only the admin has the authority to adjust a customer's balance."));
            lines.Add(new string("     If you have a concern about your balance, please contact the admin."));

            return lines;
        }
    }
}
