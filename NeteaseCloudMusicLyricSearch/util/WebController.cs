using NeteaseCloudMusicLyricSearch.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util
{
    public class WebController
    {
    
        public static readonly string RICH_LYRIC_URL = "http://music.163.com/api/song/lyric?os=pc&id={0}&lv=-1&kv=-1&tv=-1";
        public static readonly string SIMPLE_LYRIC_URL = "http://music.163.com/api/song/media?id={0}";

        async static public Task<LyricRichJson> FetchRichLyricByTrackId(string trackId)
        {
            if (String.IsNullOrWhiteSpace(trackId)) return null;

            WebClient client = new WebClient() {Encoding = Encoding.UTF8};
            Uri uri = new Uri(String.Format(RICH_LYRIC_URL, trackId));
            string lyricJson = await client.DownloadStringTaskAsync(uri);

            var jsonSerializerSettings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            LyricRichJson item = JsonConvert.DeserializeObject<LyricRichJson>(lyricJson, jsonSerializerSettings);

            return item;
        }

        async static public Task<LyricSimpleJson> FetchSimpleLyricByTrackId(string trackId)
        {
            if (String.IsNullOrWhiteSpace(trackId)) return null;

            WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
            Uri uri = new Uri(String.Format(SIMPLE_LYRIC_URL, trackId));
            string lyricJson = await client.DownloadStringTaskAsync(uri);

            var jsonSerializerSettings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
            LyricSimpleJson item = JsonConvert.DeserializeObject<LyricSimpleJson>(lyricJson, jsonSerializerSettings);

            return item;
        }
    }
}
