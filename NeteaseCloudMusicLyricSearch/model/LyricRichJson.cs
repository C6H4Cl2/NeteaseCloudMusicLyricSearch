using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.model
{
    public class LyricRichJson
    {
        public bool uncollected { set; get; }
        public int code { set; get; }
        public LyricUser lyricUser { set; get; }
        public TransUser transUser { set; get; }
        public Lrc lrc { set; get; }
        public Klyric klyric { set; get; }
        public Tlyric tlyric { set; get; }

        public class LyricUser
        {
            public string id { set; get; }
            public string userid { set; get; }
            public string nickname { set; get; }
        }

        public class TransUser
        {
            public string id { set; get; }
            public string userid { set; get; }
            public string nickname { set; get; }
        }

        public class Lrc
        {
            public int version { set; get; }
            public string lyric { set; get; }
        }

        public class Klyric
        {
            public int version { set; get; }
            public string lyric { set; get; }
        }

        public class Tlyric
        {
            public int version { set; get; }
            public string lyric { set; get; }
        }
    }

    
}
