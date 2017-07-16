using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeteaseCloudMusicLyricSearch.model;
using NeteaseCloudMusicLyricSearch.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util.Tests
{
    [TestClass()]
    public class WebControllerTests
    {

        [TestMethod()]
        async public Task FetchSimpleLyricByTrackIdTest()
        {
            LyricSimpleJson result = await WebController.FetchSimpleLyricByTrackId("409326722");
        }

        [TestMethod()]
        public async Task FetchRichLyricByTrackIdTest()
        {
            LyricRichJson result = await WebController.FetchRichLyricByTrackId("409326722");
        }
    }
}