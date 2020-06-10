using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBT_Click(object sender, EventArgs e)
        {
            // check if the query was just checked, and if they search was successful. DONT allow if true

            // Takes the key, search q, orietnation

            
            string searchQuery = searchQueryTB.Text;
            string orientation;
            if (verticalRB.Checked)
                orientation = "vertical";
            else
                orientation = "horizontal";
            JsonObject response;


            if (!String.IsNullOrEmpty(searchQuery) && !String.IsNullOrWhiteSpace(searchQuery))
            {
                searchQuery = searchQuery.Trim().Replace(" ","+");
                // removes leading and trailing spaces
                // replaces spaces in string with + easier for Json query

                // calls JsonParser
               // MessageBox.Show(searchQuery + "/'");
                response = InfoProcessor.JsonParser(searchQuery, orientation);

                if (response == null || response.Hits.Count() == 0)
                {
                    MessageBox.Show("Couldn't find any pictures. Try another search term");
                }
                else
                {
                    // Stores the obj that is returned

                    Properties.Settings.Default.imageList = response;
                    Properties.Settings.Default.Save();

                    JsonObject tempObj = Properties.Settings.Default.imageList;
                    /*
                    foreach (var item in tempObj.Hits)
                    {
                        MessageBox.Show(item.largeImageURL);
                    }
                    */

                    // Calls UpdatePictureBox

                    pictureBox1.Load(Wallpaper.UpdatePictureBox());
                }
            }  
        }

        private void randomizeBT_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(Wallpaper.UpdatePictureBox());
        }

        private void pixabayLogo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to go to the Pixabay website?", "Open Link?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://pixabay.com");
            }
        }

        private void applyBT_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox1 == null)
                MessageBox.Show("No image selected");
            else
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Wallpaper Changer\res";
                Wallpaper.ChangeWallpaper(path, true);
                MessageBox.Show("Wallpaper Applied!");
            }
        }
    }
}
