using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeteaseCloudMusicLyricSearch.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeteaseCloudMusicLyricSearch.util.Tests
{
    [TestClass()]
    public class LyricControllerTests
    {
        [TestMethod()]
        async public Task FetchLyricListTest()
        {
            var result = await LyricFetchController.FetchLyricList();
        }
    }
}