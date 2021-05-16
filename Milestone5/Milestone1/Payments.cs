using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* * * * * * * * * * * * *
 * * Warren Peterson * * *
 * This is my Own Work * *
 * CST-117 5/15/2021 * * *
 * * * Milestone 5 * * * *
 * * * * * * * * * * * * */
namespace Milestone2
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }// End of method

        // Inventory Button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory i1 = new Inventory();
            i1.ShowDialog();
        }// End of method

        // Customers Button
        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c1 = new Customer();
            c1.ShowDialog();
        }// End of method

        // Stores Button
        private void StoresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stores s1 = new Stores();
            s1.ShowDialog();
        }// End of method
    }
}
