using NeteaseCloudMusicLyricSearch.model;
using NeteaseCloudMusicLyricSearch.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeteaseCloudMusicLyricSearch
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string DATA_PATH = "lyric.dat";
        public MainWindow()
        {
            InitializeComponent();
        }

        async private void Btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            Btn_Refresh.IsEnabled = false;
            var lyricList = await LyricFetchController.FetchLyricList();
            LynicSerialization lynicSerialization = new LynicSerialization("lyric.dat");
            lynicSerialization.Serialize(lyricList);
            Btn_Refresh.IsEnabled = true;
        }

        private void Btn_Find_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LynicSerialization lynicSerialization = new LynicSerialization(DATA_PATH);
                List<LyricModel> lyricList = lynicSerialization.Deserialize();
                LV_ResultList.ItemsSource = LyricSearcher.SearchInLyricList(lyricList, TB_Find.Text);
            }
            catch (FileNotFoundException)
            {
                MessageBoxResult result = MessageBox.Show("Cannot find any lyric. Click refresh button.", "WARN", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }

        private void TB_Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Btn_Find_Click(sender, null);
            }
        }
    }
}
