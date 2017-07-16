using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.model
{
    public class LyricSearchResult
    {
        public string Title
        {
            get
            {
                if (lyric != null)
                    return lyric.Title ?? "";
                else
                    return "";
            }
            set { }
        }
        public string TrackId
        {
            get
            {
                if (lyric != null)
                    return lyric.TrackId ?? "";
                else
                    return "";
            }
            set { }
        }

        public LyricModel lyric { set; get; }

        public List<string> Lines
        {
            get
            {
                if (lines == null)
                {
                    lines = new List<string>();
                }
                return lines;
            }
        }
        private List<string> lines;
    }
}
