using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WallpaperChanger
{
    public class Wallpaper
    {
        public static int currentID { get; set; }

        public static string UpdatePictureBox()
        {
            // retrieves the imageList object stored on file

            JsonObject obj = Properties.Settings.Default.imageList;

            if (obj.Hits.Count() == 0 || obj == null)
            {
                MessageBox.Show("Could not find any images to preview");
                return null;
            }
            else
            {
                // To use in random number generator below
                int numberOfHits = obj.Hits.Count();
                Random rnd = new Random();

                // random number to use as index to get image from imageList
                int r = rnd.Next(numberOfHits);

                // gets a preview URL and returns it
                string url = obj.Hits[r].previewURL;

                // sets currentID to obj ID
                currentID = obj.Hits[r].id;

                // returns URL
                return url;

                // applies URL to picturebox - return URL to form and change there
            }
        }

        public static void ChangeWallpaper(string path, bool applyChanges)
        {
            try
            {
                // WRONG!!! need to get largeimageURL again from parseJson File bruh

                int id = Wallpaper.currentID;
                string url = InfoProcessor.GetLargeImageUrl(id);
                MessageBox.Show("imageURL is: " + url);

                if (!String.IsNullOrEmpty(url))
                {
                    // Create directory if not yet created
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    // downloads the image
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(url), path + @"\image1.jpg");
                    }

                    // returns a 1
                    // @"c:\temp\image1.jpg"
                    int result = SystemParametersInfo(SPI_SETDESKWALLPAPER, 1, path + @"\image1.jpg", SPIF_SENDCHANGE);
                    SetRegistryKeyForWallpaper("WallPaper", path + @"\image1.jpg");
                }
                else
                    MessageBox.Show("Could not apply wallpaper");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR" + e.Message);
            }
        }

        private static void SetRegistryKeyForWallpaper(string keyName, string value)
        {
            RegistryKey desktopKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            desktopKey.SetValue(keyName, value);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_SENDCHANGE = 0x2;

        // int result = SystemParametersInfo(SPI_SETDESKWALLPAPER, 1, @"c:\temp\image1.jpg", SPIF_SENDCHANGE);

    }
}
