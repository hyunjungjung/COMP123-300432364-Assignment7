using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : August, 19th, 2016
 * Description : OrderForm for Movie Bonanza Online Streaming
 * Version : 0.0.4 : Final commit
 */
namespace COMP123_Assignment4_MovieBonanza
{

    public partial class OrderForm : Form
    {
        
        private string _movieTitle, _movieCategory, _movieCost;
        public SelectionForm selectionForm { get; set; }
        public string MovieTitles
        {
            get { return _movieTitle; }
            set { _movieTitle = value; }
        }
        public string MovieCategory
        {
            get { return _movieCategory; }
            set { _movieCategory = value; }
        }
        public string MovieCost
        {
            get { return _movieCost; }
            set { _movieCost = value; }
        }
        public Image MoviePicture{ get; set; }

        public OrderForm()
        {
            InitializeComponent();
            OrderTitleTextBox.Text = MovieTitles;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.selectionForm.Show();
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectionForm.Close();
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            OrderTitleTextBox.Text = _movieTitle;
            OrderCategoryTextBox.Text = _movieCategory;
            OrderCostTextBox.Text = _movieCost;
            OrderMoviePictureBox.Image = MoviePicture;
            CalculateTotal();

        }
        private void CalculateTotal()
        {
            decimal cost = decimal.Parse(OrderCostTextBox.Text, System.Globalization.NumberStyles.Currency);
            double subTotal = 0;
            double tax = 0.13;
            if (OrderCheckBox.Checked == true)
            {
                OrderAddLabel.Visible = true;
                OrderAddTextBox.Visible = true;

                subTotal = double.Parse(OrderCostTextBox.Text, System.Globalization.NumberStyles.Currency) + 10;
                tax *= (double)subTotal;
                OrderAddTextBox.Text = "$10.00";
                OrderTaxTextBox.Text = string.Format("{0:c}", tax);
                OrderSubTotalTextBox.Text = string.Format("{0:c}", subTotal);
                OrderGrandTotalTextBox.Text = string.Format("{0:c}", (tax + (double)subTotal));
            }
            else
            {
                OrderAddLabel.Visible = false;
                OrderAddTextBox.Visible = false;

                subTotal = (double)cost;
                tax *= (double)subTotal;
                OrderSubTotalTextBox.Text = string.Format("{0:c}", subTotal);
                OrderTaxTextBox.Text = string.Format("{0:c}", tax);
                OrderGrandTotalTextBox.Text = string.Format("{0:c}", (tax + (double)subTotal));
            }

        }

        private void OrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            CalculateTotal();

        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamButton_Click(sender, e);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
           
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order detail will be printed");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            // show dialog
            aboutBox.ShowDialog();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            
            StreamForm streamForm = new StreamForm();
            streamForm.orderForm = this;
            streamForm.StreamCostTextBox.Text = OrderGrandTotalTextBox.Text;
            streamForm.StreamTitleTextBox.Text = OrderTitleTextBox.Text;
            streamForm.Show();
            this.Hide();

        }
    }
}
