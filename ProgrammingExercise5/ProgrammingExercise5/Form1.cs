using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variables
        int maxYears = 100; //Variable to hold max number of years in comboBox
        int thisYear = DateTime.Now.Year; // Variable to hold current year
        int i; // variable for loop incrementing

        // When the Application Loads... invoke these methods..
        private void Form1_Load(object sender, EventArgs e)
        {
            setYears();
            setMonths();
            setColor();
            setDefault();
        }

        // The setDefault method sets the combo boxes to no selection default
        private void setDefault()
        {
            YearComboBox.SelectedIndex = 0;
            MonthComboBox.SelectedIndex = 0;
            DayComboBox.SelectedIndex = 0;
            ColorComboBox.SelectedIndex = 0;
        }

        //setColor adds these colors to the combo box
        private void setColor()
        {
            ColorComboBox.Items.Add("Red");
            ColorComboBox.Items.Add("Yellow");
            ColorComboBox.Items.Add("Green");
            ColorComboBox.Items.Add("Blue");
            ColorComboBox.Items.Add("Pink");
            ColorComboBox.Items.Add("Purple");
            ColorComboBox.Items.Add("Orange");
            ColorComboBox.Items.Add("Brown");
            ColorComboBox.Items.Add("Black");
            ColorComboBox.Items.Add("Gray");
            ColorComboBox.Items.Add("Beige");
            ColorComboBox.Items.Add("Teal");
            ColorComboBox.Items.Add("Indigo");
            ColorComboBox.Items.Add("Baby Blue");
            ColorComboBox.Items.Add("Baby Pink");
            ColorComboBox.Items.Add("Lavender");
        }

        //set months adds these months to the combo box
        private void setMonths()
        {
            MonthComboBox.Items.Add("January");
            MonthComboBox.Items.Add("February");
            MonthComboBox.Items.Add("March");
            MonthComboBox.Items.Add("April");
            MonthComboBox.Items.Add("May");
            MonthComboBox.Items.Add("June");
            MonthComboBox.Items.Add("July");
            MonthComboBox.Items.Add("August");
            MonthComboBox.Items.Add("September");
            MonthComboBox.Items.Add("October");
            MonthComboBox.Items.Add("November");
            MonthComboBox.Items.Add("December");
        }

        // setYears figures out what year it is and then populates
        // the nexy 100 in the combo box
        private void setYears()
        {
            while (maxYears > 0)
            {
                YearComboBox.Items.Add(thisYear.ToString());
                thisYear--;
                maxYears--;
            }
        }
        // Not used
        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do Nothing
        }

        // Calculates the Lucky Number and shows it on the other form
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            var luckyNumber = rand.Next(100);
            Form2 form2 = new Form2(luckyNumber);
            form2.ShowDialog();
        }

        // When the month comboBox is selected, it populates the correct number of days in the dayComboBox depending on that selection
        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(YearComboBox.SelectedItem.ToString());
                int month = DateTime.ParseExact(MonthComboBox.SelectedItem.ToString(), "MMMM", CultureInfo.InvariantCulture).Month;
                int days = DateTime.DaysInMonth(year, month);
                DayComboBox.Items.Clear();
                for (i = 0; i < days; i++)
                {
                    DayComboBox.Items.Add((i + 1).ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        // Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
