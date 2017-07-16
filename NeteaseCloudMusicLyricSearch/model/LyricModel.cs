using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.model
{
    [Serializable]
    public class LyricModel : ISerializable
    {
        public string TrackId { set; get; }
        public string Title { set; get; }
        public string OriginalLyric { set; get; }

        public LyricModel() { }

        public LyricModel(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            TrackId = (String)info.GetValue("TrackId", typeof(string));
            Title = (String)info.GetValue("Title", typeof(string));
            OriginalLyric = (String)info.GetValue("OriginalLyric", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("TrackId", TrackId, typeof(string));
            info.AddValue("Title", Title, typeof(string));
            info.AddValue("OriginalLyric", OriginalLyric, typeof(string));
        }
    }
}
