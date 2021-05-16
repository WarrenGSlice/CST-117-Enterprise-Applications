using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * * *
 * * Warren Peterson * * *
 * This is my Own Work * *
 * CST-117 5/15/2021 * * *
 * * * Milestone 5 * * * *
 * * * * * * * * * * * * */

namespace Milestone2
{
    // The InventoryItem Class that contains all of the properties of the Inventory Object
    public class InventoryItems
    {
        // Variables along with their getters & setter methods
        public int VideoID { get; set; } // Variable for the VideoID #
        public string VideoName { get; set; } // Variable for the VideoName
        public int QuantityInStock { get; set; } // Variable for QTYINSTOCK
        public int QuantityCheckedOut { get; set; } // Variable for QtyCheckedOut
        public int TotalQuantity { get; set; } // Variable for Total Quantity
        public string MediaType{ get; set; } // Variable for Media Type
        public string DownloadType{ get; set; } // Variable for Download Type
        public decimal Price { get; set; } // Variable for Price
        public int GenreID { get; set; } // Variable for the Genre ID #
        public string Genre{ get; set; } // Variable for Genre
        public string Adult { get; set; } // Variable for Adult or not

        // Constructor method that passes the arguments from the variable to the created Inventory Object in the Inventory Driver Class
        public InventoryItems(int videoID, string videoName, int quantityInStock, int quantityCheckedOut, int totalQuantity, string mediaType, string downloadType, decimal price, int genreID, string genre, string adult)
        {
            this.VideoID = videoID;
            this.VideoName = videoName;
            this.QuantityInStock = quantityInStock;
            this.QuantityCheckedOut = quantityCheckedOut;
            this.TotalQuantity = totalQuantity;
            this.MediaType = mediaType;
            this.DownloadType = downloadType;
            this.Price = Math.Round(price, 2);
            this.GenreID = genreID;
            this.Genre = genre;
            this.Adult = adult;
        }// end of method

        // Constructor Array that passes the properties of the created Invetory Objects and stores it in an array to be viewed as an Array Object in the Inventory Driver Class
        public InventoryItems(string[] item)
        {
            this.VideoID = int.Parse(item[0]);
            this.VideoName = item[1];
            this.QuantityInStock = int.Parse(item[2]);
            this.QuantityCheckedOut = int.Parse(item[3]);
            this.TotalQuantity = int.Parse(item[4]);
            this.MediaType = item[5];
            this.DownloadType = item[6];
            this.Price = Math.Round(decimal.Parse(item[7]), 2);
            this.GenreID = int.Parse(item[8]);
            this.Genre = item[9];
            this.Adult = item[10];
        }// end of method

        // unused
        public InventoryItems()
        {
            this.VideoName = VideoName;
        }// end of method

        // Unused
        public InventoryItems(InventoryItems VideoId)
        {
            this.VideoID = VideoID;
        }// End of method

        //Method to be used later for the Search Bar
        public override bool Equals(Object obj)
        {
            return (obj is InventoryItems) && ((InventoryItems)obj).VideoID == VideoID;
        }// end of method

        //Method to be used later for the Search Bar
        public bool Equals(string name)
        {
            return name == VideoName;
        }// end of method

        // Sets the string name and links it to the mediatype variable
        // used for media search method in the Inventory Manager
        public bool Equates(string kindOfVideo)
        {
            return kindOfVideo == MediaType;
        }// end of method

        // Sets the string name and links it to the genre variable
        //used for the genre search method in the Inventory Manager
        public bool WillFind(string genre)
        {
            return genre == Genre;
        }// end of method

        // Sets the string name and links it to the id variable
        // used for the ID search method in the Inventory Manager
        public bool IDFind(int id)
        {
            return id == VideoID;
        }// end of method

        // Sets the string name and links it to the videoName variable
        // used for multi word Video name searches. need to make another for more words
        public bool Equals(string name, string desc)
        {
            return VideoName.ToLower().Contains(name.ToLower()) || MediaType.ToLower().Contains(desc.ToLower());
        }// end of method

        // Sets the variable for quantityInStock to be outOfStock when that number hits 0
        public bool OutOfStock()
        {
            return QuantityInStock == 0;
        }// end of method

        // Method to be used later for a database binding control
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }// end of method

        // Overriding method for VideoName that ensures this variable always returns as a string type
        public override string ToString()
        {
            return VideoName;
        }// end of method

        // The ToArray() method is like the ToString method in that it helps the contructor pass the correct objects to the array in the correct form
        public string[] ToArray()
        {
            return new string[]
                {
                    VideoID.ToString(),
                    VideoName,
                    QuantityInStock.ToString(),
                    QuantityCheckedOut.ToString(),
                    TotalQuantity.ToString(),
                    MediaType,
                    DownloadType,
                    Price.ToString(),
                    GenreID.ToString(),
                    Genre,
                    Adult,
                };
        }// end of method
    }
}
