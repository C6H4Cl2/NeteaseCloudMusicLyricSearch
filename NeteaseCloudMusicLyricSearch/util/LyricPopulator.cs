using NeteaseCloudMusicLyricSearch.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util
{
    public class LyricPopulator
    {
        async static public Task Populate(LyricModel lyric)
        {
            var simpleLyric = await WebController.FetchSimpleLyricByTrackId(lyric.TrackId);
            lyric.OriginalLyric = simpleLyric.lyric;
        }
    }
}
