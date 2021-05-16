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
    public partial class Stores : Form
    {
        public Stores()
        {
            InitializeComponent();
        }// End of method

        // Inventory Button
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory i1 = new Inventory();
            i1.ShowDialog();
        }// End of method

        // Payments Button
        private void PaymentsButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Payments p1 = new Payments();
            p1.ShowDialog();
        }// End of method

        // Stores Button
        private void StoresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c1 = new Customer();
            c1.ShowDialog();
        }// End of method
    }
}
