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
 * Warren Peterson * * * *
 * 5/11/2021 CST-117 * * *
 * ProgrammingExercise5* *
 * Lucky Number Calculator
 * * * * * * * * * * * * */

namespace ProgrammingExercise5
{
    public partial class Form2 : Form
    {
        // Variables
        private int num = 0; // Variable to hold the lucky number

        //Initializing Form and sets the results to the label
        public Form2(int number)
        {
            num = number;
            InitializeComponent();
            YourResultsLabel.Text = num.ToString();
        }
        // Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
