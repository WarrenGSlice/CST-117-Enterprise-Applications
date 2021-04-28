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
 * This is my own work * *
 * 4/21/2021 CST-117 * * *
 * Exercise 8  * * * * * *
 * Calorie Calculator App*
 * * * * * * * * * * * * *
 * * * * * * * * * * * * */
namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* * This is the Calculate Calories Button * * * * * * * * */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variable Declarations
            int carbCalories = CarbCalories(); // Declares the variable carbCalories will be set to the result from the CarbCalorie Method
            int fatCalories = FatCalories(); // This variable will be used to hold the result from the FatCalories method
            int sum = carbCalories + fatCalories; // This variable will be used to hold the sum of the results from both methods
            CaloriesFromCarbsOutput.Text = carbCalories.ToString(); //  Outputs result
            CaloriesFromFatOutput.Text = fatCalories.ToString(); // Outputs results
            TotslCaloriesOutput.Text = sum.ToString(); // Displays Result

        }
        // The CarbCalories Method
        private int CarbCalories()
        {
            // Variables
            int carbs; // This variable will hold the carb gram input integer
            bool result = Int32.TryParse(CarbsInput.Text, out carbs); // Creates variable to hold result
            // This loop will return true if there is a result and will return false(0) if there is no result and display an error
            if (result)
            {
                return carbs * 4;
            }
            else
            {
                MessageBox.Show("Invalid Input, Please enter a number");
                return 0;
            }
        }
        // The Fat Calories Method
        private int FatCalories()
        {
            // Variables
            int fat; // Variable to hold the fat grams input integer
            bool result = Int32.TryParse(FatGramsInput.Text, out fat); // Variable to hold result
            // This loop will return true if there is a result and will return false(0) if there is no result and display an error
            if (result)
            {
                return fat * 9;
            }
            else
            {
                MessageBox.Show("Invalid Entry, Please Enter a real Number Sir");
                return 0;
            }
        }
        // Exit Program Method
        private void ExitProgram()
        {
            this.Close();
        }
        // Clear Fields Method
        private void ResetProgram()
        {
            CarbsInput.Text = "";
            CaloriesFromCarbsOutput.Text = "";
            FatGramsInput.Text = "";
            CaloriesFromFatOutput.Text = "";
            TotslCaloriesOutput.Text = "";
        }
        // Exit button invokes Exit Program method
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }
        // Reset Button invokes Clear Fields method
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetProgram();
        }
    }
}
