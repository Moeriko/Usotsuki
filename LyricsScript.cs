using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;

namespace StorybrewScripts
{
    public class LyricsScript : StoryboardObjectGenerator
    {
        [Configurable]
        public OsbOrigin LyricsOrigin = OsbOrigin.Centre;

        [Configurable]
        public string FontName = "Kozuka Gothic Pr6N EL";

        [Configurable]
        public string OutputPath = "sb/lyrics";

        [Configurable]
        public float LetterSpacing = 4f;

        [Configurable]
        public float LyricsFade = 0.8f;

        [Configurable]
        public int FontSize = 26;

        // [Configurable]
        // public float FontScale = 0.5f;

        [Configurable]
        public FontStyle FontStyle = FontStyle.Regular;

        [Configurable]
        public int GlowRadius = 0;

        [Configurable]
        public Color4 GlowColor = new Color4(255, 255, 255, 255);

        [Configurable]
        public bool AdditiveGlow = true;

        [Configurable]
        public int OutlineThickness = 0;

        [Configurable]
        public Color4 OutlineColor = new Color4(50, 50, 50, 200);

        [Configurable]
        public int ShadowThickness = 4;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 200);

        [Configurable]
        public Vector2 Padding = Vector2.Zero;

        [Configurable]
        public bool TrimTransparency = true;

        [Configurable]
        public bool EffectsOnly = false;

        [Configurable]
        public bool Debug = false;

        [Configurable]
        public bool Additive = false;

        [Configurable]
        public bool RandomLyricsColor = false;

        [Configurable]
        public Color4 Color1 = new Color4(255, 255, 255, 255);

        [Configurable]
        public Color4 Color2 = new Color4(40, 150, 200, 255);

        [Configurable]
        public Color4 Color3 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color4 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color5 = new Color4(100, 100, 100, 255);

        [Configurable]
        public Color4 Color6 = new Color4(100, 100, 100, 255);

        public override void Generate()
        {
            // these variables are for how the lyrics looks
            var font = LoadFont(OutputPath, new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = Color4.White,
                Padding = Padding,
                FontStyle = FontStyle,
                TrimTransparency = TrimTransparency,
                EffectsOnly = EffectsOnly,
                Debug = Debug,
            },
            new FontGlow()
            {
                Radius = AdditiveGlow ? 0 : GlowRadius,
                Color = GlowColor,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });

            // this is where you generate the lyrics
            CreateLyrics(font, Color2, "雨　", FontName, FontSize, .5f, new Vector2(245, 200), 900, 2212);
            CreateLyrics(font, Color1, "　が", FontName, FontSize, .25f, new Vector2(245, 200), 1275, 3900);
            CreateLyrics(font, Color1, "降っ　", FontName, FontSize, .35f, new Vector2(320, 240), 1525, 2400);
            CreateLyrics(font, Color1, "　　た", FontName, FontSize, .35f, new Vector2(320, 240), 1900, 2400);

            CreateLyrics(font, Color3, "花　", FontName, FontSize, .5f, new Vector2(245, 200), 2400, 3712);
            CreateLyrics(font, Color1, "散っ　", FontName, FontSize, .35f, new Vector2(320, 240), 3025, 3900);
            CreateLyrics(font, Color1, "　　た", FontName, FontSize, .35f, new Vector2(320, 240), 3400, 3900);

            CreateLyrics(font, Color1, "た　", FontName, FontSize, .4f, new Vector2(190, 200), 3900, 5275);
            CreateLyrics(font, Color1, "　だ", FontName, FontSize, .4f, new Vector2(190, 200), 4150, 5275);
            CreateLyrics(font, Color1, "染　　　", FontName, FontSize, .35f, new Vector2(345, 240), 4275, 5275);
            CreateLyrics(font, Color1, "　まっ　", FontName, FontSize, .35f, new Vector2(345, 240), 4525, 5275);
            CreateLyrics(font, Color1, "　　　た", FontName, FontSize, .35f, new Vector2(345, 240), 4900, 5275);

            CreateLyrics(font, Color1, "頬　", FontName, FontSize, .5f, new Vector2(245, 200), 5275, 6775);
            CreateLyrics(font, Color1, "　を", FontName, FontSize, .25f, new Vector2(245, 200), 5775, 6775);
            CreateLyrics(font, Color1, "想っ　", FontName, FontSize, .35f, new Vector2(320, 240), 5900, 6775);
            CreateLyrics(font, Color1, "　　た", FontName, FontSize, .35f, new Vector2(320, 240), 6400, 6775);

            CreateLyrics(font, Color1, "僕　", FontName, FontSize, .5f, new Vector2(245, 200), 6900, 8400);
            CreateLyrics(font, Color1, "　は", FontName, FontSize, .25f, new Vector2(245, 200), 7275, 8400);
            CreateLyrics(font, Color1, "ずっ　", FontName, FontSize, .35f, new Vector2(320, 240), 7525, 8400);
            CreateLyrics(font, Color1, "　　と", FontName, FontSize, .35f, new Vector2(320, 240), 7900, 8400);

