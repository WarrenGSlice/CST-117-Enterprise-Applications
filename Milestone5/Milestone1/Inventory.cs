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
    public partial class Inventory : Form
    {
        // Creates an InventoryManager class object that allows the methods from that class to be used--Inheritance
        public InventoryManager Im { get; set; } = new InventoryManager();
        private CSVManager CSVManager; // Inherits the CSVManager class and its methods and sets them to this variable
        private static string INVENTORY_LOCATION = "../../InventoryList.csv"; // Sets the location of the Inventory CSV File
        public Inventory()
        {
            InitializeComponent();
        }// end of method

        // Validates the Inputs and checks for null or white space
        private bool ValidateInput()// new change
        {
            return (
                !string.IsNullOrWhiteSpace(VideoIDInventoryControlTextBox.Text) &&
                !string.IsNullOrWhiteSpace(VideoNameInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(QuantityInStockInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(QuantityCheckedOutInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(TotalQuantityInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(MediaTypeInventoryEditComboBox.Text) &&
                !string.IsNullOrWhiteSpace(DownloadTypeInventoryEditComboBox.Text) &&
                !string.IsNullOrWhiteSpace(PriceInventoryEditTextBox.Text) &&
                !string.IsNullOrWhiteSpace(GenreIDInventoryEditTextBox.Text) &&
                !string.IsNullOrWhiteSpace(GenreInventoryEditComboBox.Text) &&
                !string.IsNullOrWhiteSpace(AdultInventoryEditTextBox.Text) &&
                int.TryParse(VideoIDInventoryControlTextBox.Text, out int videoID) &&
                int.TryParse(QuantityInStockInventoryTextBox.Text, out int quantityInStock) &&
                int.TryParse(QuantityCheckedOutInventoryTextBox.Text, out int quantityCheckedOut) &&
                int.TryParse(TotalQuantityInventoryTextBox.Text, out int totalQuantity) &&
                decimal.TryParse(PriceInventoryEditTextBox.Text, out decimal price) &&
                int.TryParse(GenreIDInventoryEditTextBox.Text, out int genreID));
        }// end of method

        // Add Video Button
        private void AddVideoButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//new change
            {
                // Creates a Inventory Item Object
                InventoryItems newItem = new InventoryItems(int.Parse(VideoIDInventoryControlTextBox.Text), VideoNameInventoryTextBox.Text, int.Parse(QuantityInStockInventoryTextBox.Text),
                    int.Parse(QuantityCheckedOutInventoryTextBox.Text), int.Parse(TotalQuantityInventoryTextBox.Text), MediaTypeInventoryEditComboBox.Text,
                    DownloadTypeInventoryEditComboBox.Text, decimal.Parse(PriceInventoryEditTextBox.Text), int.Parse(GenreIDInventoryEditTextBox.Text),
                    GenreInventoryEditComboBox.Text, AdultInventoryEditTextBox.Text);
                Im.AddItem(newItem); //Add the new item to the Inventory Manager
                UpdateInventoryList(); //Updates the Inventory List
                VideoIDInventoryControlTextBox.Text = ""; // Makes the add item edit control text boxes blank after adding a new item
                VideoNameInventoryTextBox.Text = "";
                QuantityInStockInventoryTextBox.Text = "";
                QuantityCheckedOutInventoryTextBox.Text = "";
                TotalQuantityInventoryTextBox.Text = "";
                MediaTypeInventoryEditComboBox.Text = "";
                DownloadTypeInventoryEditComboBox.Text = "";
                PriceInventoryEditTextBox.Text = "";
                GenreIDInventoryEditTextBox.Text = "";
                GenreInventoryEditComboBox.Text = "";
                AdultInventoryEditTextBox.Text = "";
            }
            else //new change
            {
                MessageBox.Show("Please review the fields", "Error on Save");
            }
        }// end of method

        // Remove Video Button
        private void DeleteVideoButton_Click(object sender, EventArgs e)
        {
            if(InventoryListBox.SelectedIndex != -1)
            {
                InventoryItems selectedItem = (InventoryItems)InventoryListBox.SelectedItem;
                Im.RemoveItem(selectedItem);
                UpdateInventoryList();
            }
        }// end of method

        // Restock Video Button
        private void RestockVideoButton_Click(object sender, EventArgs e)
        {
            if(InventoryListBox.SelectedIndex != -1)
            {
                InventoryItems selectedItem = (InventoryItems)InventoryListBox.SelectedItem;
                Im.RestockItem(selectedItem);
                UpdateSelected(selectedItem);
            }
        }// end of method

        // Video ID # Search Button
        private void VideoIDSearchButton_Click(object sender, EventArgs e)
        {
            MediaTypeSearchComboBox.Text = "";
            VideoNameSearchTextBox.Text = "";
            GenreSearchComboBox.Text = "";
            if (string.IsNullOrWhiteSpace(VideoIDSearchTextBox.Text))
            {
                UpdateInventoryList();
            }
            else
            {
                bool videoIdResult = int.TryParse(VideoIDSearchTextBox.Text, out int VideoId);
                if (videoIdResult)
                {
                    UpdateInventoryList(Im.IdSearch(VideoId));
                }
                else
                {
                    UpdateInventoryList(Im.IdSearch(int.Parse(VideoIDSearchTextBox.Text)));
                }
            }
        }// end of method

        // Video Name Search Button
        private void VideoNameSearchButton_Click(object sender, EventArgs e)
        {
            VideoIDSearchTextBox.Text = "";
            MediaTypeSearchComboBox.Text = "";
            GenreSearchComboBox.Text = "";
            if (string.IsNullOrWhiteSpace(VideoNameSearchTextBox.Text))
            {
                UpdateInventoryList();
            }
            else
            {
                bool videoNameResult = decimal.TryParse(VideoNameSearchTextBox.Text, out decimal price);
                if (videoNameResult)
                {
                    UpdateInventoryList(Im.FindItemsUnder(price));
                }
                else
                {
                    UpdateInventoryList(Im.FindItems(VideoNameSearchTextBox.Text, VideoNameSearchTextBox.Text));
                }
            }
        }// end of method

        // Media Type Search Button
        private void MediaTypeSearchButton_Click(object sender, EventArgs e)
        {
            VideoIDSearchTextBox.Text = "";
            VideoNameSearchTextBox.Text = "";
            GenreSearchComboBox.Text = "";
            if (string.IsNullOrWhiteSpace(MediaTypeSearchComboBox.Text))
            {
                UpdateInventoryList();
            }
            else
            {
                bool MediaTypeResult = decimal.TryParse(MediaTypeSearchComboBox.Text, out decimal price);
                if (MediaTypeResult)
                {
                    UpdateInventoryList(Im.FindItemsUnder(price));
                }
                else
                {
                    UpdateInventoryList(Im.MediaSearch(MediaTypeSearchComboBox.Text));
                }
            }
        }// end of method

        // Genre Type Search Button
        private void GenreSearchButton_Click(object sender, EventArgs e)
        {
            VideoIDSearchTextBox.Text = "";
            MediaTypeSearchComboBox.Text = "";
            VideoNameSearchTextBox.Text = "";
            if (string.IsNullOrWhiteSpace(GenreSearchComboBox.Text))
            {
                UpdateInventoryList();
            }
            else
            {
                bool GenreResult = decimal.TryParse(GenreSearchComboBox.Text, out decimal price);
                if (GenreResult)
                {
                    UpdateInventoryList(Im.FindItemsUnder(price));
                }
                else
                {
                    UpdateInventoryList(Im.GenreSearch(GenreSearchComboBox.Text));
                }
            }
        }// end of method

        // Method to Update the Inventory List Box and save the changes
        public void UpdateInventoryList()
        {
            VideoIDSearchTextBox.Text = "";
            VideoNameSearchTextBox.Text = "";
            MediaTypeSearchComboBox.Text = "";
            GenreSearchComboBox.Text = "";
            InventoryListBox.ClearSelected();
            InventoryListBox.Items.Clear();
            foreach (InventoryItems item in Im.Inventory)
            {
                InventoryListBox.Items.Add(item);
            }
            UpdateSelected();
            CSVManager.saveCSV(INVENTORY_LOCATION, Im.GetCSVList());
        }// end of method

        // Method to Update the Inventory List in the InventoryItems class
        private void UpdateInventoryList(List<InventoryItems> inventory)
        {
            InventoryListBox.ClearSelected();
            InventoryListBox.Items.Clear();
            foreach(InventoryItems item in inventory)
            {
                InventoryListBox.Items.Add(item);
            }
            UpdateSelected();
        }// end of method

        //  Selects the gridView text boxes for showing item details
        private void UpdateSelected()
        {
            VideoIDOutput.Text = "";
            VideoNameOutput.Text = "";
            QtyInStockOutput.Text = "";
            QtyCheckedOutput.Text = "";
            TotalQtyOutput.Text = "";
            MediaTypeOutput.Text = "";
            DownloadTypeOutput.Text = "";
            PriceOutput.Text = "";
            GenreIdOutput.Text = "";
            GenreOutput.Text = "";
            AdultOutput.Text = "";
        }// end of method

        // Send the text from the text box to the selectedItem Variable
        private void UpdateSelected(InventoryItems selectedItem)
        {
            VideoIDOutput.Text = selectedItem.VideoID.ToString();
            VideoNameOutput.Text = selectedItem.VideoName;
            QtyInStockOutput.Text = selectedItem.QuantityInStock.ToString();
            QtyCheckedOutput.Text = selectedItem.QuantityCheckedOut.ToString();
            TotalQtyOutput.Text = selectedItem.TotalQuantity.ToString();
            MediaTypeOutput.Text = selectedItem.MediaType;
            DownloadTypeOutput.Text = selectedItem.DownloadType;
            PriceOutput.Text = selectedItem.Price.ToString("C2");
            GenreIdOutput.Text = selectedItem.GenreID.ToString();
            GenreOutput.Text = selectedItem.Genre;
            AdultOutput.Text = selectedItem.Adult;

            VideoIDInventoryControlTextBox.Text = selectedItem.VideoID.ToString();
            VideoNameInventoryTextBox.Text = selectedItem.VideoName;
            QuantityInStockInventoryTextBox.Text = selectedItem.QuantityInStock.ToString();
            QuantityCheckedOutInventoryTextBox.Text = selectedItem.QuantityCheckedOut.ToString();
            TotalQuantityInventoryTextBox.Text = selectedItem.TotalQuantity.ToString();
            MediaTypeInventoryEditComboBox.Text = selectedItem.MediaType;
            DownloadTypeInventoryEditComboBox.Text = selectedItem.DownloadType;
            PriceInventoryEditTextBox.Text = selectedItem.Price.ToString("C2");
            GenreIDInventoryEditTextBox.Text = selectedItem.GenreID.ToString();
            GenreInventoryEditComboBox.Text = selectedItem.Genre;
            AdultInventoryEditTextBox.Text = selectedItem.Adult;
        }// end of method

        // First actions to be taken when the program starts
        private void Inventory_Load(object sender, EventArgs e)
        {
            CSVManager = new CSVManager(); //Opens the CSV class methods
            List<string[]> inventory = CSVManager.readCsv(INVENTORY_LOCATION); // Reads the CSV file to the Inventory string array List
            Im.AddItems(inventory); // Adds the items from the string array list to the Inventory Manager
            UpdateInventoryList(); // Updates the items shown on the InventoryListBox
            setDownloadType();
            setGenre();
            setMediaType();
        }// end of method

        // Shows details about the inventory item when the object is selected in the Inventory List Box
        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InventoryListBox.SelectedIndex != -1)
            {
                InventoryItems selectedItem = (InventoryItems)InventoryListBox.SelectedItem;
                UpdateSelected(selectedItem);
            }
            else
            {
                UpdateSelected();
            }
        }// end of method

        // Clears the fields so that a new item can be created
        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            VideoIDInventoryControlTextBox.Text = "";
            VideoNameInventoryTextBox.Text = "";
            QuantityInStockInventoryTextBox.Text = "";
            QuantityCheckedOutInventoryTextBox.Text = "";
            TotalQuantityInventoryTextBox.Text = "";
            MediaTypeInventoryEditComboBox.Text = "";
            DownloadTypeInventoryEditComboBox.Text = "";
            PriceInventoryEditTextBox.Text = "";
            GenreIDInventoryEditTextBox.Text = "";
            GenreInventoryEditComboBox.Text = "";
            AdultInventoryEditTextBox.Text = "";
            VideoIDSearchTextBox.Text = "";
            VideoNameSearchTextBox.Text = "";
            MediaTypeSearchComboBox.Text = "";
            GenreSearchComboBox.Text = "";
            UpdateInventoryList();
        }// end of method

        private void MediaTypeSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unused
        }// end of method

        private void GenreSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unused
        }// end of method

        private void MediaTypeInventoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unused
        }// end of method

        private void DownloadTypeInventoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unused
        }// end of method

        private void GenreInventoryEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unused
        }// end of method

        // method that programs the inputs for the genre combo boxes
        private void setGenre()
        {
            GenreInventoryEditComboBox.Items.Add("Action-1");
            GenreInventoryEditComboBox.Items.Add("Adventure-2");
            GenreInventoryEditComboBox.Items.Add("Animated-3");
            GenreInventoryEditComboBox.Items.Add("Biography-4");
            GenreInventoryEditComboBox.Items.Add("Comedy-5");
            GenreInventoryEditComboBox.Items.Add("Crime-6");
            GenreInventoryEditComboBox.Items.Add("Drama-7");
            GenreInventoryEditComboBox.Items.Add("Documentary-8");
            GenreInventoryEditComboBox.Items.Add("Fantasy-9");
            GenreInventoryEditComboBox.Items.Add("Horror-10");
            GenreInventoryEditComboBox.Items.Add("Martial-Arts-11");
            GenreInventoryEditComboBox.Items.Add("Musical-12");
            GenreInventoryEditComboBox.Items.Add("Pornographic-13");
            GenreInventoryEditComboBox.Items.Add("Romance-14");
            GenreInventoryEditComboBox.Items.Add("Science-Fiction-15");
            GenreInventoryEditComboBox.Items.Add("Silent-16");
            GenreInventoryEditComboBox.Items.Add("Sports-17");
            GenreInventoryEditComboBox.Items.Add("Thriller-18");
            GenreInventoryEditComboBox.Items.Add("War-19");
            GenreInventoryEditComboBox.Items.Add("Western-20");

            GenreSearchComboBox.Items.Add("Action-1");
            GenreSearchComboBox.Items.Add("Adventure-2");
            GenreSearchComboBox.Items.Add("Animated-3");
            GenreSearchComboBox.Items.Add("Biography-4");
            GenreSearchComboBox.Items.Add("Comedy-5");
            GenreSearchComboBox.Items.Add("Crime-6");
            GenreSearchComboBox.Items.Add("Drama-7");
            GenreSearchComboBox.Items.Add("Documentary-8");
            GenreSearchComboBox.Items.Add("Fantasy-9");
            GenreSearchComboBox.Items.Add("Horror-10");
            GenreSearchComboBox.Items.Add("Martial-Arts-11");
            GenreSearchComboBox.Items.Add("Musical-12");
            GenreSearchComboBox.Items.Add("Pornographic-13");
            GenreSearchComboBox.Items.Add("Romance-14");
            GenreSearchComboBox.Items.Add("Science-Fiction-15");
            GenreSearchComboBox.Items.Add("Silent-16");
            GenreSearchComboBox.Items.Add("Sports-17");
            GenreSearchComboBox.Items.Add("Thriller-18");
            GenreSearchComboBox.Items.Add("War-19");
            GenreSearchComboBox.Items.Add("Western-20");
        }// end of method

        // Method that sets the inputs for the download type combo box
        private void setDownloadType()
        {
            DownloadTypeInventoryEditComboBox.Items.Add("AVI");
            DownloadTypeInventoryEditComboBox.Items.Add("AVCHD");
            DownloadTypeInventoryEditComboBox.Items.Add("DVD");
            DownloadTypeInventoryEditComboBox.Items.Add("VHS");
            DownloadTypeInventoryEditComboBox.Items.Add("CD");
            DownloadTypeInventoryEditComboBox.Items.Add("MP2");
            DownloadTypeInventoryEditComboBox.Items.Add("MP3");
            DownloadTypeInventoryEditComboBox.Items.Add("MP4");
            DownloadTypeInventoryEditComboBox.Items.Add("Physical");
            DownloadTypeInventoryEditComboBox.Items.Add("MKV");
            DownloadTypeInventoryEditComboBox.Items.Add("JPG");
            DownloadTypeInventoryEditComboBox.Items.Add("OGG");
            DownloadTypeInventoryEditComboBox.Items.Add("WMV");
            DownloadTypeInventoryEditComboBox.Items.Add("MOV");
            DownloadTypeInventoryEditComboBox.Items.Add("WEBM");
            DownloadTypeInventoryEditComboBox.Items.Add("Cassette");
            DownloadTypeInventoryEditComboBox.Items.Add("Blu-Ray");
            DownloadTypeInventoryEditComboBox.Items.Add("3D");
            DownloadTypeInventoryEditComboBox.Items.Add("Imax");
            DownloadTypeInventoryEditComboBox.Items.Add("Projected");
            DownloadTypeInventoryEditComboBox.Items.Add("Hologram");
            DownloadTypeInventoryEditComboBox.Items.Add("Optronic");
            DownloadTypeInventoryEditComboBox.Items.Add("Print");
            DownloadTypeInventoryEditComboBox.Items.Add("Online");
        }// end of method

        // Method that sets the choices of the media type combo boxes
        private void setMediaType()
        {
            MediaTypeInventoryEditComboBox.Items.Add("Audio");
            MediaTypeInventoryEditComboBox.Items.Add("Book");
            MediaTypeInventoryEditComboBox.Items.Add("Downloaded");
            MediaTypeInventoryEditComboBox.Items.Add("Magazine");
            MediaTypeInventoryEditComboBox.Items.Add("Movie");
            MediaTypeInventoryEditComboBox.Items.Add("Newspaper");
            MediaTypeInventoryEditComboBox.Items.Add("TVShow");
            MediaTypeInventoryEditComboBox.Items.Add("StreamingContent");
            MediaTypeInventoryEditComboBox.Items.Add("VideoGame");

            MediaTypeSearchComboBox.Items.Add("Audio");
            MediaTypeSearchComboBox.Items.Add("Book");
            MediaTypeSearchComboBox.Items.Add("Downloaded");
            MediaTypeSearchComboBox.Items.Add("Magazine");
            MediaTypeSearchComboBox.Items.Add("Movie");
            MediaTypeSearchComboBox.Items.Add("Newspaper");
            MediaTypeSearchComboBox.Items.Add("TVShow");
            MediaTypeSearchComboBox.Items.Add("StreamingContent");
            MediaTypeSearchComboBox.Items.Add("VideoGame");
        }// end of method

        // Payments Button
        private void PaymentsPortalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payments p2 = new Payments();
            p2.ShowDialog();
        }// End of method

        // Customers Button
        private void CustomersPortalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c2 = new Customer();
            c2.ShowDialog();
        }// End of method

        // Stores Button
        private void StoresPortalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stores s2 = new Stores();
            s2.ShowDialog();
        }// End of method

        // Edit Video Button... Does not work correctly
        private void EditVideoButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//new change
            {
                // Creates a Inventory Item Object
                InventoryItems editItem = new InventoryItems(int.Parse(VideoIDInventoryControlTextBox.Text), VideoNameInventoryTextBox.Text, int.Parse(QuantityInStockInventoryTextBox.Text),
                    int.Parse(QuantityCheckedOutInventoryTextBox.Text), int.Parse(TotalQuantityInventoryTextBox.Text), MediaTypeInventoryEditComboBox.Text,
                    DownloadTypeInventoryEditComboBox.Text, decimal.Parse(PriceInventoryEditTextBox.Text), int.Parse(GenreIDInventoryEditTextBox.Text),
                    GenreInventoryEditComboBox.Text, AdultInventoryEditTextBox.Text);
                Im.EditItem(editItem); //Add the new item to the Inventory Manager
                UpdateInventoryList(); //Updates the Inventory List
                VideoIDInventoryControlTextBox.Text = ""; // Makes the add item edit control text boxes blank after adding a new item
                VideoNameInventoryTextBox.Text = "";
                QuantityInStockInventoryTextBox.Text = "";
                QuantityCheckedOutInventoryTextBox.Text = "";
                TotalQuantityInventoryTextBox.Text = "";
                MediaTypeInventoryEditComboBox.Text = "";
                DownloadTypeInventoryEditComboBox.Text = "";
                PriceInventoryEditTextBox.Text = "";
                GenreIDInventoryEditTextBox.Text = "";
                GenreInventoryEditComboBox.Text = "";
                AdultInventoryEditTextBox.Text = "";
            }
            else //new change
            {
                MessageBox.Show("Please review the fields", "Error on Save");
            }
        }// End of method
    }
    
}
