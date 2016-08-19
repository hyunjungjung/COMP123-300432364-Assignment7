namespace COMP123_Assignment4_MovieBonanza
{
    partial class StreamForm
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
            this.StreamLabel1 = new System.Windows.Forms.Label();
            this.StreamLabel2 = new System.Windows.Forms.Label();
            this.StreamCostTextBox = new System.Windows.Forms.TextBox();
            this.StreamTitleTextBox = new System.Windows.Forms.TextBox();
            this.StreamLabel3 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StreamLabel1
            // 
            this.StreamLabel1.AutoSize = true;
            this.StreamLabel1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel1.Location = new System.Drawing.Point(13, 13);
            this.StreamLabel1.Name = "StreamLabel1";
            this.StreamLabel1.Size = new System.Drawing.Size(401, 29);
            this.StreamLabel1.TabIndex = 0;
            this.StreamLabel1.Text = "Thank you for coosing Movie Bonanza!";
            // 
            // StreamLabel2
            // 
            this.StreamLabel2.AutoSize = true;
            this.StreamLabel2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel2.Location = new System.Drawing.Point(27, 83);
            this.StreamLabel2.Name = "StreamLabel2";
            this.StreamLabel2.Size = new System.Drawing.Size(222, 19);
            this.StreamLabel2.TabIndex = 1;
            this.StreamLabel2.Text = "Your credit card will be charged";
            // 
            // StreamCostTextBox
            // 
            this.StreamCostTextBox.Location = new System.Drawing.Point(277, 83);
            this.StreamCostTextBox.Name = "StreamCostTextBox";
            this.StreamCostTextBox.Size = new System.Drawing.Size(100, 23);
            this.StreamCostTextBox.TabIndex = 2;
            // 
            // StreamTitleTextBox
            // 
            this.StreamTitleTextBox.Location = new System.Drawing.Point(138, 129);
            this.StreamTitleTextBox.Name = "StreamTitleTextBox";
            this.StreamTitleTextBox.Size = new System.Drawing.Size(130, 23);
            this.StreamTitleTextBox.TabIndex = 3;
            // 
            // StreamLabel3
            // 
            this.StreamLabel3.AutoSize = true;
            this.StreamLabel3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel3.Location = new System.Drawing.Point(105, 155);
            this.StreamLabel3.Name = "StreamLabel3";
            this.StreamLabel3.Size = new System.Drawing.Size(196, 19);
            this.StreamLabel3.TabIndex = 4;
            this.StreamLabel3.Text = "will begin streaming shortly";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(174, 245);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 301);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.StreamLabel3);
            this.Controls.Add(this.StreamTitleTextBox);
            this.Controls.Add(this.StreamCostTextBox);
            this.Controls.Add(this.StreamLabel2);
            this.Controls.Add(this.StreamLabel1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StreamForm";
            this.Text = "Your Movie is about to start!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StreamLabel1;
        private System.Windows.Forms.Label StreamLabel2;
        public System.Windows.Forms.TextBox StreamCostTextBox;
        private System.Windows.Forms.Label StreamLabel3;
        public System.Windows.Forms.TextBox StreamTitleTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}