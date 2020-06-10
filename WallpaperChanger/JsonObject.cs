using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperChanger
{
    public class JsonObject
    {
        public List <Hits> Hits { get; set; }
    }

    public class Hits
    {
        public string largeImageURL { get; set; }
        public string previewURL { get; set; }
        public int id { get; set; }

    }
}
