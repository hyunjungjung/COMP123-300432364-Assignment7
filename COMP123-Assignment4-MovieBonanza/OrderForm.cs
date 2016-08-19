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
 * Description : Main program for Movie Bonanza Online Streaming
 * Version : 0.0.2 : Added and connected OrderForm with SelectionForm
 */
namespace COMP123_Assignment4_MovieBonanza
{

    public partial class OrderForm : Form
    {
        public SelectionForm selectionForm { get; set; }
        public string MovieTitles
        {
            get;
            set;
        }
        public string MovieCategory
        {
            get;
            set;
        }
        public string MovieCost
        {
            get;
            set;
        }

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
            OrderTitleTextBox.Text = MovieTitles;
            OrderCategoryTextBox.Text = MovieCategory;
            OrderCostTextBox.Text = MovieCost;
        }
    }
}
