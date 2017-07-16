using NeteaseCloudMusicLyricSearch.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util
{
    public class LynicSerialization
    {
        private string storePath;
        public LynicSerialization(string storePath)
        {
            this.storePath = storePath;
        }

        public void Serialize(List<LyricModel> lyricList)
        {
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream s = new FileStream(storePath, FileMode.Create);
            bformatter.Serialize(s, lyricList);
            s.Close();

        }

        public List<LyricModel> Deserialize()
        {
            try
            {
                Stream stream = File.Open(storePath, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                List<LyricModel> lyricList = (List<LyricModel>)bformatter.Deserialize(stream);
                stream.Close();

                return lyricList;
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
        }

        public List<LyricModel> Deserialize(string storePath)
        {
            throw new NotImplementedException();
        }
    }
}