            CreateLyrics(font, Color1, "バ　　　　　　", FontName, FontSize, .25f, new Vector2(245, 200), 8775, 12525);
            CreateLyrics(font, Color1, "　ケ　　　　　", FontName, FontSize, .25f, new Vector2(245, 200), 9025, 12525);
            CreateLyrics(font, Color1, "　　ツ　　　　", FontName, FontSize, .25f, new Vector2(245, 200), 9400, 12525);
            CreateLyrics(font, Color1, "　　　いっ　　", FontName, FontSize, .25f, new Vector2(245, 200), 9525, 12525);
            CreateLyrics(font, Color1, "　　　　　ぱい", FontName, FontSize, .25f, new Vector2(245, 200), 9900, 12525);
            CreateLyrics(font, Color1, "の", FontName, FontSize, .25f, new Vector2(320, 240), 10275, 11400);
            CreateLyrics(font, Color1, "月　　　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 10525, 12525);
            CreateLyrics(font, Color1, "　光　　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 10900, 12525);
            CreateLyrics(font, Color1, "　　を　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 11025, 12525);
            CreateLyrics(font, Color1, "　　　飲ん　　", FontName, FontSize, .25f, new Vector2(320, 240), 11400, 12525);
            CreateLyrics(font, Color1, "　　　　　で　", FontName, FontSize, .25f, new Vector2(320, 240), 11775, 12525);
            CreateLyrics(font, Color1, "　　　　　　る", FontName, FontSize, .25f, new Vector2(320, 240), 12025, 12525);

            CreateLyrics(font, Color1, "本　", FontName, FontSize, .4f, new Vector2(190, 200), 12900, 14400);
            CreateLyrics(font, Color1, "　当", FontName, FontSize, .4f, new Vector2(190, 200), 13275, 14400);
            CreateLyrics(font, Color1, "なん　", FontName, FontSize, .35f, new Vector2(320, 240), 13525, 14400);
            CreateLyrics(font, Color1, "　　だ", FontName, FontSize, .35f, new Vector2(320, 240), 13900, 14400);

            CreateLyrics(font, Color1, "夜", FontName, FontSize, .5f, new Vector2(205, 200), 14400, 15900);
            CreateLyrics(font, Color1, "み　　　", FontName, FontSize, .35f, new Vector2(345, 240), 14775, 15900);
            CreateLyrics(font, Color1, "　たい　", FontName, FontSize, .35f, new Vector2(345, 240), 15025, 15900);
            CreateLyrics(font, Color1, "　　　で", FontName, FontSize, .35f, new Vector2(345, 240), 15400, 15900);

            CreateLyrics(font, Color1, "薄　　　", FontName, FontSize, .25f, new Vector2(280, 200), 15900, 18900);
            CreateLyrics(font, Color1, "　く　　", FontName, FontSize, .25f, new Vector2(280, 200), 16274, 18900);
            CreateLyrics(font, Color1, "　　透　", FontName, FontSize, .25f, new Vector2(280, 200), 16525, 18900);
            CreateLyrics(font, Color1, "　　　明", FontName, FontSize, .25f, new Vector2(280, 200), 16900, 18900);
            CreateLyrics(font, Color1, "な", FontName, FontSize, .25f, new Vector2(320, 240), 17275, 18900);
            CreateLyrics(font, Color1, "口　　　", FontName, FontSize, .25f, new Vector2(360, 280), 17400, 18900);
            CreateLyrics(font, Color1, "　触　　", FontName, FontSize, .25f, new Vector2(360, 280), 17775, 18900);
            CreateLyrics(font, Color1, "　　り　", FontName, FontSize, .25f, new Vector2(360, 280), 18150, 18900);
            CreateLyrics(font, Color1, "　　　で", FontName, FontSize, .25f, new Vector2(360, 280), 18400, 18900);

            CreateLyrics(font, Color1, "そう　　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 18900, 20400);
            CreateLyrics(font, Color1, "　　なん　　　", FontName, FontSize, .25f, new Vector2(320, 240), 19275, 20400);
            CreateLyrics(font, Color1, "　　　　だっ　", FontName, FontSize, .25f, new Vector2(320, 240), 19650, 20400);
            CreateLyrics(font, Color1, "　　　　　　て", FontName, FontSize, .25f, new Vector2(320, 240), 20025, 20400);

            CreateLyrics(font, Color1, "笑っ　　　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 20775, 23025);
            CreateLyrics(font, Color1, "　　て　　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 21525, 23025);
            CreateLyrics(font, Color1, "　　　も　　　　", FontName, FontSize, .25f, new Vector2(320, 240), 21775, 23025);
            CreateLyrics(font, Color1, "　　　　いい　　", FontName, FontSize, .25f, new Vector2(320, 240), 21900, 23025);
            CreateLyrics(font, Color1, "　　　　　　け　", FontName, FontSize, .25f, new Vector2(320, 240), 22275, 23025);
            CreateLyrics(font, Color1, "　　　　　　　ど", FontName, FontSize, .25f, new Vector2(320, 240), 22525, 23025);

            CreateLyrics(font, Color1, "僕　", FontName, FontSize, .25f, new Vector2(240, 170), 24525, 28625);
            CreateLyrics(font, Color1, "　は", FontName, FontSize, .25f, new Vector2(240, 170), 25275, 28625);
            CreateLyrics(font, Color1, "君　", FontName, FontSize, .25f, new Vector2(240, 205), 25650, 28625);
            CreateLyrics(font, Color1, "　を", FontName, FontSize, .25f, new Vector2(240, 205), 26400, 28625);
            CreateLyrics(font, Color1, "待っ　　　", FontName, FontSize, .35f, new Vector2(320, 240), 26775, 28625);
            CreateLyrics(font, Color1, "　　て　　", FontName, FontSize, .35f, new Vector2(320, 240), 27525, 28625);
            CreateLyrics(font, Color1, "　　　い　", FontName, FontSize, .35f, new Vector2(320, 240), 27900, 28625);
            CreateLyrics(font, Color1, "　　　　る", FontName, FontSize, .35f, new Vector2(320, 240), 28275, 28625);

            CreateLyrics_sp(font, Color1, "噓月", FontName, FontSize, .5f, new Vector2(320, 190), 28718, 30875, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "ヨルシカ", FontName, FontSize, .25f, new Vector2(320, 270), 28718, 30875, 1.025f, 0f);

            CreateLyrics_sp(font, Color1, "作詞・作曲・編曲", FontName, FontSize, .15f, new Vector2(320, 190), 31625, 33875, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "n-buna", FontName, FontSize, .35f, new Vector2(320, 210), 31625, 33875, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "ボーカル", FontName, FontSize, .15f, new Vector2(320, 270), 31625, 33875, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "suis", FontName, FontSize, .35f, new Vector2(320, 290), 31625, 33875, 1.025f, 0f);

            CreateLyrics_sp(font, Color1, "　泣　　　私　猫　　　　　", FontName, FontSize, .275f, new Vector2(320, 240), 34625, 36875, 1.1f, 0f);
            CreateLyrics_sp(font, Color1, "『　きたい　は　をかぶる』", FontName, FontSize, .275f, new Vector2(320, 240), 34625, 36875, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "エンドソング", FontName, FontSize, .2f, new Vector2(320, 290), 34625, 36875, 1.025f, 0f);

            CreateLyrics_sp(font, Color1, "譜面作製", FontName, FontSize, .2f, new Vector2(320, 235), 37625, 38750, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "ストーリボード", FontName, FontSize, .2f, new Vector2(320, 235), 38750, 40250, 1.025f, 0f);
            CreateLyrics_sp(font, Color1, "moecho", FontName, FontSize, .25f, new Vector2(320, 265), 37625, 40250, 1.025f, 0f);

            CreateLyrics(font, Color4, "夏が去った", FontName, FontSize, .25f, new Vector2(510, 245), 51875, 52625);
            CreateLyrics(font, Color1, "夏が去った", FontName, FontSize, .25f, new Vector2(510, 245), 52625, 54500);
            CreateLyrics(font, Color1, "街は静か", FontName, FontSize, .25f, new Vector2(527, 280), 53375, 54875);

            CreateLyrics(font, Color1, "僕はやっと", FontName, FontSize, .25f, new Vector2(510, 245), 54875, 57500);
            CreateLyrics(font, Color1, "部屋に戻って", FontName, FontSize, .25f, new Vector2(493, 280), 56375, 57875);

            CreateLyrics(font, Color1, "夜になった", FontName, FontSize, .25f, new Vector2(510, 245), 57875, 59375);
            CreateLyrics(font, Color1, "こんな宵月を", FontName, FontSize, .25f, new Vector2(493, 245), 59750, 63125);
            CreateLyrics(font, Color1, "一人で見ている", FontName, FontSize, .25f, new Vector2(475, 280), 61625, 63500);

            CreateLyrics(font, Color1, "本当なんだ", FontName, FontSize, .25f, new Vector2(135, 245), 63875, 66500);
            CreateLyrics(font, Color1, "昔の僕は", FontName, FontSize, .25f, new Vector2(117, 280), 65375, 66875);

            CreateLyrics(font, Color1, "涙が宝石で", FontName, FontSize, .25f, new Vector2(135, 245), 66875, 69125);
            CreateLyrics(font, Color1, "できてたんだ", FontName, FontSize, .25f, new Vector2(152, 280), 68375, 69500);

            CreateLyrics(font, Color1, "そうなんだって", FontName, FontSize, .25f, new Vector2(168, 280), 69875, 71375);
            CreateLyrics(font, Color1, "笑ってもいいけど", FontName, FontSize, .25f, new Vector2(187, 280), 71750, 74375);

            CreateLyrics(font, Color1, "声　　　", FontName, FontSize, .4f, new Vector2(265, 200), 75875, 78875);
            CreateLyrics(font, Color1, "　は　　", FontName, FontSize, .25f, new Vector2(245, 200), 76250, 78875);
            CreateLyrics(font, Color1, "　　もう", FontName, FontSize, .25f, new Vector2(245, 200), 76500, 78875);
            CreateLyrics(font, Color1, "とっ　　　　　", FontName, FontSize, .3f, new Vector2(357, 240), 77000, 78875);
            CreateLyrics(font, Color1, "　　く　　　　", FontName, FontSize, .3f, new Vector2(357, 240), 77375, 78875);
            CreateLyrics(font, Color1, "　　　に　　　", FontName, FontSize, .3f, new Vector2(357, 240), 77625, 78875);
            CreateLyrics(font, Color1, "　　　　忘　　", FontName, FontSize, .3f, new Vector2(357, 240), 77750, 78875);
            CreateLyrics(font, Color1, "　　　　　れ　", FontName, FontSize, .3f, new Vector2(357, 240), 78125, 78875);
            CreateLyrics(font, Color1, "　　　　　　た", FontName, FontSize, .3f, new Vector2(357, 240), 78375, 78875);

            CreateLyrics(font, Color1, "思　　　", FontName, FontSize, .4f, new Vector2(265, 200), 78875, 81875);
            CreateLyrics(font, Color1, "　い　　", FontName, FontSize, .25f, new Vector2(245, 200), 79250, 81875);
            CreateLyrics(font, Color1, "　　出　", FontName, FontSize, .25f, new Vector2(245, 200), 79500, 81875);
            CreateLyrics(font, Color1, "　　　も", FontName, FontSize, .25f, new Vector2(245, 200), 80000, 81875);
            CreateLyrics(font, Color6, "愛　　　　", FontName, FontSize, .3f, new Vector2(320, 240), 80375, 81875);
            CreateLyrics(font, Color1, "　も　　　", FontName, FontSize, .3f, new Vector2(320, 240), 80750, 81875);
            CreateLyrics(font, Color1, "　　死ん　", FontName, FontSize, .3f, new Vector2(320, 240), 81000, 81875);
            CreateLyrics(font, Color1, "　　　　だ", FontName, FontSize, .3f, new Vector2(320, 240), 81375, 81875);

            CreateLyrics(font, Color1, "風　　　", FontName, FontSize, .4f, new Vector2(265, 200), 81875, 84875);
            CreateLyrics(font, Color1, "　の　　", FontName, FontSize, .25f, new Vector2(245, 200), 82250, 84875);
            CreateLyrics(font, Color1, "　　ない", FontName, FontSize, .25f, new Vector2(245, 200), 82500, 84875);
            CreateLyrics(font, Color2, "海　　　　　", FontName, FontSize, .3f, new Vector2(340, 240), 83000, 84875);
            CreateLyrics(font, Color2, "　辺　　　　", FontName, FontSize, .3f, new Vector2(340, 240), 83375, 84875);
            CreateLyrics(font, Color1, "　　を　　　", FontName, FontSize, .3f, new Vector2(340, 240), 83625, 84875);
            CreateLyrics(font, Color1, "　　　歩　　", FontName, FontSize, .3f, new Vector2(340, 240), 83750, 84875);
            CreateLyrics(font, Color1, "　　　　い　", FontName, FontSize, .3f, new Vector2(340, 240), 84125, 84875);
            CreateLyrics(font, Color1, "　　　　　た", FontName, FontSize, .3f, new Vector2(340, 240), 84375, 84875);

            CreateLyrics(font, Color1, "あ　　　", FontName, FontSize, .3f, new Vector2(297, 240), 85250, 89750);
            CreateLyrics(font, Color1, "　の　　", FontName, FontSize, .3f, new Vector2(297, 240), 85500, 89750);
            CreateLyrics(font, Color1, "　　夏　", FontName, FontSize, .4f, new Vector2(297, 230), 87500, 88250);
            CreateLyrics(font, Color1, "　　　へ", FontName, FontSize, .3f, new Vector2(310, 240), 88250, 89750);

            CreateLyrics_sp(font, Color5, "　　夏　", FontName, FontSize, .4f, new Vector2(297, 230), 88250, 89750, 1.05f, 1f);

            CreateLyrics(font, Color4, "僕　", FontName, FontSize, .3f, new Vector2(320, 240), 92000, 93125);
            CreateLyrics(font, Color4, "　は", FontName, FontSize, .3f, new Vector2(320, 240), 92750, 93125);

            CreateLyrics(font, Color4, "僕はさ　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 93312, 98000);
            CreateLyrics(font, Color4, "　　　よ　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 93500, 98000);
            CreateLyrics(font, Color4, "　　　　な　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 93875, 98000);
            CreateLyrics(font, Color4, "　　　　　ら　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 94250, 98000);
            CreateLyrics(font, Color4, "　　　　　　が　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 95000, 98000);
            CreateLyrics(font, Color4, "　　　　　　　欲　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 95375, 98000);
            CreateLyrics(font, Color4, "　　　　　　　　しい　　", FontName, FontSize, .3f, new Vector2(320, 400), 95750, 98000);
            CreateLyrics(font, Color4, "　　　　　　　　　　ん　", FontName, FontSize, .3f, new Vector2(320, 400), 96875, 98000);
            CreateLyrics(font, Color4, "　　　　　　　　　　　だ", FontName, FontSize, .3f, new Vector2(320, 400), 97250, 98000);

            CreateLyrics(font, Color4, "た　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 98375, 103625);
            CreateLyrics(font, Color4, "　だ　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 98750, 103625);
            CreateLyrics(font, Color4, "　　微　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 99125, 103625);
            CreateLyrics(font, Color4, "　　　睡　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 99500, 103625);
            CreateLyrics(font, Color4, "　　　　む　　　", FontName, FontSize, .3f, new Vector2(320, 400), 100250, 103625);
            CreateLyrics(font, Color4, "　　　　　よう　", FontName, FontSize, .3f, new Vector2(320, 400), 101000, 103625);
            CreateLyrics(font, Color4, "　　　　　　　な", FontName, FontSize, .3f, new Vector2(320, 400), 101750, 103625);

            CreateLyrics(font, Color1, "も　　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 104000, 107375);
            CreateLyrics(font, Color1, "　の　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 104375, 107375);
            CreateLyrics(font, Color1, "　　一　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 104750, 107375);
            CreateLyrics(font, Color1, "　　　つ　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 106250, 107375);
            CreateLyrics(font, Color1, "　　　　さえ　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 106625, 107375);

            CreateLyrics(font, Color4, "も　　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107375, 110000);
            CreateLyrics(font, Color4, "　の　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107375, 110000);
            CreateLyrics(font, Color4, "　　一　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107375, 110000);
            CreateLyrics(font, Color4, "　　　つ　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107375, 110000);
            CreateLyrics(font, Color4, "　　　　さえ　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107375, 110000);

            CreateLyrics(font, Color4, "　　　　　　言　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107375, 110000);
            CreateLyrics(font, Color4, "　　　　　　　わ　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 107750, 110000);
            CreateLyrics(font, Color4, "　　　　　　　　ない　　", FontName, FontSize, .3f, new Vector2(320, 400), 108125, 110000);
            CreateLyrics(font, Color4, "　　　　　　　　　　ま　", FontName, FontSize, .3f, new Vector2(320, 400), 109250, 110000);
            CreateLyrics(font, Color4, "　　　　　　　　　　　ま", FontName, FontSize, .3f, new Vector2(320, 400), 109625, 110000);

            CreateLyrics(font, Color4, "僕　", FontName, FontSize, .3f, new Vector2(320, 400), 110000, 111125);
            CreateLyrics(font, Color4, "　は", FontName, FontSize, .3f, new Vector2(320, 400), 110750, 111125);

            CreateLyrics(font, Color1, "僕　", FontName, FontSize, .25f, new Vector2(240, 170), 111125, 114312);
            CreateLyrics(font, Color1, "　は", FontName, FontSize, .25f, new Vector2(240, 170), 111125, 114312);

            CreateLyrics(font, Color1, "君　", FontName, FontSize, .25f, new Vector2(240, 205), 111125, 114312);
            CreateLyrics(font, Color1, "　を", FontName, FontSize, .25f, new Vector2(240, 205), 111875, 114312);
            CreateLyrics(font, Color1, "待っ　　　", FontName, FontSize, .35f, new Vector2(320, 240), 112250, 114312);
            CreateLyrics(font, Color1, "　　て　　", FontName, FontSize, .35f, new Vector2(320, 240), 113000, 114312);
            CreateLyrics(font, Color1, "　　　い　", FontName, FontSize, .35f, new Vector2(320, 240), 113375, 114312);
            CreateLyrics(font, Color1, "　　　　る", FontName, FontSize, .35f, new Vector2(320, 240), 113750, 114312);

            CreateLyrics(font, Color4, "歳を　　　", FontName, FontSize, .25f, new Vector2(510, 245), 125375, 126125);
            CreateLyrics(font, Color1, "歳を取った", FontName, FontSize, .25f, new Vector2(510, 245), 126125, 128000);
            CreateLyrics(font, Color1, "一つ取った", FontName, FontSize, .25f, new Vector2(510, 280), 126875, 128375);

            CreateLyrics(font, Color1, "何も無い部屋で", FontName, FontSize, .25f, new Vector2(473, 245), 128375, 131000);
            CreateLyrics(font, Color1, "春になった", FontName, FontSize, .25f, new Vector2(510, 280), 129875, 131375);

            CreateLyrics(font, Color1, "僕は愛を", FontName, FontSize, .25f, new Vector2(527, 245), 131375, 134750);
            CreateLyrics(font, Color1, "底が抜けた", FontName, FontSize, .25f, new Vector2(510, 280), 133250, 135125);

            CreateLyrics(font, Color1, "柄酌で飲んでる", FontName, FontSize, .25f, new Vector2(473, 245), 135125, 137000);

            CreateLyrics(font, Color1, "本当なんだ", FontName, FontSize, .25f, new Vector2(135, 245), 137375, 140000);
            CreateLyrics(font, Color1, "味もしなくて", FontName, FontSize, .25f, new Vector2(152, 280), 138875, 140375);

            CreateLyrics(font, Color1, "飲めば飲むほど", FontName, FontSize, .25f, new Vector2(168, 245), 140375, 143000);
            CreateLyrics(font, Color1, "喉が渇いて", FontName, FontSize, .25f, new Vector2(135, 280), 141750, 143375);

            CreateLyrics(font, Color1, "そうなんだって", FontName, FontSize, .25f, new Vector2(168, 280), 143375, 144875);
            CreateLyrics(font, Color1, "笑ってもいいけど", FontName, FontSize, .25f, new Vector2(187, 280), 145250, 147500);

            CreateLyrics(font, Color1, "僕　", FontName, FontSize, .25f, new Vector2(240, 170), 149000, 153125);
            CreateLyrics(font, Color1, "　は", FontName, FontSize, .25f, new Vector2(240, 170), 149750, 153125);
            CreateLyrics(font, Color1, "夜　", FontName, FontSize, .25f, new Vector2(240, 205), 150125, 153125);
            CreateLyrics(font, Color1, "　を", FontName, FontSize, .25f, new Vector2(240, 205), 150875, 153125);
            CreateLyrics(font, Color1, "待っ　　　", FontName, FontSize, .35f, new Vector2(320, 240), 151250, 153125);
            CreateLyrics(font, Color1, "　　て　　", FontName, FontSize, .35f, new Vector2(320, 240), 152000, 153125);
            CreateLyrics(font, Color1, "　　　い　", FontName, FontSize, .35f, new Vector2(320, 240), 152375, 153125);
            CreateLyrics(font, Color1, "　　　　る", FontName, FontSize, .35f, new Vector2(320, 240), 152750, 153125);

            CreateLyrics(font, Color1, "君　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 182000, 188000);
            CreateLyrics(font, Color1, "　の　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 182750, 188000);
            CreateLyrics(font, Color1, "　　鼻　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 183125, 188000);
            CreateLyrics(font, Color1, "　　　歌　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 183875, 188000);
            CreateLyrics(font, Color1, "　　　　が　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 185000, 188000);
            CreateLyrics(font, Color1, "　　　　　欲　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 185375, 188000);
            CreateLyrics(font, Color1, "　　　　　　しい　　", FontName, FontSize, .3f, new Vector2(320, 400), 185750, 188000);
            CreateLyrics(font, Color1, "　　　　　　　　ん　", FontName, FontSize, .3f, new Vector2(320, 400), 186875, 188000);
            CreateLyrics(font, Color1, "　　　　　　　　　だ", FontName, FontSize, .3f, new Vector2(320, 400), 187250, 188000);

            CreateLyrics(font, Color1, "た　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 188375, 193625);
            CreateLyrics(font, Color1, "　だ　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 188750, 193625);
            CreateLyrics(font, Color1, "　　微　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 189125, 193625);
            CreateLyrics(font, Color1, "　　　睡　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 189500, 193625);
            CreateLyrics(font, Color1, "　　　　む　　　", FontName, FontSize, .3f, new Vector2(320, 400), 190250, 193625);
            CreateLyrics(font, Color1, "　　　　　よう　", FontName, FontSize, .3f, new Vector2(320, 400), 191000, 193625);
            CreateLyrics(font, Color1, "　　　　　　　な", FontName, FontSize, .3f, new Vector2(320, 400), 191750, 193625);

            CreateLyrics(font, Color1, "も　　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 194000, 200000);
            CreateLyrics(font, Color1, "　の　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 194375, 200000);
            CreateLyrics(font, Color1, "　　一　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 194750, 200000);
            CreateLyrics(font, Color1, "　　　つ　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 196250, 200000);
            CreateLyrics(font, Color1, "　　　　さえ　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 196625, 200000);
            CreateLyrics(font, Color1, "　　　　　　言　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 197375, 200000);
            CreateLyrics(font, Color1, "　　　　　　　わ　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 197750, 200000);
            CreateLyrics(font, Color1, "　　　　　　　　ない　　", FontName, FontSize, .3f, new Vector2(320, 400), 198125, 200000);
            CreateLyrics(font, Color1, "　　　　　　　　　　ま　", FontName, FontSize, .3f, new Vector2(320, 400), 199250, 200000);
            CreateLyrics(font, Color1, "　　　　　　　　　　　ま", FontName, FontSize, .3f, new Vector2(320, 400), 199625, 200000);

            CreateLyrics(font, Color1, "僕　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 200000, 205250);
            CreateLyrics(font, Color1, "　は　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 200750, 205250);
            CreateLyrics(font, Color1, "　　君　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 201125, 205250);
            CreateLyrics(font, Color1, "　　　を　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 201875, 205250);
            CreateLyrics(font, Color1, "　　　　待っ　　　", FontName, FontSize, .3f, new Vector2(320, 400), 202250, 205250);
            CreateLyrics(font, Color1, "　　　　　　て　　", FontName, FontSize, .3f, new Vector2(320, 400), 203000, 205250);
            CreateLyrics(font, Color1, "　　　　　　　い　", FontName, FontSize, .3f, new Vector2(320, 400), 203375, 205250);
            CreateLyrics(font, Color1, "　　　　　　　　る", FontName, FontSize, .3f, new Vector2(320, 400), 203750, 205250);

            CreateLyrics(font, Color1, "君　", FontName, FontSize, .3f, new Vector2(320, 240), 206000, 207125);
            CreateLyrics(font, Color1, "　の", FontName, FontSize, .3f, new Vector2(320, 240), 206750, 207125);

            CreateLyrics(font, Color1, "君の目　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 207312, 211625);
            CreateLyrics(font, Color1, "　　　を　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 207500, 211625);
            CreateLyrics(font, Color1, "　　　　覚え　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 207875, 211625);
            CreateLyrics(font, Color1, "　　　　　　て　　　", FontName, FontSize, .3f, new Vector2(320, 400), 209000, 211625);
            CreateLyrics(font, Color1, "　　　　　　　い　　", FontName, FontSize, .3f, new Vector2(320, 400), 209375, 211625);
            CreateLyrics(font, Color1, "　　　　　　　　ない", FontName, FontSize, .3f, new Vector2(320, 400), 209750, 211625);

            CreateLyrics(font, Color1, "君　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 212000, 217625);
            CreateLyrics(font, Color1, "　の　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 212750, 217625);
            CreateLyrics(font, Color1, "　　口　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 213125, 217625);
            CreateLyrics(font, Color1, "　　　を　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 213875, 217625);
            CreateLyrics(font, Color1, "　　　　描い　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 214250, 217625);
            CreateLyrics(font, Color1, "　　　　　　て　　　", FontName, FontSize, .3f, new Vector2(320, 400), 215000, 217625);
            CreateLyrics(font, Color1, "　　　　　　　い　　", FontName, FontSize, .3f, new Vector2(320, 400), 215375, 217625);
            CreateLyrics(font, Color1, "　　　　　　　　ない", FontName, FontSize, .3f, new Vector2(320, 400), 215750, 217625);

            CreateLyrics(font, Color1, "も　　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 218000, 224000);
            CreateLyrics(font, Color1, "　の　　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 218375, 224000);
            CreateLyrics(font, Color1, "　　一　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 218750, 224000);
            CreateLyrics(font, Color1, "　　　つ　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 220250, 224000);
            CreateLyrics(font, Color1, "　　　　さえ　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 220625, 224000);
            CreateLyrics(font, Color1, "　　　　　　言　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 221375, 224000);
            CreateLyrics(font, Color1, "　　　　　　　わ　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 221750, 224000);
            CreateLyrics(font, Color1, "　　　　　　　　ない　　", FontName, FontSize, .3f, new Vector2(320, 400), 222125, 224000);
            CreateLyrics(font, Color1, "　　　　　　　　　　ま　", FontName, FontSize, .3f, new Vector2(320, 400), 223250, 224000);
            CreateLyrics(font, Color1, "　　　　　　　　　　　ま", FontName, FontSize, .3f, new Vector2(320, 400), 223625, 224000);

            CreateLyrics(font, Color1, "僕　　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 224000, 229625);
            CreateLyrics(font, Color1, "　は　　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 224750, 229625);
            CreateLyrics(font, Color1, "　　君　　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 225125, 229625);
            CreateLyrics(font, Color1, "　　　を　　　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 225875, 229625);
            CreateLyrics(font, Color1, "　　　　待っ　　　　", FontName, FontSize, .3f, new Vector2(320, 400), 226250, 229625);
            CreateLyrics(font, Color1, "　　　　　　て　　　", FontName, FontSize, .3f, new Vector2(320, 400), 227000, 229625);
            CreateLyrics(font, Color1, "　　　　　　　い　　", FontName, FontSize, .3f, new Vector2(320, 400), 227375, 229625);
            CreateLyrics(font, Color1, "　　　　　　　　ない", FontName, FontSize, .3f, new Vector2(320, 400), 227750, 229625);

            CreateLyrics(font, Color1, "君　", FontName, FontSize, .3f, new Vector2(320, 400), 230000, 231125);
            CreateLyrics(font, Color1, "　の", FontName, FontSize, .3f, new Vector2(320, 400), 230750, 231125);

            CreateLyrics(font, Color1, "君　", FontName, FontSize, .4f, new Vector2(225, 140), 231312, 235625);
            CreateLyrics(font, Color1, "　の", FontName, FontSize, .25f, new Vector2(225, 160), 231312, 235625);
            CreateLyrics(font, Color1, "鼻　", FontName, FontSize, .4f, new Vector2(225, 203), 231312, 235625);
            CreateLyrics(font, Color1, "　を", FontName, FontSize, .25f, new Vector2(225, 200), 231875, 235625);
            CreateLyrics(font, Color1, "知っ　　　　", FontName, FontSize, .35f, new Vector2(380, 240), 232250, 235625);
            CreateLyrics(font, Color1, "　　て　　　", FontName, FontSize, .35f, new Vector2(380, 240), 233000, 235625);
            CreateLyrics(font, Color1, "　　　い　　", FontName, FontSize, .35f, new Vector2(380, 240), 233375, 235625);
            CreateLyrics(font, Color1, "　　　　ない", FontName, FontSize, .35f, new Vector2(380, 240), 233750, 235625);

            CreateLyrics(font, Color1, "君　", FontName, FontSize, .4f, new Vector2(225, 140), 236000, 241625);
            CreateLyrics(font, Color1, "　の", FontName, FontSize, .25f, new Vector2(225, 160), 236750, 241625);
            CreateLyrics(font, Color1, "頬　", FontName, FontSize, .4f, new Vector2(225, 203), 237125, 241625);
            CreateLyrics(font, Color1, "　を", FontName, FontSize, .25f, new Vector2(225, 200), 237875, 241625);
            CreateLyrics(font, Color1, "想っ　　　　", FontName, FontSize, .35f, new Vector2(380, 240), 238062, 241625);
            CreateLyrics(font, Color1, "　　て　　　", FontName, FontSize, .35f, new Vector2(380, 240), 239000, 241625);
            CreateLyrics(font, Color1, "　　　い　　", FontName, FontSize, .35f, new Vector2(380, 240), 239375, 241625);
            CreateLyrics(font, Color1, "　　　　ない", FontName, FontSize, .35f, new Vector2(380, 240), 239750, 241625);

            CreateLyrics(font, Color4, "さ　　　", FontName, FontSize, .4f, new Vector2(220, 210), 242000, 248000);
            CreateLyrics(font, Color4, "　よ　　", FontName, FontSize, .4f, new Vector2(220, 210), 242375, 248000);
            CreateLyrics(font, Color4, "　　な　", FontName, FontSize, .4f, new Vector2(220, 210), 242750, 248000);

            CreateLyrics(font, Color1, "さ　　　", FontName, FontSize, .4f, new Vector2(220, 210), 243125, 248000);
            CreateLyrics(font, Color1, "　よ　　", FontName, FontSize, .4f, new Vector2(220, 210), 243125, 248000);
            CreateLyrics(font, Color1, "　　な　", FontName, FontSize, .4f, new Vector2(220, 210), 243125, 248000);
            CreateLyrics(font, Color1, "　　　ら", FontName, FontSize, .4f, new Vector2(220, 210), 243125, 248000);

            CreateLyrics(font, Color1, "す　", FontName, FontSize, .25f, new Vector2(370, 228), 244250, 248000);
            CreateLyrics(font, Color1, "　ら", FontName, FontSize, .25f, new Vector2(370, 228), 244625, 248000);

            CreateLyrics(font, Color1, "言　　　", FontName, FontSize, .4f, new Vector2(250, 270), 245375, 248000);
            CreateLyrics(font, Color1, "　わ　　", FontName, FontSize, .4f, new Vector2(250, 270), 245750, 248000);
            CreateLyrics(font, Color1, "　　ない", FontName, FontSize, .4f, new Vector2(250, 270), 246125, 248000);

            CreateLyrics(font, Color1, "ま　", FontName, FontSize, .25f, new Vector2(400, 288), 247250, 248000);
            CreateLyrics(font, Color1, "　ま", FontName, FontSize, .25f, new Vector2(400, 288), 247625, 248000);

            CreateLyrics(font, Color1, "君　", FontName, FontSize, .25f, new Vector2(240, 170), 248000, 252125);
            CreateLyrics(font, Color1, "　は", FontName, FontSize, .25f, new Vector2(240, 170), 248750, 252125);
            CreateLyrics(font, Color1, "夜　", FontName, FontSize, .25f, new Vector2(240, 205), 249125, 252125);
            CreateLyrics(font, Color1, "　に", FontName, FontSize, .25f, new Vector2(240, 205), 249875, 252125);
            CreateLyrics(font, Color1, "なっ　　　", FontName, FontSize, .35f, new Vector2(320, 240), 250250, 252125);
            CreateLyrics(font, Color1, "　　て　　", FontName, FontSize, .35f, new Vector2(320, 240), 251000, 252125);
            CreateLyrics(font, Color1, "　　　い　", FontName, FontSize, .35f, new Vector2(320, 240), 251375, 252125);
            CreateLyrics(font, Color1, "　　　　く", FontName, FontSize, .35f, new Vector2(320, 240), 251750, 252125);

            CreateLyrics(font, Color4, "本　", FontName, FontSize, .3f, new Vector2(225, 200), 263375, 264875);
            CreateLyrics(font, Color4, "　当", FontName, FontSize, .3f, new Vector2(225, 200), 263750, 264875);
            CreateLyrics(font, Color4, "なん　", FontName, FontSize, .2625f, new Vector2(320, 240), 264000, 264875);
            CreateLyrics(font, Color4, "　　だ", FontName, FontSize, .2625f, new Vector2(320, 240), 264375, 264875);

            CreateLyrics(font, Color4, "夜", FontName, FontSize, .375f, new Vector2(240, 200), 264875, 266375);
            CreateLyrics(font, Color4, "み　　　", FontName, FontSize, .2625f, new Vector2(345, 240), 265250, 266375);
            CreateLyrics(font, Color4, "　たい　", FontName, FontSize, .2625f, new Vector2(345, 240), 265500, 266375);
            CreateLyrics(font, Color4, "　　　で", FontName, FontSize, .2625f, new Vector2(345, 240), 265875, 266375);

            CreateLyrics(font, Color4, "薄　　　", FontName, FontSize, .1875f, new Vector2(290, 210), 266375, 269562);
            CreateLyrics(font, Color4, "　く　　", FontName, FontSize, .1875f, new Vector2(290, 210), 266750, 269562);
            CreateLyrics(font, Color4, "　　透　", FontName, FontSize, .1875f, new Vector2(290, 210), 267000, 269562);
            CreateLyrics(font, Color4, "　　　明", FontName, FontSize, .1875f, new Vector2(290, 210), 267375, 269562);
            CreateLyrics(font, Color4, "な", FontName, FontSize, .1875f, new Vector2(320, 240), 267750, 269562);
            CreateLyrics(font, Color4, "口　　　", FontName, FontSize, .1875f, new Vector2(350, 270), 267875, 269562);
            CreateLyrics(font, Color4, "　触　　", FontName, FontSize, .1875f, new Vector2(350, 270), 268250, 269562);
            CreateLyrics(font, Color4, "　　り　", FontName, FontSize, .1875f, new Vector2(350, 270), 268500, 269562);
            CreateLyrics(font, Color4, "　　　で", FontName, FontSize, .1875f, new Vector2(350, 270), 268875, 269562);

            CreateLyrics(font, Color1, "おわり", FontName, FontSize, .3f, new Vector2(320, 240), 288875, 293000);

        }

        // this is where you create the lyrics
        private void CreateLyrics(FontGenerator font, Color4 ColorType, string Sentence, string FontName, int FontSize, float FontScale, Vector2 position, int StartTime, int EndTime)
        {
            var LyricsLayer = GetLayer("Lyrics");
            var letterY = position.Y;
            var lineWidth = 0f;
            var lineHeight = 0f;
            var letterSpacing = LetterSpacing * FontScale;
            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * FontScale + letterSpacing;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
            }

            var letterX = position.X - lineWidth * 0.5f;

            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var FadeTime = 250 / 1.25;
                    var RandomRotate = Random(MathHelper.DegreesToRadians(-20), MathHelper.DegreesToRadians(20));
                    var letterPos = new Vector2(letterX, letterY)
                        + texture.OffsetFor(LyricsOrigin) * FontScale;

                    var sprite = LyricsLayer.CreateSprite(texture.Path, LyricsOrigin);

                    sprite.Move(StartTime, letterPos.X, letterPos.Y);
                    sprite.Fade(StartTime - FadeTime, StartTime + FadeTime, 0, LyricsFade);
                    sprite.Fade(OsbEasing.OutCubic, EndTime - FadeTime, EndTime + FadeTime, LyricsFade, 0);
                    sprite.Scale(StartTime, FontScale);

                    if (Additive)
                    {
                        sprite.Additive(StartTime, EndTime);
                    }

                    sprite.Color(StartTime, ColorType);
                }
                letterX += texture.BaseWidth * FontScale + letterSpacing;
            }
            letterY += lineHeight;
        }

        private void CreateLyrics_sp(FontGenerator font, Color4 ColorType, string Sentence, string FontName, int FontSize, float FontScale, Vector2 position, int StartTime, int EndTime, float EndScale, float StartTimeOpacity)
        {
            var LyricsLayer = GetLayer("Lyrics");
            var letterY = position.Y;
            var lineWidth = 0f;
            var lineHeight = 0f;
            var letterSpacing = LetterSpacing * FontScale;
            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * FontScale + letterSpacing;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
            }

            var letterX = position.X - lineWidth * 0.5f;

            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var FadeTime = 250;
                    var RandomRotate = Random(MathHelper.DegreesToRadians(-20), MathHelper.DegreesToRadians(20));
                    var letterPos = new Vector2(letterX, letterY)
                        + texture.OffsetFor(LyricsOrigin) * FontScale;

                    var sprite = LyricsLayer.CreateSprite(texture.Path, LyricsOrigin);

                    sprite.Move(StartTime, letterPos.X, letterPos.Y);
                    sprite.Fade(StartTime - FadeTime, StartTime + FadeTime, StartTimeOpacity, LyricsFade);
                    sprite.Fade(EndTime - FadeTime, EndTime + FadeTime, LyricsFade, 0);
                    sprite.Scale(StartTime, EndTime, FontScale, FontScale * EndScale);

                    if (Additive)
                    {
                        sprite.Additive(StartTime, EndTime);
                    }

                    sprite.Color(StartTime, ColorType);
                }
                letterX += texture.BaseWidth * FontScale + letterSpacing;
            }
            letterY += lineHeight;
        }
    }
}