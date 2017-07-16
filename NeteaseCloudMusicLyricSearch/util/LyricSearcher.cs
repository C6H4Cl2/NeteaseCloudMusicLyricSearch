using NeteaseCloudMusicLyricSearch.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util
{
    public class LyricSearcher
    {
        public static List<LyricSearchResult> SearchInLyricList(List<LyricModel> lyricList, string keyword)
        {
            var lyricSearchResultList = new List<LyricSearchResult>();
            if (lyricList != null && !String.IsNullOrWhiteSpace(keyword))
            {
                foreach (var lyric in lyricList)
                {
                    if (lyric.OriginalLyric != null)
                    {
                        var lyricSearchResult = new LyricSearchResult() { lyric = lyric };

                        var lyricLines = lyric.OriginalLyric.Split('\n');
                        foreach (var line in lyricLines)
                        {
                            if (line.Contains(keyword))
                                lyricSearchResult.Lines.Add(line.Trim());
                        }

                        if (lyricSearchResult.Lines.Count > 0) lyricSearchResultList.Add(lyricSearchResult);
                    }
                }
            }
            return lyricSearchResultList;
        }

        public static List<LyricSearchResult> RegexInLyricList(List<LyricRichJson> lyricList, string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
