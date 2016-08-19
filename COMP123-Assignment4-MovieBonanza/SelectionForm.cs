using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : August, 19th, 2016
 * Description : Main program for Movie Bonanza Online Streaming
 * Version : 0.0.3 : Added and connected StreamForm
 */
namespace COMP123_Assignment4_MovieBonanza
{
    public partial class SelectionForm : Form
    {

        public SelectionForm()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(1000);

            InitializeComponent();

            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new SplashForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string currentItem;
        public void movieSelection(string movieTitle)
        {
            switch (CurrentListBox.SelectedItem.ToString())
            {
                case "Season of the Witch":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.seasonofthewitch1;
                    CategoryTextBox.Text = "Sci-Fi";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Green Hornet":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.thegreenhornet1;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Dilemma":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.thedilemma1;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
                case "Death Race 2":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.deathrace21;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "Company Men":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.companymen1;
                    CategoryTextBox.Text = "Drama";
                    CostTextBox.Text = "$1.99";
                    break;
                case "No Strings Attached":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.nostringsattached1;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
                case "The Way Back":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.thewayback1;
                    CategoryTextBox.Text = "Drama";
                    CostTextBox.Text = "$1.99";
                    break;
                case "The Mechanic":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.themechanic1;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Rite":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.therite1;
                    CategoryTextBox.Text = "Horror";
                    CostTextBox.Text = "$2.99";
                    break;
                case "Sanctum":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.sanctum1;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Other Woman":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.theotherwoman1;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Roommate":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.theroommate1;
                    CategoryTextBox.Text = "Thriller";
                    CostTextBox.Text = "$1.99";
                    break;
                case "Waiting for Forever":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.waitingforever1;
                    CategoryTextBox.Text = "Drama";
                    CostTextBox.Text = "$1.99";
                    break;
                case "Gnomeo and Juliet":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.gnomeoandjuliet1;
                    CategoryTextBox.Text = "Family";
                    CostTextBox.Text = "$0.99";
                    break;
                case "Just Go With It":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.justgowithit1;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
                case "The Eagle":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.theeagle1;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "I am Number Four":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.iamnumberfour1;
                    CategoryTextBox.Text = "Sci-Fi";
                    CostTextBox.Text = "$2.99";
                    break;
                case "Footloose":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.footloose1;
                    CategoryTextBox.Text = "New Release";
                    CostTextBox.Text = "$4.99";
                    break;
                case "Real Steel":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.realsteel1;
                    CategoryTextBox.Text = "New Release";
                    CostTextBox.Text = "$4.99";
                    break;
                case "Cedar Rapids":
                    SelectedMoviePictureBox.Image = COMP123_Assignment4_MovieBonanza.Properties.Resources.cedarrapids1;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
            }
        }
        private void CurrentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = CurrentListBox.SelectedItem.ToString();
            currentItem = CurrentListBox.SelectedItem.ToString();
            movieSelection(currentItem);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.selectionForm = this;
            orderForm.MovieTitles = this.TitleTextBox.Text;
            orderForm.MovieCategory = this.CategoryTextBox.Text;
            orderForm.MovieCost = this.CostTextBox.Text;
            orderForm.MoviePicture = this.SelectedMoviePictureBox.Image;

            orderForm.Show();
            this.Hide();
        }
    }
}
