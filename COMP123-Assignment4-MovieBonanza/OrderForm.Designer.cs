namespace COMP123_Assignment4_MovieBonanza
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderMoviePictureBox = new System.Windows.Forms.PictureBox();
            this.OrderCategoryTextBox = new System.Windows.Forms.TextBox();
            this.OrderCategory = new System.Windows.Forms.Label();
            this.OrderTitleTextBox = new System.Windows.Forms.TextBox();
            this.OrderTitleLabel = new System.Windows.Forms.Label();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderGrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.OrderGrandTotalLabel = new System.Windows.Forms.Label();
            this.OrderTaxTextBox = new System.Windows.Forms.TextBox();
            this.OrderTaxLabel = new System.Windows.Forms.Label();
            this.OrderSubTotalTextBox = new System.Windows.Forms.TextBox();
            this.OrderSubTotalLabel = new System.Windows.Forms.Label();
            this.OrderAddTextBox = new System.Windows.Forms.TextBox();
            this.OrderAddLabel = new System.Windows.Forms.Label();
            this.OrderCostTextBox = new System.Windows.Forms.TextBox();
            this.OrderCostLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderMoviePictureBox)).BeginInit();
            this.YourOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.streamToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.OrderMoviePictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.OrderCategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.OrderCategory);
            this.MovieSelectedGroupBox.Controls.Add(this.OrderTitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.OrderTitleLabel);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(13, 28);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(303, 420);
            this.MovieSelectedGroupBox.TabIndex = 1;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movies Selected";
            // 
            // OrderMoviePictureBox
            // 
            this.OrderMoviePictureBox.Location = new System.Drawing.Point(60, 141);
            this.OrderMoviePictureBox.Name = "OrderMoviePictureBox";
            this.OrderMoviePictureBox.Size = new System.Drawing.Size(179, 249);
            this.OrderMoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OrderMoviePictureBox.TabIndex = 4;
            this.OrderMoviePictureBox.TabStop = false;
            // 
            // OrderCategoryTextBox
            // 
            this.OrderCategoryTextBox.Location = new System.Drawing.Point(11, 107);
            this.OrderCategoryTextBox.Name = "OrderCategoryTextBox";
            this.OrderCategoryTextBox.ReadOnly = true;
            this.OrderCategoryTextBox.Size = new System.Drawing.Size(286, 27);
            this.OrderCategoryTextBox.TabIndex = 3;
            // 
            // OrderCategory
            // 
            this.OrderCategory.AutoSize = true;
            this.OrderCategory.Location = new System.Drawing.Point(11, 84);
            this.OrderCategory.Name = "OrderCategory";
            this.OrderCategory.Size = new System.Drawing.Size(71, 19);
            this.OrderCategory.TabIndex = 2;
            this.OrderCategory.Text = "Category";
            // 
            // OrderTitleTextBox
            // 
            this.OrderTitleTextBox.Location = new System.Drawing.Point(11, 50);
            this.OrderTitleTextBox.Name = "OrderTitleTextBox";
            this.OrderTitleTextBox.ReadOnly = true;
            this.OrderTitleTextBox.Size = new System.Drawing.Size(286, 27);
            this.OrderTitleTextBox.TabIndex = 1;
            // 
            // OrderTitleLabel
            // 
            this.OrderTitleLabel.AutoSize = true;
            this.OrderTitleLabel.Location = new System.Drawing.Point(7, 27);
            this.OrderTitleLabel.Name = "OrderTitleLabel";
            this.OrderTitleLabel.Size = new System.Drawing.Size(38, 19);
            this.OrderTitleLabel.TabIndex = 0;
            this.OrderTitleLabel.Text = "Title";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.OrderCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.OrderGrandTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.OrderGrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.OrderTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.OrderTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.OrderSubTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.OrderSubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.OrderAddTextBox);
            this.YourOrderGroupBox.Controls.Add(this.OrderAddLabel);
            this.YourOrderGroupBox.Controls.Add(this.OrderCostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.OrderCostLabel);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(323, 27);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(349, 346);
            this.YourOrderGroupBox.TabIndex = 2;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // OrderCheckBox
            // 
            this.OrderCheckBox.AutoSize = true;
            this.OrderCheckBox.Location = new System.Drawing.Point(17, 317);
            this.OrderCheckBox.Name = "OrderCheckBox";
            this.OrderCheckBox.Size = new System.Drawing.Size(314, 23);
            this.OrderCheckBox.TabIndex = 10;
            this.OrderCheckBox.Text = "Order the DVD (adds $10.00 to your order)";
            this.OrderCheckBox.UseVisualStyleBackColor = true;
            this.OrderCheckBox.CheckedChanged += new System.EventHandler(this.OrderCheckBox_CheckedChanged);
            // 
            // OrderGrandTotalTextBox
            // 
            this.OrderGrandTotalTextBox.Location = new System.Drawing.Point(231, 269);
            this.OrderGrandTotalTextBox.Name = "OrderGrandTotalTextBox";
            this.OrderGrandTotalTextBox.ReadOnly = true;
            this.OrderGrandTotalTextBox.Size = new System.Drawing.Size(100, 27);
            this.OrderGrandTotalTextBox.TabIndex = 9;
            // 
            // OrderGrandTotalLabel
            // 
            this.OrderGrandTotalLabel.AutoSize = true;
            this.OrderGrandTotalLabel.Location = new System.Drawing.Point(137, 277);
            this.OrderGrandTotalLabel.Name = "OrderGrandTotalLabel";
            this.OrderGrandTotalLabel.Size = new System.Drawing.Size(88, 19);
            this.OrderGrandTotalLabel.TabIndex = 8;
            this.OrderGrandTotalLabel.Text = "Grand Total";
            // 
            // OrderTaxTextBox
            // 
            this.OrderTaxTextBox.Location = new System.Drawing.Point(231, 233);
            this.OrderTaxTextBox.Name = "OrderTaxTextBox";
            this.OrderTaxTextBox.ReadOnly = true;
            this.OrderTaxTextBox.Size = new System.Drawing.Size(100, 27);
            this.OrderTaxTextBox.TabIndex = 7;
            // 
            // OrderTaxLabel
            // 
            this.OrderTaxLabel.AutoSize = true;
            this.OrderTaxLabel.Location = new System.Drawing.Point(118, 241);
            this.OrderTaxLabel.Name = "OrderTaxLabel";
            this.OrderTaxLabel.Size = new System.Drawing.Size(107, 19);
            this.OrderTaxLabel.TabIndex = 6;
            this.OrderTaxLabel.Text = "Sales Tax (13%)";
            // 
            // OrderSubTotalTextBox
            // 
            this.OrderSubTotalTextBox.Location = new System.Drawing.Point(146, 149);
            this.OrderSubTotalTextBox.Name = "OrderSubTotalTextBox";
            this.OrderSubTotalTextBox.ReadOnly = true;
            this.OrderSubTotalTextBox.Size = new System.Drawing.Size(100, 27);
            this.OrderSubTotalTextBox.TabIndex = 5;
            // 
            // OrderSubTotalLabel
            // 
            this.OrderSubTotalLabel.AutoSize = true;
            this.OrderSubTotalLabel.Location = new System.Drawing.Point(54, 157);
            this.OrderSubTotalLabel.Name = "OrderSubTotalLabel";
            this.OrderSubTotalLabel.Size = new System.Drawing.Size(72, 19);
            this.OrderSubTotalLabel.TabIndex = 4;
            this.OrderSubTotalLabel.Text = "Sub Total";
            // 
            // OrderAddTextBox
            // 
            this.OrderAddTextBox.Location = new System.Drawing.Point(146, 116);
            this.OrderAddTextBox.Name = "OrderAddTextBox";
            this.OrderAddTextBox.ReadOnly = true;
            this.OrderAddTextBox.Size = new System.Drawing.Size(100, 27);
            this.OrderAddTextBox.TabIndex = 3;
            // 
            // OrderAddLabel
            // 
            this.OrderAddLabel.AutoSize = true;
            this.OrderAddLabel.Location = new System.Drawing.Point(13, 124);
            this.OrderAddLabel.Name = "OrderAddLabel";
            this.OrderAddLabel.Size = new System.Drawing.Size(113, 19);
            this.OrderAddLabel.TabIndex = 2;
            this.OrderAddLabel.Text = "Additional Cost";
            // 
            // OrderCostTextBox
            // 
            this.OrderCostTextBox.Location = new System.Drawing.Point(146, 82);
            this.OrderCostTextBox.Name = "OrderCostTextBox";
            this.OrderCostTextBox.ReadOnly = true;
            this.OrderCostTextBox.Size = new System.Drawing.Size(100, 27);
            this.OrderCostTextBox.TabIndex = 1;
            // 
            // OrderCostLabel
            // 
            this.OrderCostLabel.AutoSize = true;
            this.OrderCostLabel.Location = new System.Drawing.Point(86, 90);
            this.OrderCostLabel.Name = "OrderCostLabel";
            this.OrderCostLabel.Size = new System.Drawing.Size(40, 19);
            this.OrderCostLabel.TabIndex = 0;
            this.OrderCostLabel.Text = "Cost";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(322, 410);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 38);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.BackColor = System.Drawing.Color.ForestGreen;
            this.StreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StreamButton.Location = new System.Drawing.Point(597, 409);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(75, 39);
            this.StreamButton.TabIndex = 4;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = false;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(507, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 39);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderMoviePictureBox)).EndInit();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label OrderCategory;
        private System.Windows.Forms.Label OrderTitleLabel;
        private System.Windows.Forms.Label OrderCostLabel;
        private System.Windows.Forms.Label OrderSubTotalLabel;
        private System.Windows.Forms.TextBox OrderAddTextBox;
        private System.Windows.Forms.Label OrderAddLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox OrderCheckBox;
        private System.Windows.Forms.TextBox OrderGrandTotalTextBox;
        private System.Windows.Forms.Label OrderGrandTotalLabel;
        private System.Windows.Forms.TextBox OrderTaxTextBox;
        private System.Windows.Forms.Label OrderTaxLabel;
        public System.Windows.Forms.TextBox OrderSubTotalTextBox;
        public System.Windows.Forms.TextBox OrderTitleTextBox;
        public System.Windows.Forms.PictureBox OrderMoviePictureBox;
        public System.Windows.Forms.TextBox OrderCategoryTextBox;
        public System.Windows.Forms.TextBox OrderCostTextBox;
    }
}