using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class LargestNumber : Form
    {
        public LargestNumber()
        {
            InitializeComponent();
        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            int.TryParse(number1.Text, out int a);
            int.TryParse(number2.Text, out int b);

            if (a == b)
            {
                MessageBox.Show($"{a} and {b} are equal");
            }
            _ = a > b ? MessageBox.Show($"{a} is the largest number") : MessageBox.Show($"{b} is the largest number");
        }
    }
}
