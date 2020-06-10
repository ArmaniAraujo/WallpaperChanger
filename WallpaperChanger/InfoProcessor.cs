using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace WallpaperChanger
{
    public class InfoProcessor
    {
        public static JsonObject JsonParser(string searchStr, string orientation)
        {
            string key = Properties.Settings.Default.key;
            if (key != null)
            {
                string baseUrl = $"https://pixabay.com/api/?key=16798870-3b75722e0d8caeefc7b1664bd&min_width=1080&min_width=1920&image_type=photo&pretty=true";

                if (!String.IsNullOrEmpty(searchStr) && !String.IsNullOrWhiteSpace(searchStr))
                    baseUrl += $"&q={searchStr}";
                if (!String.IsNullOrEmpty(orientation) && !String.IsNullOrWhiteSpace(orientation))
                    baseUrl += $"&orientation={orientation}";

                string json;

                using (WebClient client = new WebClient())
                {
                    json = client.DownloadString(baseUrl);
                }

                JsonObject response = JsonConvert.DeserializeObject<JsonObject>(json);
                /*
                foreach (var i in response.Hits)
                {
                    MessageBox.Show(i.id.ToString());
                }
                */

                return response;
            }
            else
            {
                MessageBox.Show("Error! No key");
                return null;
            }
        }

        public static string GetLargeImageUrl(int id)
        {
            string key = Properties.Settings.Default.key;
            if (key != null)
            {
                string baseUrl = $"https://pixabay.com/api/?key=16798870-3b75722e0d8caeefc7b1664bd&min_width=1080&min_width=1920&image_type=photo&pretty=true";

                if (id != 0)
                    baseUrl += $"&id={id}";

                string json;

                using (WebClient client = new WebClient())
                {
                    json = client.DownloadString(baseUrl);
                }

                JsonObject response = JsonConvert.DeserializeObject<JsonObject>(json);
                

                return (response.Hits[0].largeImageURL);
            }
            else
            {
                MessageBox.Show("Error! No key");
                return null;
            }
        }
    }
}