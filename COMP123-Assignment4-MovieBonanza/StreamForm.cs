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
 * Description : StreamForm for Movie Bonanza Online Streaming
 * Version : 0.0.4 : Final commit
 */
namespace COMP123_Assignment4_MovieBonanza
{
    public partial class StreamForm : Form
    {
        private string _movieTitle, _movieCost;
        public OrderForm orderForm { get; set; }
        //public string MovieTitles
        //{
        //    get { return _movieTitle; }
        //    set { _movieTitle = value; }
        //}
        //public string MovieCost
        //{
        //    get { return _movieCost; }
        //    set { _movieCost = value; }
        //}

        public StreamForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {

        }


    }
}
