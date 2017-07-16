using NeteaseCloudMusicLyricSearch.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util
{
    class WebdbDatabaseController
    {
        static private readonly string TEMP_DB_PATH = @"C:\Users\spicy\AppData\Local\Netease\CloudMusic\Library\webdb.dat";

        static private SQLiteConnection db = null;

        static private void ConnectDb()
        {
            if (db != null) return;
            string connectionInfo = String.Format("Data Source={0};Version=3;", TEMP_DB_PATH);
            db = new SQLiteConnection(connectionInfo);
            db.Open();
        }

        static private void CloseDb()
        {
            if (db != null)
                db.Close();
        }

        static public List<LyricModel> ReadDb()
        {
            var lyricModelList = new List<LyricModel>();

            try
            {
                ConnectDb();

                string sql = "select * from web_offline_track";
                SQLiteCommand command = new SQLiteCommand(sql, db);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lyricModelList.Add(new LyricModel()
                    {
                        TrackId = reader["track_id"].ToString(),
                        Title = reader["track_name"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                CloseDb();
            }
            return lyricModelList;
        }
    }
}
