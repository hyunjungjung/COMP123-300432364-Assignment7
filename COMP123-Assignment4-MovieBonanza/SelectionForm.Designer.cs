namespace COMP123_Assignment4_MovieBonanza
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectionFormMainLabel = new System.Windows.Forms.Label();
            this.CurrentMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentListBox = new System.Windows.Forms.ListBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectedMoviePictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentMovieGroupBox.SuspendLayout();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionFormMainLabel
            // 
            this.SelectionFormMainLabel.AutoSize = true;
            this.SelectionFormMainLabel.Location = new System.Drawing.Point(13, 13);
            this.SelectionFormMainLabel.Name = "SelectionFormMainLabel";
            this.SelectionFormMainLabel.Size = new System.Drawing.Size(391, 19);
            this.SelectionFormMainLabel.TabIndex = 0;
            this.SelectionFormMainLabel.Text = "Choose the movie you wish to stream from the list below";
            this.SelectionFormMainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentMovieGroupBox
            // 
            this.CurrentMovieGroupBox.Controls.Add(this.CurrentListBox);
            this.CurrentMovieGroupBox.Location = new System.Drawing.Point(13, 36);
            this.CurrentMovieGroupBox.Name = "CurrentMovieGroupBox";
            this.CurrentMovieGroupBox.Size = new System.Drawing.Size(198, 308);
            this.CurrentMovieGroupBox.TabIndex = 1;
            this.CurrentMovieGroupBox.TabStop = false;
            this.CurrentMovieGroupBox.Text = "Current Movies";
            // 
            // CurrentListBox
            // 
            this.CurrentListBox.FormattingEnabled = true;
            this.CurrentListBox.ItemHeight = 19;
            this.CurrentListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.CurrentListBox.Location = new System.Drawing.Point(7, 27);
            this.CurrentListBox.Name = "CurrentListBox";
            this.CurrentListBox.Size = new System.Drawing.Size(185, 270);
            this.CurrentListBox.Sorted = true;
            this.CurrentListBox.TabIndex = 0;
            this.CurrentListBox.SelectedIndexChanged += new System.EventHandler(this.CurrentListBox_SelectedIndexChanged);
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.NextButton);
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Controls.Add(this.SelectedMoviePictureBox);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(218, 47);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(454, 297);
            this.YourSelectionGroupBox.TabIndex = 2;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(371, 252);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(354, 179);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(92, 27);
            this.CostTextBox.TabIndex = 6;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(350, 157);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 19);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(192, 179);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(156, 27);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(192, 157);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(71, 19);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(192, 106);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(255, 27);
            this.TitleTextBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(192, 83);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 19);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // SelectedMoviePictureBox
            // 
            this.SelectedMoviePictureBox.ErrorImage = null;
            this.SelectedMoviePictureBox.Image = global::COMP123_Assignment4_MovieBonanza.Properties.Resources.cedarrapids1;
            this.SelectedMoviePictureBox.Location = new System.Drawing.Point(7, 27);
            this.SelectedMoviePictureBox.Name = "SelectedMoviePictureBox";
            this.SelectedMoviePictureBox.Size = new System.Drawing.Size(179, 249);
            this.SelectedMoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectedMoviePictureBox.TabIndex = 0;
            this.SelectedMoviePictureBox.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(684, 351);
            this.ControlBox = false;
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.CurrentMovieGroupBox);
            this.Controls.Add(this.SelectionFormMainLabel);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Movie to Stream";
            this.CurrentMovieGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectionFormMainLabel;
        private System.Windows.Forms.GroupBox CurrentMovieGroupBox;
        private System.Windows.Forms.ListBox CurrentListBox;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox SelectedMoviePictureBox;
        public System.Windows.Forms.TextBox TitleTextBox;
    }
}

