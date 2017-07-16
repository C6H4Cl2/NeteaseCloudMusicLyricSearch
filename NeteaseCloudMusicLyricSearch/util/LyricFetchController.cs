using NeteaseCloudMusicLyricSearch.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util
{
    public class LyricFetchController
    {
        async public static Task<List<LyricModel>> FetchLyricList()
        {
            var lyricModelList = WebdbDatabaseController.ReadDb();

            return await FetchLyricList(lyricModelList);
        }

        async public static Task<List<LyricModel>> FetchLyricList(List<LyricModel> lyricModelList)
        {
            if (lyricModelList == null) return null;
            var tasks = new List<Task>();
            foreach (var lyric in lyricModelList)
            {
               tasks.Add(LyricPopulator.Populate(lyric));
            }
            await Task.WhenAll(tasks);

            return lyricModelList;
        }
    }
}
