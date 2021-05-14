
/* * * * * * * * * * * * *
 * * Warren Peterson * * *
 * This is my Own Work * *
 * CST-117 4/24/2021 * * *
 * * * * * * * * * * * * */

namespace Milestone2
{
    partial class Inventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.VideoNameSearchButton = new System.Windows.Forms.Button();
            this.VideoIDSearchButton = new System.Windows.Forms.Button();
            this.GenreSearchButton = new System.Windows.Forms.Button();
            this.MediaTypeSearchButton = new System.Windows.Forms.Button();
            this.GenreSearchComboBox = new System.Windows.Forms.ComboBox();
            this.MediaTypeSearchComboBox = new System.Windows.Forms.ComboBox();
            this.VideoNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.VideoIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.GenreSearchLabel = new System.Windows.Forms.Label();
            this.MediaTypeSearchLabel = new System.Windows.Forms.Label();
            this.VideoNameSearchLabel = new System.Windows.Forms.Label();
            this.VideoIDSearchLabel = new System.Windows.Forms.Label();
            this.CommandsGroupBox = new System.Windows.Forms.GroupBox();
            this.RestockVideoButton = new System.Windows.Forms.Button();
            this.EditVideoButton = new System.Windows.Forms.Button();
            this.DeleteVideoButton = new System.Windows.Forms.Button();
            this.AddVideoButton = new System.Windows.Forms.Button();
            this.CustomersPortalButton = new System.Windows.Forms.Button();
            this.PaymentsPortalButton = new System.Windows.Forms.Button();
            this.StoresPortalButton = new System.Windows.Forms.Button();
            this.InventoryGridView = new System.Windows.Forms.DataGridView();
            this.videoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCheckedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adult = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditControlsSearchBox = new System.Windows.Forms.GroupBox();
            this.AdultInventoryEditTextBox = new System.Windows.Forms.TextBox();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.GenreInventoryEditComboBox = new System.Windows.Forms.ComboBox();
            this.GenreIDInventoryEditTextBox = new System.Windows.Forms.TextBox();
            this.PriceInventoryEditTextBox = new System.Windows.Forms.TextBox();
            this.DownloadTypeInventoryEditComboBox = new System.Windows.Forms.ComboBox();
            this.MediaTypeInventoryEditComboBox = new System.Windows.Forms.ComboBox();
            this.TotalQuantityInventoryTextBox = new System.Windows.Forms.TextBox();
            this.QuantityCheckedOutInventoryTextBox = new System.Windows.Forms.TextBox();
            this.QuantityInStockInventoryTextBox = new System.Windows.Forms.TextBox();
            this.VideoNameInventoryTextBox = new System.Windows.Forms.TextBox();
            this.VideoIDInventoryControlTextBox = new System.Windows.Forms.TextBox();
            this.AdultInventoryEditLabel = new System.Windows.Forms.Label();
            this.GenreInventoryEditLabel = new System.Windows.Forms.Label();
            this.GenreIDInventoryEditLabel = new System.Windows.Forms.Label();
            this.PriceInventoryEditLabel = new System.Windows.Forms.Label();
            this.DownloadTypeInventoryEditLabel = new System.Windows.Forms.Label();
            this.MediaTypeInventoryLabel = new System.Windows.Forms.Label();
            this.TotalQuantityInventoryLabel = new System.Windows.Forms.Label();
            this.QuantityCheckedOutInventoryLabel = new System.Windows.Forms.Label();
            this.QuantityInStockInventoryLabel = new System.Windows.Forms.Label();
            this.VideoNameInventoryLabel = new System.Windows.Forms.Label();
            this.VideoIDEditInvetoryLabel = new System.Windows.Forms.Label();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.VideoIDOutput = new System.Windows.Forms.TextBox();
            this.QtyInStockOutput = new System.Windows.Forms.TextBox();
            this.QtyCheckedOutput = new System.Windows.Forms.TextBox();
            this.TotalQtyOutput = new System.Windows.Forms.TextBox();
            this.MediaTypeOutput = new System.Windows.Forms.TextBox();
            this.DownloadTypeOutput = new System.Windows.Forms.TextBox();
            this.PriceOutput = new System.Windows.Forms.TextBox();
            this.GenreIdOutput = new System.Windows.Forms.TextBox();
            this.GenreOutput = new System.Windows.Forms.TextBox();
            this.AdultOutput = new System.Windows.Forms.TextBox();
            this.VideoNameOutput = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchGroupBox.SuspendLayout();
            this.CommandsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            this.EditControlsSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchGroupBox.Controls.Add(this.VideoNameSearchButton);
            this.SearchGroupBox.Controls.Add(this.VideoIDSearchButton);
            this.SearchGroupBox.Controls.Add(this.GenreSearchButton);
            this.SearchGroupBox.Controls.Add(this.MediaTypeSearchButton);
            this.SearchGroupBox.Controls.Add(this.GenreSearchComboBox);
            this.SearchGroupBox.Controls.Add(this.MediaTypeSearchComboBox);
            this.SearchGroupBox.Controls.Add(this.VideoNameSearchTextBox);
            this.SearchGroupBox.Controls.Add(this.VideoIDSearchTextBox);
            this.SearchGroupBox.Controls.Add(this.GenreSearchLabel);
            this.SearchGroupBox.Controls.Add(this.MediaTypeSearchLabel);
            this.SearchGroupBox.Controls.Add(this.VideoNameSearchLabel);
            this.SearchGroupBox.Controls.Add(this.VideoIDSearchLabel);
            this.SearchGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(628, 127);
            this.SearchGroupBox.TabIndex = 0;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // VideoNameSearchButton
            // 
            this.VideoNameSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VideoNameSearchButton.Location = new System.Drawing.Point(235, 76);
            this.VideoNameSearchButton.Name = "VideoNameSearchButton";
            this.VideoNameSearchButton.Size = new System.Drawing.Size(75, 23);
            this.VideoNameSearchButton.TabIndex = 13;
            this.VideoNameSearchButton.Text = "Search";
            this.VideoNameSearchButton.UseVisualStyleBackColor = true;
            this.VideoNameSearchButton.Click += new System.EventHandler(this.VideoNameSearchButton_Click);
            // 
            // VideoIDSearchButton
            // 
            this.VideoIDSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VideoIDSearchButton.Location = new System.Drawing.Point(235, 26);
            this.VideoIDSearchButton.Name = "VideoIDSearchButton";
            this.VideoIDSearchButton.Size = new System.Drawing.Size(75, 23);
            this.VideoIDSearchButton.TabIndex = 12;
            this.VideoIDSearchButton.Text = "Search";
            this.VideoIDSearchButton.UseVisualStyleBackColor = true;
            this.VideoIDSearchButton.Click += new System.EventHandler(this.VideoIDSearchButton_Click);
            // 
            // GenreSearchButton
            // 
            this.GenreSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenreSearchButton.Location = new System.Drawing.Point(536, 77);
            this.GenreSearchButton.Name = "GenreSearchButton";
            this.GenreSearchButton.Size = new System.Drawing.Size(75, 23);
            this.GenreSearchButton.TabIndex = 11;
            this.GenreSearchButton.Text = "Search";
            this.GenreSearchButton.UseVisualStyleBackColor = true;
            this.GenreSearchButton.Click += new System.EventHandler(this.GenreSearchButton_Click);
            // 
            // MediaTypeSearchButton
            // 
            this.MediaTypeSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MediaTypeSearchButton.Location = new System.Drawing.Point(536, 25);
            this.MediaTypeSearchButton.Name = "MediaTypeSearchButton";
            this.MediaTypeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.MediaTypeSearchButton.TabIndex = 10;
            this.MediaTypeSearchButton.Text = "Search";
            this.MediaTypeSearchButton.UseVisualStyleBackColor = true;
            this.MediaTypeSearchButton.Click += new System.EventHandler(this.MediaTypeSearchButton_Click);
            // 
            // GenreSearchComboBox
            // 
            this.GenreSearchComboBox.FormattingEnabled = true;
            this.GenreSearchComboBox.Location = new System.Drawing.Point(423, 77);
            this.GenreSearchComboBox.Name = "GenreSearchComboBox";
            this.GenreSearchComboBox.Size = new System.Drawing.Size(107, 23);
            this.GenreSearchComboBox.TabIndex = 9;
            this.GenreSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreSearchComboBox_SelectedIndexChanged);
            // 
            // MediaTypeSearchComboBox
            // 
            this.MediaTypeSearchComboBox.FormattingEnabled = true;
            this.MediaTypeSearchComboBox.Location = new System.Drawing.Point(424, 25);
            this.MediaTypeSearchComboBox.Name = "MediaTypeSearchComboBox";
            this.MediaTypeSearchComboBox.Size = new System.Drawing.Size(107, 23);
            this.MediaTypeSearchComboBox.TabIndex = 8;
            this.MediaTypeSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.MediaTypeSearchComboBox_SelectedIndexChanged);
            // 
            // VideoNameSearchTextBox
            // 
            this.VideoNameSearchTextBox.Location = new System.Drawing.Point(90, 77);
            this.VideoNameSearchTextBox.Name = "VideoNameSearchTextBox";
            this.VideoNameSearchTextBox.PlaceholderText = "Name of Media";
            this.VideoNameSearchTextBox.Size = new System.Drawing.Size(139, 23);
            this.VideoNameSearchTextBox.TabIndex = 5;
            // 
            // VideoIDSearchTextBox
            // 
            this.VideoIDSearchTextBox.Location = new System.Drawing.Point(90, 26);
            this.VideoIDSearchTextBox.Name = "VideoIDSearchTextBox";
            this.VideoIDSearchTextBox.PlaceholderText = "ID #";
            this.VideoIDSearchTextBox.Size = new System.Drawing.Size(139, 23);
            this.VideoIDSearchTextBox.TabIndex = 4;
            // 
            // GenreSearchLabel
            // 
            this.GenreSearchLabel.AutoSize = true;
            this.GenreSearchLabel.Location = new System.Drawing.Point(373, 80);
            this.GenreSearchLabel.Name = "GenreSearchLabel";
            this.GenreSearchLabel.Size = new System.Drawing.Size(44, 15);
            this.GenreSearchLabel.TabIndex = 3;
            this.GenreSearchLabel.Text = "Genre :";
            // 
            // MediaTypeSearchLabel
            // 
            this.MediaTypeSearchLabel.AutoSize = true;
            this.MediaTypeSearchLabel.Location = new System.Drawing.Point(345, 30);
            this.MediaTypeSearchLabel.Name = "MediaTypeSearchLabel";
            this.MediaTypeSearchLabel.Size = new System.Drawing.Size(73, 15);
            this.MediaTypeSearchLabel.TabIndex = 2;
            this.MediaTypeSearchLabel.Text = "Media Type :";
            // 
            // VideoNameSearchLabel
            // 
            this.VideoNameSearchLabel.AutoSize = true;
            this.VideoNameSearchLabel.Location = new System.Drawing.Point(6, 77);
            this.VideoNameSearchLabel.Name = "VideoNameSearchLabel";
            this.VideoNameSearchLabel.Size = new System.Drawing.Size(78, 15);
            this.VideoNameSearchLabel.TabIndex = 1;
            this.VideoNameSearchLabel.Text = "Video Name :";
            // 
            // VideoIDSearchLabel
            // 
            this.VideoIDSearchLabel.AutoSize = true;
            this.VideoIDSearchLabel.Location = new System.Drawing.Point(27, 29);
            this.VideoIDSearchLabel.Name = "VideoIDSearchLabel";
            this.VideoIDSearchLabel.Size = new System.Drawing.Size(57, 15);
            this.VideoIDSearchLabel.TabIndex = 0;
            this.VideoIDSearchLabel.Text = "Video ID :";
            // 
            // CommandsGroupBox
            // 
            this.CommandsGroupBox.Controls.Add(this.RestockVideoButton);
            this.CommandsGroupBox.Controls.Add(this.EditVideoButton);
            this.CommandsGroupBox.Controls.Add(this.DeleteVideoButton);
            this.CommandsGroupBox.Controls.Add(this.AddVideoButton);
            this.CommandsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CommandsGroupBox.Location = new System.Drawing.Point(785, 12);
            this.CommandsGroupBox.Name = "CommandsGroupBox";
            this.CommandsGroupBox.Size = new System.Drawing.Size(286, 127);
            this.CommandsGroupBox.TabIndex = 1;
            this.CommandsGroupBox.TabStop = false;
            this.CommandsGroupBox.Text = "Commands";
            // 
            // RestockVideoButton
            // 
            this.RestockVideoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.RestockVideoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RestockVideoButton.FlatAppearance.BorderSize = 2;
            this.RestockVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestockVideoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestockVideoButton.ForeColor = System.Drawing.Color.Orange;
            this.RestockVideoButton.Location = new System.Drawing.Point(145, 77);
            this.RestockVideoButton.Name = "RestockVideoButton";
            this.RestockVideoButton.Size = new System.Drawing.Size(133, 23);
            this.RestockVideoButton.TabIndex = 6;
            this.RestockVideoButton.Text = "RESTOCK VIDEO";
            this.RestockVideoButton.UseVisualStyleBackColor = false;
            this.RestockVideoButton.Click += new System.EventHandler(this.RestockVideoButton_Click);
            // 
            // EditVideoButton
            // 
            this.EditVideoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditVideoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditVideoButton.FlatAppearance.BorderSize = 2;
            this.EditVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditVideoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditVideoButton.ForeColor = System.Drawing.Color.Orange;
            this.EditVideoButton.Location = new System.Drawing.Point(145, 26);
            this.EditVideoButton.Name = "EditVideoButton";
            this.EditVideoButton.Size = new System.Drawing.Size(133, 23);
            this.EditVideoButton.TabIndex = 5;
            this.EditVideoButton.Text = "EDIT VIDEO";
            this.EditVideoButton.UseVisualStyleBackColor = false;
            // 
            // DeleteVideoButton
            // 
            this.DeleteVideoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteVideoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteVideoButton.FlatAppearance.BorderSize = 2;
            this.DeleteVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteVideoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteVideoButton.ForeColor = System.Drawing.Color.Orange;
            this.DeleteVideoButton.Location = new System.Drawing.Point(6, 77);
            this.DeleteVideoButton.Name = "DeleteVideoButton";
            this.DeleteVideoButton.Size = new System.Drawing.Size(133, 23);
            this.DeleteVideoButton.TabIndex = 4;
            this.DeleteVideoButton.Text = "DELETE VIDEO";
            this.DeleteVideoButton.UseVisualStyleBackColor = false;
            this.DeleteVideoButton.Click += new System.EventHandler(this.DeleteVideoButton_Click);
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddVideoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddVideoButton.FlatAppearance.BorderSize = 2;
            this.AddVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddVideoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddVideoButton.ForeColor = System.Drawing.Color.Orange;
            this.AddVideoButton.Location = new System.Drawing.Point(6, 26);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(133, 23);
            this.AddVideoButton.TabIndex = 0;
            this.AddVideoButton.Text = "ADD VIDEO";
            this.AddVideoButton.UseVisualStyleBackColor = false;
            this.AddVideoButton.Click += new System.EventHandler(this.AddVideoButton_Click);
            // 
            // CustomersPortalButton
            // 
            this.CustomersPortalButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CustomersPortalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CustomersPortalButton.FlatAppearance.BorderSize = 4;
            this.CustomersPortalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersPortalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersPortalButton.ForeColor = System.Drawing.Color.White;
            this.CustomersPortalButton.Location = new System.Drawing.Point(646, 12);
            this.CustomersPortalButton.Name = "CustomersPortalButton";
            this.CustomersPortalButton.Size = new System.Drawing.Size(133, 39);
            this.CustomersPortalButton.TabIndex = 7;
            this.CustomersPortalButton.Text = "CUSTOMERS";
            this.CustomersPortalButton.UseVisualStyleBackColor = false;
            // 
            // PaymentsPortalButton
            // 
            this.PaymentsPortalButton.BackColor = System.Drawing.Color.Orange;
            this.PaymentsPortalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PaymentsPortalButton.FlatAppearance.BorderSize = 4;
            this.PaymentsPortalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentsPortalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaymentsPortalButton.ForeColor = System.Drawing.Color.Black;
            this.PaymentsPortalButton.Location = new System.Drawing.Point(646, 57);
            this.PaymentsPortalButton.Name = "PaymentsPortalButton";
            this.PaymentsPortalButton.Size = new System.Drawing.Size(133, 39);
            this.PaymentsPortalButton.TabIndex = 8;
            this.PaymentsPortalButton.Text = "PAYMENTS";
            this.PaymentsPortalButton.UseVisualStyleBackColor = false;
            // 
            // StoresPortalButton
            // 
            this.StoresPortalButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.StoresPortalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StoresPortalButton.FlatAppearance.BorderSize = 4;
            this.StoresPortalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoresPortalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoresPortalButton.ForeColor = System.Drawing.Color.White;
            this.StoresPortalButton.Location = new System.Drawing.Point(646, 100);
            this.StoresPortalButton.Name = "StoresPortalButton";
            this.StoresPortalButton.Size = new System.Drawing.Size(133, 39);
            this.StoresPortalButton.TabIndex = 10;
            this.StoresPortalButton.Text = "STORES";
            this.StoresPortalButton.UseVisualStyleBackColor = false;
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoID,
            this.videoName,
            this.qtyInStock,
            this.qtyCheckedOut,
            this.totalQty,
            this.mediaType,
            this.downloadType,
            this.price,
            this.genreID,
            this.genre,
            this.adult});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InventoryGridView.Location = new System.Drawing.Point(117, 308);
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.RowTemplate.Height = 25;
            this.InventoryGridView.Size = new System.Drawing.Size(955, 330);
            this.InventoryGridView.TabIndex = 11;
            // 
            // videoID
            // 
            this.videoID.FillWeight = 50.25382F;
            this.videoID.HeaderText = "Video ID";
            this.videoID.Name = "videoID";
            // 
            // videoName
            // 
            this.videoName.DataPropertyName = "videoNameDataGrid";
            this.videoName.FillWeight = 253.1571F;
            this.videoName.HeaderText = "Video Name";
            this.videoName.Name = "videoName";
            // 
            // qtyInStock
            // 
            this.qtyInStock.FillWeight = 69.61021F;
            this.qtyInStock.HeaderText = "Quantity In Stock";
            this.qtyInStock.Name = "qtyInStock";
            // 
            // qtyCheckedOut
            // 
            this.qtyCheckedOut.FillWeight = 76.84989F;
            this.qtyCheckedOut.HeaderText = "Quantity Checked Out";
            this.qtyCheckedOut.Name = "qtyCheckedOut";
            // 
            // totalQty
            // 
            this.totalQty.FillWeight = 85.14185F;
            this.totalQty.HeaderText = "Total Quantity";
            this.totalQty.Name = "totalQty";
            // 
            // mediaType
            // 
            this.mediaType.FillWeight = 94.63903F;
            this.mediaType.HeaderText = "Media Type";
            this.mediaType.Name = "mediaType";
            // 
            // downloadType
            // 
            this.downloadType.FillWeight = 105.5166F;
            this.downloadType.HeaderText = "Download Type";
            this.downloadType.Name = "downloadType";
            // 
            // price
            // 
            this.price.FillWeight = 81.43765F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // genreID
            // 
            this.genreID.FillWeight = 57.55935F;
            this.genreID.HeaderText = "Genre ID";
            this.genreID.Name = "genreID";
            // 
            // genre
            // 
            this.genre.FillWeight = 153.8896F;
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // adult
            // 
            this.adult.FillWeight = 71.94521F;
            this.adult.HeaderText = "Adult";
            this.adult.Name = "adult";
            // 
            // EditControlsSearchBox
            // 
            this.EditControlsSearchBox.Controls.Add(this.AdultInventoryEditTextBox);
            this.EditControlsSearchBox.Controls.Add(this.ClearFieldsButton);
            this.EditControlsSearchBox.Controls.Add(this.GenreInventoryEditComboBox);
            this.EditControlsSearchBox.Controls.Add(this.GenreIDInventoryEditTextBox);
            this.EditControlsSearchBox.Controls.Add(this.PriceInventoryEditTextBox);
            this.EditControlsSearchBox.Controls.Add(this.DownloadTypeInventoryEditComboBox);
            this.EditControlsSearchBox.Controls.Add(this.MediaTypeInventoryEditComboBox);
            this.EditControlsSearchBox.Controls.Add(this.TotalQuantityInventoryTextBox);
            this.EditControlsSearchBox.Controls.Add(this.QuantityCheckedOutInventoryTextBox);
            this.EditControlsSearchBox.Controls.Add(this.QuantityInStockInventoryTextBox);
            this.EditControlsSearchBox.Controls.Add(this.VideoNameInventoryTextBox);
            this.EditControlsSearchBox.Controls.Add(this.VideoIDInventoryControlTextBox);
            this.EditControlsSearchBox.Controls.Add(this.AdultInventoryEditLabel);
            this.EditControlsSearchBox.Controls.Add(this.GenreInventoryEditLabel);
            this.EditControlsSearchBox.Controls.Add(this.GenreIDInventoryEditLabel);
            this.EditControlsSearchBox.Controls.Add(this.PriceInventoryEditLabel);
            this.EditControlsSearchBox.Controls.Add(this.DownloadTypeInventoryEditLabel);
            this.EditControlsSearchBox.Controls.Add(this.MediaTypeInventoryLabel);
            this.EditControlsSearchBox.Controls.Add(this.TotalQuantityInventoryLabel);
            this.EditControlsSearchBox.Controls.Add(this.QuantityCheckedOutInventoryLabel);
            this.EditControlsSearchBox.Controls.Add(this.QuantityInStockInventoryLabel);
            this.EditControlsSearchBox.Controls.Add(this.VideoNameInventoryLabel);
            this.EditControlsSearchBox.Controls.Add(this.VideoIDEditInvetoryLabel);
            this.EditControlsSearchBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditControlsSearchBox.Location = new System.Drawing.Point(12, 156);
            this.EditControlsSearchBox.Name = "EditControlsSearchBox";
            this.EditControlsSearchBox.Size = new System.Drawing.Size(1059, 128);
            this.EditControlsSearchBox.TabIndex = 12;
            this.EditControlsSearchBox.TabStop = false;
            this.EditControlsSearchBox.Text = "Edit Controls";
            // 
            // AdultInventoryEditTextBox
            // 
            this.AdultInventoryEditTextBox.Location = new System.Drawing.Point(809, 78);
            this.AdultInventoryEditTextBox.Name = "AdultInventoryEditTextBox";
            this.AdultInventoryEditTextBox.Size = new System.Drawing.Size(65, 23);
            this.AdultInventoryEditTextBox.TabIndex = 32;
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearFieldsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearFieldsButton.FlatAppearance.BorderSize = 4;
            this.ClearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFieldsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearFieldsButton.ForeColor = System.Drawing.Color.White;
            this.ClearFieldsButton.Location = new System.Drawing.Point(902, 87);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(133, 39);
            this.ClearFieldsButton.TabIndex = 31;
            this.ClearFieldsButton.Text = "Clear Fields";
            this.ClearFieldsButton.UseVisualStyleBackColor = false;
            this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
            // 
            // GenreInventoryEditComboBox
            // 
            this.GenreInventoryEditComboBox.FormattingEnabled = true;
            this.GenreInventoryEditComboBox.Location = new System.Drawing.Point(808, 45);
            this.GenreInventoryEditComboBox.Name = "GenreInventoryEditComboBox";
            this.GenreInventoryEditComboBox.Size = new System.Drawing.Size(227, 23);
            this.GenreInventoryEditComboBox.TabIndex = 28;
            this.GenreInventoryEditComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreInventoryEditComboBox_SelectedIndexChanged);
            // 
            // GenreIDInventoryEditTextBox
            // 
            this.GenreIDInventoryEditTextBox.Location = new System.Drawing.Point(808, 16);
            this.GenreIDInventoryEditTextBox.Name = "GenreIDInventoryEditTextBox";
            this.GenreIDInventoryEditTextBox.PlaceholderText = "#";
            this.GenreIDInventoryEditTextBox.Size = new System.Drawing.Size(227, 23);
            this.GenreIDInventoryEditTextBox.TabIndex = 27;
            // 
            // PriceInventoryEditTextBox
            // 
            this.PriceInventoryEditTextBox.Location = new System.Drawing.Point(469, 98);
            this.PriceInventoryEditTextBox.Name = "PriceInventoryEditTextBox";
            this.PriceInventoryEditTextBox.PlaceholderText = "$";
            this.PriceInventoryEditTextBox.Size = new System.Drawing.Size(227, 23);
            this.PriceInventoryEditTextBox.TabIndex = 26;
            // 
            // DownloadTypeInventoryEditComboBox
            // 
            this.DownloadTypeInventoryEditComboBox.FormattingEnabled = true;
            this.DownloadTypeInventoryEditComboBox.Location = new System.Drawing.Point(469, 70);
            this.DownloadTypeInventoryEditComboBox.Name = "DownloadTypeInventoryEditComboBox";
            this.DownloadTypeInventoryEditComboBox.Size = new System.Drawing.Size(227, 23);
            this.DownloadTypeInventoryEditComboBox.TabIndex = 25;
            this.DownloadTypeInventoryEditComboBox.SelectedIndexChanged += new System.EventHandler(this.DownloadTypeInventoryEditComboBox_SelectedIndexChanged);
            // 
            // MediaTypeInventoryEditComboBox
            // 
            this.MediaTypeInventoryEditComboBox.FormattingEnabled = true;
            this.MediaTypeInventoryEditComboBox.Location = new System.Drawing.Point(469, 40);
            this.MediaTypeInventoryEditComboBox.Name = "MediaTypeInventoryEditComboBox";
            this.MediaTypeInventoryEditComboBox.Size = new System.Drawing.Size(227, 23);
            this.MediaTypeInventoryEditComboBox.TabIndex = 10;
            this.MediaTypeInventoryEditComboBox.SelectedIndexChanged += new System.EventHandler(this.MediaTypeInventoryEditComboBox_SelectedIndexChanged);
            // 
            // TotalQuantityInventoryTextBox
            // 
            this.TotalQuantityInventoryTextBox.Location = new System.Drawing.Point(469, 11);
            this.TotalQuantityInventoryTextBox.Name = "TotalQuantityInventoryTextBox";
            this.TotalQuantityInventoryTextBox.PlaceholderText = "#";
            this.TotalQuantityInventoryTextBox.Size = new System.Drawing.Size(227, 23);
            this.TotalQuantityInventoryTextBox.TabIndex = 24;
            // 
            // QuantityCheckedOutInventoryTextBox
            // 
            this.QuantityCheckedOutInventoryTextBox.Location = new System.Drawing.Point(137, 99);
            this.QuantityCheckedOutInventoryTextBox.Name = "QuantityCheckedOutInventoryTextBox";
            this.QuantityCheckedOutInventoryTextBox.PlaceholderText = "#";
            this.QuantityCheckedOutInventoryTextBox.Size = new System.Drawing.Size(227, 23);
            this.QuantityCheckedOutInventoryTextBox.TabIndex = 23;
            // 
            // QuantityInStockInventoryTextBox
            // 
            this.QuantityInStockInventoryTextBox.Location = new System.Drawing.Point(137, 70);
            this.QuantityInStockInventoryTextBox.Name = "QuantityInStockInventoryTextBox";
            this.QuantityInStockInventoryTextBox.PlaceholderText = "#";
            this.QuantityInStockInventoryTextBox.Size = new System.Drawing.Size(227, 23);
            this.QuantityInStockInventoryTextBox.TabIndex = 22;
            // 
            // VideoNameInventoryTextBox
            // 
            this.VideoNameInventoryTextBox.Location = new System.Drawing.Point(137, 40);
            this.VideoNameInventoryTextBox.Name = "VideoNameInventoryTextBox";
            this.VideoNameInventoryTextBox.PlaceholderText = "Name of Media";
            this.VideoNameInventoryTextBox.Size = new System.Drawing.Size(227, 23);
            this.VideoNameInventoryTextBox.TabIndex = 21;
            // 
            // VideoIDInventoryControlTextBox
            // 
            this.VideoIDInventoryControlTextBox.Location = new System.Drawing.Point(137, 11);
            this.VideoIDInventoryControlTextBox.Name = "VideoIDInventoryControlTextBox";
            this.VideoIDInventoryControlTextBox.PlaceholderText = "ID #";
            this.VideoIDInventoryControlTextBox.Size = new System.Drawing.Size(227, 23);
            this.VideoIDInventoryControlTextBox.TabIndex = 10;
            // 
            // AdultInventoryEditLabel
            // 
            this.AdultInventoryEditLabel.AutoSize = true;
            this.AdultInventoryEditLabel.Location = new System.Drawing.Point(708, 78);
            this.AdultInventoryEditLabel.Name = "AdultInventoryEditLabel";
            this.AdultInventoryEditLabel.Size = new System.Drawing.Size(94, 15);
            this.AdultInventoryEditLabel.TabIndex = 20;
            this.AdultInventoryEditLabel.Text = "Adult  (Yes/No) :";
            // 
            // GenreInventoryEditLabel
            // 
            this.GenreInventoryEditLabel.AutoSize = true;
            this.GenreInventoryEditLabel.Location = new System.Drawing.Point(758, 53);
            this.GenreInventoryEditLabel.Name = "GenreInventoryEditLabel";
            this.GenreInventoryEditLabel.Size = new System.Drawing.Size(44, 15);
            this.GenreInventoryEditLabel.TabIndex = 19;
            this.GenreInventoryEditLabel.Text = "Genre :";
            // 
            // GenreIDInventoryEditLabel
            // 
            this.GenreIDInventoryEditLabel.AutoSize = true;
            this.GenreIDInventoryEditLabel.Location = new System.Drawing.Point(744, 24);
            this.GenreIDInventoryEditLabel.Name = "GenreIDInventoryEditLabel";
            this.GenreIDInventoryEditLabel.Size = new System.Drawing.Size(58, 15);
            this.GenreIDInventoryEditLabel.TabIndex = 18;
            this.GenreIDInventoryEditLabel.Text = "Genre ID :";
            // 
            // PriceInventoryEditLabel
            // 
            this.PriceInventoryEditLabel.AutoSize = true;
            this.PriceInventoryEditLabel.Location = new System.Drawing.Point(424, 106);
            this.PriceInventoryEditLabel.Name = "PriceInventoryEditLabel";
            this.PriceInventoryEditLabel.Size = new System.Drawing.Size(39, 15);
            this.PriceInventoryEditLabel.TabIndex = 17;
            this.PriceInventoryEditLabel.Text = "Price :";
            // 
            // DownloadTypeInventoryEditLabel
            // 
            this.DownloadTypeInventoryEditLabel.AutoSize = true;
            this.DownloadTypeInventoryEditLabel.Location = new System.Drawing.Point(370, 78);
            this.DownloadTypeInventoryEditLabel.Name = "DownloadTypeInventoryEditLabel";
            this.DownloadTypeInventoryEditLabel.Size = new System.Drawing.Size(94, 15);
            this.DownloadTypeInventoryEditLabel.TabIndex = 16;
            this.DownloadTypeInventoryEditLabel.Text = "Download Type :";
            // 
            // MediaTypeInventoryLabel
            // 
            this.MediaTypeInventoryLabel.AutoSize = true;
            this.MediaTypeInventoryLabel.Location = new System.Drawing.Point(390, 48);
            this.MediaTypeInventoryLabel.Name = "MediaTypeInventoryLabel";
            this.MediaTypeInventoryLabel.Size = new System.Drawing.Size(73, 15);
            this.MediaTypeInventoryLabel.TabIndex = 15;
            this.MediaTypeInventoryLabel.Text = "Media Type :";
            // 
            // TotalQuantityInventoryLabel
            // 
            this.TotalQuantityInventoryLabel.AutoSize = true;
            this.TotalQuantityInventoryLabel.Location = new System.Drawing.Point(376, 19);
            this.TotalQuantityInventoryLabel.Name = "TotalQuantityInventoryLabel";
            this.TotalQuantityInventoryLabel.Size = new System.Drawing.Size(87, 15);
            this.TotalQuantityInventoryLabel.TabIndex = 14;
            this.TotalQuantityInventoryLabel.Text = "Total Quantity :";
            // 
            // QuantityCheckedOutInventoryLabel
            // 
            this.QuantityCheckedOutInventoryLabel.AutoSize = true;
            this.QuantityCheckedOutInventoryLabel.Location = new System.Drawing.Point(6, 107);
            this.QuantityCheckedOutInventoryLabel.Name = "QuantityCheckedOutInventoryLabel";
            this.QuantityCheckedOutInventoryLabel.Size = new System.Drawing.Size(131, 15);
            this.QuantityCheckedOutInventoryLabel.TabIndex = 13;
            this.QuantityCheckedOutInventoryLabel.Text = "Quantity Checked Out :";
            // 
            // QuantityInStockInventoryLabel
            // 
            this.QuantityInStockInventoryLabel.AutoSize = true;
            this.QuantityInStockInventoryLabel.Location = new System.Drawing.Point(27, 78);
            this.QuantityInStockInventoryLabel.Name = "QuantityInStockInventoryLabel";
            this.QuantityInStockInventoryLabel.Size = new System.Drawing.Size(104, 15);
            this.QuantityInStockInventoryLabel.TabIndex = 12;
            this.QuantityInStockInventoryLabel.Text = "Quantity In Stock :";
            // 
            // VideoNameInventoryLabel
            // 
            this.VideoNameInventoryLabel.AutoSize = true;
            this.VideoNameInventoryLabel.Location = new System.Drawing.Point(53, 48);
            this.VideoNameInventoryLabel.Name = "VideoNameInventoryLabel";
            this.VideoNameInventoryLabel.Size = new System.Drawing.Size(78, 15);
            this.VideoNameInventoryLabel.TabIndex = 11;
            this.VideoNameInventoryLabel.Text = "Video Name :";
            // 
            // VideoIDEditInvetoryLabel
            // 
            this.VideoIDEditInvetoryLabel.AutoSize = true;
            this.VideoIDEditInvetoryLabel.Location = new System.Drawing.Point(74, 19);
            this.VideoIDEditInvetoryLabel.Name = "VideoIDEditInvetoryLabel";
            this.VideoIDEditInvetoryLabel.Size = new System.Drawing.Size(57, 15);
            this.VideoIDEditInvetoryLabel.TabIndex = 10;
            this.VideoIDEditInvetoryLabel.Text = "Video ID :";
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.ItemHeight = 15;
            this.InventoryListBox.Location = new System.Drawing.Point(18, 308);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(135, 334);
            this.InventoryListBox.TabIndex = 13;
            this.InventoryListBox.SelectedIndexChanged += new System.EventHandler(this.InventoryListBox_SelectedIndexChanged);
            // 
            // VideoIDOutput
            // 
            this.VideoIDOutput.Location = new System.Drawing.Point(159, 362);
            this.VideoIDOutput.Name = "VideoIDOutput";
            this.VideoIDOutput.PlaceholderText = "ID #";
            this.VideoIDOutput.Size = new System.Drawing.Size(41, 23);
            this.VideoIDOutput.TabIndex = 14;
            // 
            // QtyInStockOutput
            // 
            this.QtyInStockOutput.Location = new System.Drawing.Point(414, 362);
            this.QtyInStockOutput.Name = "QtyInStockOutput";
            this.QtyInStockOutput.PlaceholderText = "#";
            this.QtyInStockOutput.Size = new System.Drawing.Size(51, 23);
            this.QtyInStockOutput.TabIndex = 15;
            // 
            // QtyCheckedOutput
            // 
            this.QtyCheckedOutput.Location = new System.Drawing.Point(471, 362);
            this.QtyCheckedOutput.Name = "QtyCheckedOutput";
            this.QtyCheckedOutput.PlaceholderText = "#";
            this.QtyCheckedOutput.Size = new System.Drawing.Size(58, 23);
            this.QtyCheckedOutput.TabIndex = 16;
            // 
            // TotalQtyOutput
            // 
            this.TotalQtyOutput.Location = new System.Drawing.Point(535, 362);
            this.TotalQtyOutput.Name = "TotalQtyOutput";
            this.TotalQtyOutput.PlaceholderText = "#";
            this.TotalQtyOutput.Size = new System.Drawing.Size(62, 23);
            this.TotalQtyOutput.TabIndex = 17;
            // 
            // MediaTypeOutput
            // 
            this.MediaTypeOutput.Location = new System.Drawing.Point(603, 362);
            this.MediaTypeOutput.Name = "MediaTypeOutput";
            this.MediaTypeOutput.PlaceholderText = "...";
            this.MediaTypeOutput.Size = new System.Drawing.Size(78, 23);
            this.MediaTypeOutput.TabIndex = 18;
            // 
            // DownloadTypeOutput
            // 
            this.DownloadTypeOutput.Location = new System.Drawing.Point(687, 362);
            this.DownloadTypeOutput.Name = "DownloadTypeOutput";
            this.DownloadTypeOutput.PlaceholderText = "...";
            this.DownloadTypeOutput.Size = new System.Drawing.Size(77, 23);
            this.DownloadTypeOutput.TabIndex = 19;
            // 
            // PriceOutput
            // 
            this.PriceOutput.Location = new System.Drawing.Point(770, 362);
            this.PriceOutput.Name = "PriceOutput";
            this.PriceOutput.PlaceholderText = "$";
            this.PriceOutput.Size = new System.Drawing.Size(65, 23);
            this.PriceOutput.TabIndex = 20;
            // 
            // GenreIdOutput
            // 
            this.GenreIdOutput.Location = new System.Drawing.Point(841, 362);
            this.GenreIdOutput.Name = "GenreIdOutput";
            this.GenreIdOutput.PlaceholderText = "#";
            this.GenreIdOutput.Size = new System.Drawing.Size(37, 23);
            this.GenreIdOutput.TabIndex = 21;
            // 
            // GenreOutput
            // 
            this.GenreOutput.Location = new System.Drawing.Point(884, 362);
            this.GenreOutput.Name = "GenreOutput";
            this.GenreOutput.PlaceholderText = "...";
            this.GenreOutput.Size = new System.Drawing.Size(122, 23);
            this.GenreOutput.TabIndex = 22;
            // 
            // AdultOutput
            // 
            this.AdultOutput.Location = new System.Drawing.Point(1012, 362);
            this.AdultOutput.Name = "AdultOutput";
            this.AdultOutput.PlaceholderText = "Yes/No";
            this.AdultOutput.Size = new System.Drawing.Size(59, 23);
            this.AdultOutput.TabIndex = 23;
            // 
            // VideoNameOutput
            // 
            this.VideoNameOutput.Location = new System.Drawing.Point(206, 362);
            this.VideoNameOutput.Name = "VideoNameOutput";
            this.VideoNameOutput.PlaceholderText = "Name of Media";
            this.VideoNameOutput.Size = new System.Drawing.Size(202, 23);
            this.VideoNameOutput.TabIndex = 24;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1083, 648);
            this.Controls.Add(this.VideoNameOutput);
            this.Controls.Add(this.AdultOutput);
            this.Controls.Add(this.GenreOutput);
            this.Controls.Add(this.GenreIdOutput);
            this.Controls.Add(this.PriceOutput);
            this.Controls.Add(this.DownloadTypeOutput);
            this.Controls.Add(this.MediaTypeOutput);
            this.Controls.Add(this.TotalQtyOutput);
            this.Controls.Add(this.QtyCheckedOutput);
            this.Controls.Add(this.QtyInStockOutput);
            this.Controls.Add(this.VideoIDOutput);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.EditControlsSearchBox);
            this.Controls.Add(this.InventoryGridView);
            this.Controls.Add(this.StoresPortalButton);
            this.Controls.Add(this.PaymentsPortalButton);
            this.Controls.Add(this.CustomersPortalButton);
            this.Controls.Add(this.CommandsGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "INVENTORY MANAGEMENT";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.CommandsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            this.EditControlsSearchBox.ResumeLayout(false);
            this.EditControlsSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ComboBox GenreSearchComboBox;
        private System.Windows.Forms.ComboBox MediaTypeSearchComboBox;
        public System.Windows.Forms.TextBox VideoNameSearchTextBox;
        private System.Windows.Forms.TextBox VideoIDSearchTextBox;
        private System.Windows.Forms.Label GenreSearchLabel;
        private System.Windows.Forms.Label MediaTypeSearchLabel;
        public System.Windows.Forms.Label VideoNameSearchLabel;
        private System.Windows.Forms.Label VideoIDSearchLabel;
        private System.Windows.Forms.GroupBox CommandsGroupBox;
        private System.Windows.Forms.Button RestockVideoButton;
        private System.Windows.Forms.Button EditVideoButton;
        private System.Windows.Forms.Button DeleteVideoButton;
        private System.Windows.Forms.Button AddVideoButton;
        private System.Windows.Forms.Button CustomersPortalButton;
        private System.Windows.Forms.Button PaymentsPortalButton;
        private System.Windows.Forms.Button StoresPortalButton;
        private System.Windows.Forms.DataGridView InventoryGridView;
        private System.Windows.Forms.GroupBox EditControlsSearchBox;
        private System.Windows.Forms.ComboBox GenreInventoryEditComboBox;
        private System.Windows.Forms.TextBox GenreIDInventoryEditTextBox;
        private System.Windows.Forms.TextBox PriceInventoryEditTextBox;
        private System.Windows.Forms.ComboBox DownloadTypeInventoryEditComboBox;
        private System.Windows.Forms.ComboBox MediaTypeInventoryEditComboBox;
        private System.Windows.Forms.TextBox TotalQuantityInventoryTextBox;
        private System.Windows.Forms.TextBox QuantityCheckedOutInventoryTextBox;
        private System.Windows.Forms.TextBox QuantityInStockInventoryTextBox;
        private System.Windows.Forms.TextBox VideoNameInventoryTextBox;
        private System.Windows.Forms.TextBox VideoIDInventoryControlTextBox;
        private System.Windows.Forms.Label AdultInventoryEditLabel;
        private System.Windows.Forms.Label GenreInventoryEditLabel;
        private System.Windows.Forms.Label GenreIDInventoryEditLabel;
        private System.Windows.Forms.Label PriceInventoryEditLabel;
        private System.Windows.Forms.Label DownloadTypeInventoryEditLabel;
        private System.Windows.Forms.Label MediaTypeInventoryLabel;
        private System.Windows.Forms.Label TotalQuantityInventoryLabel;
        private System.Windows.Forms.Label QuantityCheckedOutInventoryLabel;
        private System.Windows.Forms.Label QuantityInStockInventoryLabel;
        private System.Windows.Forms.Label VideoNameInventoryLabel;
        private System.Windows.Forms.Label VideoIDEditInvetoryLabel;
        private System.Windows.Forms.Button VideoNameSearchButton;
        private System.Windows.Forms.Button VideoIDSearchButton;
        private System.Windows.Forms.Button GenreSearchButton;
        private System.Windows.Forms.Button MediaTypeSearchButton;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.TextBox VideoIDOutput;
        private System.Windows.Forms.TextBox QtyInStockOutput;
        private System.Windows.Forms.TextBox QtyCheckedOutput;
        private System.Windows.Forms.TextBox TotalQtyOutput;
        private System.Windows.Forms.TextBox MediaTypeOutput;
        private System.Windows.Forms.TextBox DownloadTypeOutput;
        private System.Windows.Forms.TextBox PriceOutput;
        private System.Windows.Forms.TextBox GenreIdOutput;
        private System.Windows.Forms.TextBox GenreOutput;
        private System.Windows.Forms.TextBox AdultOutput;
        private System.Windows.Forms.TextBox VideoNameOutput;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button ClearFieldsButton;
        private System.Windows.Forms.TextBox AdultInventoryEditTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyCheckedOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn downloadType;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adult;
    }
}

