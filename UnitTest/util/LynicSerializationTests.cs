﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class LynicSerializationTests
    {
        private List<LyricModel> lyricList;

        [TestInitialize()]
        public void before()
        {
            lyricList = new List<LyricModel>();
            lyricList.Add(new LyricModel()
            {
                Title = "20世紀の星を浮かべてコペルニクス",
                TrackId = "29017140",
                OriginalLyric = "[by: 浩纸酱_yuliki]\n[00:00.000]\n[00:00.710]20世紀の星を浮かべてコペルニクス\n[00:07.260]さよなら\n[00:12.610]愛し日々よ\n[00:15.790]\n[00:22.040]\n[00:27.730]明日を窓の外に見ていたノスタルジア\n[00:33.490]時をかける君はいつの日も笑った\n[00:39.370]気づけば大人になってしまったレアリスム\n[00:45.140]誰より恋い焦がれた君はもう飛べない\n[00:51.320]子供の頃見た\n[00:52.760]あの人は何処\n[00:54.310]さらば幻\n[00:57.230]右から左 時代が逃げてゆく\n[01:02.460]20世紀の星で生まれてコペルニクス\n[01:08.320]きっと未来には誰も知らない常識が回って\n[01:14.100]どんな世界でもギターを奏でヘンドリックス\n[01:19.450]悲しみなんて消えていることでしょう\n[01:25.900]\n[01:37.480]奇跡のテクノロジーが夢見たエコロジー\n[01:43.370]代償なんていらないはずだよと泣いてみた\n[01:49.160]平和の鳩の群れは砂漠に降り立って\n[01:55.020]おなかが空いたよと大げさに鳴いてみる\n[02:01.200]子供のままでは\n[02:02.640]いられないのかな\n[02:04.040]さらば思い出\n[02:07.040]翼を広げビルから目を閉じて\n[02:12.270]20世紀の星を嘆いてコペルニクス\n[02:18.060]一人探して求めたものは何も見えないままで\n[02:23.940]分かり合うにも幼すぎたの コンプレックス\n[02:29.220]情熱ばかり消えてしまわないで\n[02:35.680]\n[02:50.430]20世紀の星は呟く「また会いましょう」\n[02:56.650]巡り巡れば出会える昨日 変わりもしないままで\n[03:02.420]人が回れば空も回ると信じ合って\n[03:07.750]このままどこへ流れていくのでしょう\n[03:13.500]\n[03:14.080]明日も宛て無く星を彷徨うコペルニクス\n[03:19.820]きっと未来には誰も知らない常識が回って\n[03:25.710]どんな世界でもギターを奏でヘンドリックス\n[03:31.050]悲しみなんて消えていることでしょう\n[03:36.880]私もきっと消えていることでしょう\n[03:46.100]\n[03:52.050]\n"
            });
            lyricList.Add(new LyricModel()
            {
                Title = "弱虫モンブラン",
                TrackId = "22811615",
                OriginalLyric = "[by:kanlei]\n[ti:弱虫モンブラン]\n[ar:GUMI]\n[al:-パラヴレルワールド- 発売:2010年7月19日]\n[by:CHHKKE]\n[00:00.660]ありったけの想いは これだけの言葉に\n[00:09.150]愛したけど重いわ それだけのことなの？\n[00:19.880]\n[00:25.350]愛したのは誰だっけ？ アレほどの時間が\n[00:33.180]消えて、見えなくなった まだ触れてるハズなのに\n[00:40.790]\n[00:42.150]忘れてしまえば 消える反照(はんしょう)\n[00:48.940]\n[00:49.610]本当だって良いと 思えないの\n[00:54.150]アタシはまだ弱い虫\n[00:57.470]コントラクト会議\n[01:00.190]アタシはまた キミの中に堕ちていくの\n[01:08.210]\n[01:13.120]ありったけの想いは これだけの言葉に\n[01:21.150]愛したけど重いわ それだけのことなの？\n[01:28.750]\n[01:29.410]愛したのは誰だっけ？ アレほどの時間が\n[01:37.090]消えて、見えなくなった まだ触れてるハズなのに\n[01:45.450]\n[01:45.840]麻酔をかけてよ 火照る内声(ないしょう)\n[01:52.790]\n[01:53.320]本当だって良いよ 戻れないの\n[01:58.200]アタシはまた怖くなる\n[02:01.570]モンブランは甘味\n[02:04.070]裸足のまま その甘さに溺れたいの\n[02:11.090]想天(そうだ)キミがいる 淘汰(とうた)消えていく\n[02:18.460]もうアタシは キミに伝えられない。\n[02:28.610]\n[02:40.960]「君が死ねばいいよ 今すぐに」\n[02:50.000]\n[02:51.540]本当だって良いと 思えないの\n[02:57.100]アタシはまだ弱い虫\n[03:00.540]コントラクト会議\n[03:03.260]アタシはまた キミの中に堕ちていく\n[03:08.490]本当だって良いと 思いながら\n[03:13.170]「嘘であって」と願うのは\n[03:16.600]弾き堕した結果\n[03:19.040]アタシがまだ 弱虫モンブランだったから\n[03:33.180]\n[03:40.150]君が入ってる 繰り返し果てる\n[03:49.160]それに応えよと アタシは喘ぐの\n",
            });
        }

        [TestMethod()]
        public void SerializeTest()
        {
            LynicSerialization lynicSerialization = new LynicSerialization("temp.dat");
            lynicSerialization.Serialize(lyricList);
            var result = lynicSerialization.Deserialize();
        }
    }
}