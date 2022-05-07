using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Backgrounds : StoryboardObjectGenerator
    {
        int frameFadeTime = 0;
        double ScaleMultiplier = .667;

        public override void Generate()
        {
            // BG_color_res(525, 293000, 0, 0, 0);

            BG_color(525, 28650, 0, 0, 0);

            BG_color_opac_2(28650, 28650, 0, 0, 1, 1, 1, 10);

            BG_scale(28625, 40625, "images/a-1.jpg", 1.1f);

            BG_color_tran(39875, 40625, 0, 0, 1);

            BG_scale(40625, 46625, "images/a-2.jpg", 1.05f);
            BG_scale(46625, 51875, "images/a-3.jpg", 1.05f);

            BG_color_tran(50375, 52625, 0, 0, 1);

            BG_scale(52625, 63875, "images/b-1.jpg", 1.1f);
            BG_scale(63875, 76625, "images/b-2.jpg", 1.1f);

            BG_color_opac(75125, 75875, 0, 0, 0, .5, 2);
            BG_color_opac_2(75875, 88250, 0, 0, 0, .7, 1, 1);

            BG_scale(75875, 89750, "images/b-3.jpg", 1.1f);

            BG_color_opac_2(88250, 89750, 0, 0, 0, 1, 2, 1);

            BG_scale(90000, 93125, "images/b-4.jpg", 1.05f);

            BG_color_opac_2(89750, 90000, 0, 0, 1, 1, 1, 3);

            BG_color_tran(91625, 93125, 0, 0, 1);

            BG_scale(93125, 98375, "images/c-1.jpg", 1.05f);
            BG_scale(98375, 104000, "images/c-2.jpg", 1.05f);
            BG_scale(104000, 107375, "images/c-3.jpg", 1.025f);
            BG_scale(107375, 111125, "images/c-4.jpg", 1.05f);
            BG_scale(111125, 114125, "images/c-5.jpg", 1.025f);

            BG_color_opac_2(111125, 114125, 0, 0, 0, .5, 1, 3);
            BG_color_opac_2(114125, 114500, 0, 0, 1, 1, 2, 3);

            BG_color(114125, 125937, 168, .02, .95);

            BG_framed(114125, 115626, "images/small/a-1.jpg", 200, 240);
            BG_framed(115625, 117126, "images/small/a-2.jpg", 200, 240);
            BG_framed(117125, 118626, "images/small/a-3.jpg", 200, 240);
            BG_framed(118625, 120126, "images/small/a-4.jpg", 200, 240);
            BG_framed(120125, 121626, "images/small/a-5.jpg", 200, 240);
            BG_framed(121625, 123126, "images/small/a-6.jpg", 200, 240);
            BG_framed(123125, 123876, "images/small/a-7.jpg", 200, 240);
            BG_framed(123875, 124626, "images/small/a-8.jpg", 200, 240);
            BG_framed(124625, 125376, "images/small/a-9.jpg", 200, 240);
            BG_framed(125375, 125750, "images/small/a-10.jpg", 200, 240);

            BG_color_opac_2(125937, 126125, 0, 0, 1, 1, 1, 3);

            BG_scale(126125, 137375, "images/d-1.jpg", 1.1f);
            BG_scale(137375, 150125, "images/d-2.jpg", 1.1f);

            BG_color_opac(148625, 150125, 0, 0, 0, .5, 0);

            BG_scale(149000, 153125, "images/d-3.jpg", 1.05f);

            BG_color_opac_2(150125, 153125, 0, 0, 0, .5, 0, 1);
            BG_color_opac_2(153125, 153500, 0, 0, 1, 1, 2, 3);

            BG_color(153125, 179750, 168, .02, .95);

            BG_framed(153125, 155001, "images/small/b-1.jpg", 440, 240);
            BG_framed(155000, 156126, "images/small/b-2.jpg", 440, 240);
            BG_framed(156125, 158001, "images/small/b-3.jpg", 440, 240);
            BG_framed(158000, 159126, "images/small/b-4.jpg", 440, 240);
            BG_framed(159125, 161001, "images/small/b-5.jpg", 440, 240);
            BG_framed(161000, 162126, "images/small/b-6.jpg", 440, 240);
            BG_framed(162125, 164001, "images/small/b-7.jpg", 440, 240);
            BG_framed(164000, 165126, "images/small/b-8.jpg", 440, 240);
            BG_framed(165125, 167001, "images/small/b-9.jpg", 440, 240);
            BG_framed(167000, 168126, "images/small/b-10.jpg", 440, 240);
            BG_framed(168125, 170000, "images/small/b-11.jpg", 440, 240);
            BG_framed(170000, 171126, "images/small/b-12.jpg", 440, 240);
            BG_framed(171125, 173000, "images/small/b-13.jpg", 440, 240);
            BG_framed(173000, 174125, "images/small/b-14.jpg", 440, 240);
            BG_framed(174125, 175625, "images/small/b-15.jpg", 440, 240);
            BG_framed(175625, 177125, "images/small/b-16.jpg", 440, 240);
            BG_framed(177125, 179750, "images/small/b-17.jpg", 440, 240);

            BG_scale(179750, 182000, "images/d-4.jpg", 1.05f);

            BG_color_opac_2(179750, 179750, 0, 0, 1, 1, 1.5, 3);
            BG_color_opac_2(182000, 207125, 0, 0, 0, 1, 2, 1);

            frameFadeTime = 250;
            ScaleMultiplier = .75;
            BG_framed_2(183125, 184625, "images/large/1.jpg", 320, 240);
            BG_framed_2(184625, 186125, "images/large/2.jpg", 320, 240);
            BG_framed_2(186125, 187625, "images/large/3.jpg", 320, 240);
            BG_framed_2(187625, 189125, "images/large/4.jpg", 320, 240);
            BG_framed_2(189125, 190625, "images/large/5.jpg", 320, 240);
            BG_framed_2(190625, 192125, "images/large/6.jpg", 320, 240);
            BG_framed_2(192125, 193625, "images/large/7.jpg", 320, 240);
            BG_framed_2(193625, 195125, "images/large/8.jpg", 320, 240);
            BG_framed_2(195125, 196625, "images/large/9.jpg", 320, 240);
            BG_framed_2(196625, 198125, "images/large/10.jpg", 320, 240);
            BG_framed_2(198125, 199625, "images/large/11.jpg", 320, 240);
            BG_framed_2(199625, 201125, "images/large/12.jpg", 320, 240);
            BG_framed_2(201125, 202625, "images/large/13.jpg", 320, 240);
            BG_framed_2(202625, 204125, "images/large/14.jpg", 320, 240);
            BG_framed_2(204125, 205250, "images/large/15.jpg", 320, 240);

            BG_scale(207125, 210125, "images/e-1.jpg", 1.025f);
            BG_scale(210125, 213125, "images/e-2.jpg", 1.025f);
            BG_scale(213125, 216125, "images/e-3.jpg", 1.025f);
            BG_scale(216125, 219125, "images/e-4.jpg", 1.025f);
            BG_scale(219125, 222125, "images/e-5.jpg", 1.025f);
            BG_scale(222125, 225125, "images/e-6.jpg", 1.025f);
            BG_scale(225125, 228125, "images/e-7.jpg", 1.025f);
            BG_scale_sp(228125, 228875, "images/e-8.jpg", 1f);
            BG_scale_sp(228875, 229625, "images/e-9.jpg", 1f);
            BG_scale_sp(229625, 230375, "images/e-10.jpg", 1f);
            BG_scale_sp(230375, 230750, "images/e-11.jpg", 1f);

            BG_color_opac_2(231125, 231125, 0, 0, 0, 1, 2, 1);

            BG_scale(231312, 232625, "images/f-1.jpg", 1.0125f);
            BG_scale(232625, 234125, "images/f-2.jpg", 1.0125f);
            BG_scale(234125, 235625, "images/f-3.jpg", 1.0125f);
            BG_scale(235625, 237125, "images/f-4.jpg", 1.0125f);
            BG_scale(237125, 238625, "images/f-5.jpg", 1.0125f);
            BG_scale(238625, 240125, "images/f-6.jpg", 1.0125f);
            BG_scale(240125, 241625, "images/f-7.jpg", 1.0125f);
            BG_scale_sp(241625, 243125, "images/f-8.jpg", 1.0125f);
            BG_scale(243125, 244625, "images/f-9.jpg", 1.0125f);
            BG_scale_sp(244625, 246125, "images/f-10.jpg", 1.0125f);
            BG_scale(246125, 247625, "images/f-11.jpg", 1.0125f);
            BG_scale(247625, 249125, "images/f-12.jpg", 1.0125f);
            BG_scale(249125, 251750, "images/f-13.jpg", 1.0125f);

            BG_color_opac_2(249125, 252125, 0, 0, 0, .5, 1, 3);
            BG_color_opac_2(252125, 252125, 0, 0, 1, 1, 1, 10);

            BG_scale(252125, 255125, "images/g-1.jpg", 1.025f);
            BG_scale(255125, 258125, "images/g-2.jpg", 1.025f);
            BG_scale(258125, 261125, "images/g-3.jpg", 1.025f);
            BG_scale(261125, 264125, "images/g-4.jpg", 1.025f);

            BG_color_tran(263375, 264125, 0, 0, 1);

            BG_scale(264125, 267125, "images/g-5.jpg", 1.025f);
            BG_scale(267125, 270125, "images/g-6.jpg", 1.025f);
            BG_scale(270125, 273125, "images/g-7.jpg", 1.025f);
            BG_scale(273125, 276125, "images/a-1.jpg", 1.025f);

            BG_color_tran(275375, 276125, 0, 0, 1);

            BG_scale(276125, 282125, "images/h-1.jpg", 1.05f);
            BG_scale(282125, 287375, "images/h-2.jpg", 1.025f);
            BG_scale(287375, 288875, "images/h-3.jpg", 1.00675f);

            BG_color_opac_2(288875, 293000, 0, 0, 0, 1, 1, 0);

            Sprite_scale(288875, 293000, "paw.png", .125, .75f, 395, 260);
        }

        public void BG(int StartTime, int EndTime, string spritePath)
        {
            string SpritePath = "sb/sprites/" + spritePath;
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            int FadeTime = 250;
            var fullScreen = 480.0f / bitmap.Height;

            sprite.Fade(OsbEasing.InCubic, StartTime - FadeTime, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTime, Opacity, 0);

            sprite.Scale(StartTime, fullScreen);
        }

        public void BG_framed(int StartTime, int EndTime, string spritePath, int PosX, int PosY)
        {
            string SpritePath = "sb/sprites/" + spritePath;
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            var fullScreen = 480.0f / bitmap.Height;

            sprite.Move(StartTime, PosX, PosY);
            sprite.Fade(StartTime - frameFadeTime, StartTime, 0, 1);
            sprite.Fade(EndTime, EndTime + frameFadeTime, 1, 0);

            sprite.Scale(StartTime, fullScreen * ScaleMultiplier);
        }

        public void BG_framed_2(int StartTime, int EndTime, string spritePath, int PosX, int PosY)
        {
            string SpritePath = "sb/sprites/" + spritePath;
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            var fullScreen = 480.0f / bitmap.Height;

            sprite.Move(StartTime, PosX, PosY);
            sprite.Fade(StartTime - frameFadeTime, StartTime, 0, 1);
            sprite.Fade(EndTime, EndTime + frameFadeTime, 1, 0);

            sprite.Scale(StartTime, fullScreen * ScaleMultiplier);
        }

        public void BG_scale(int StartTime, int EndTime, string spritePath, float scaleValue)
        {
            string SpritePath = "sb/sprites/" + spritePath;
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            double FadeTime = 250;
            var fullScreen = 480.0f / bitmap.Height;

            sprite.Fade(OsbEasing.InCubic, StartTime - FadeTime, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTime * 2, Opacity, 0);

            sprite.Scale(StartTime, EndTime, fullScreen * scaleValue, fullScreen);
        }

        public void BG_scale_sp(int StartTime, int EndTime, string spritePath, float scaleValue)
        {
            string SpritePath = "sb/sprites/" + spritePath;
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            double FadeTime = 250;
            var fullScreen = 480.0f / bitmap.Height;

            sprite.Fade(OsbEasing.InCubic, StartTime - FadeTime, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTime * 2, Opacity, 0);

            sprite.Scale(StartTime, EndTime, fullScreen * scaleValue, fullScreen);
        }

        public void BG_color(int StartTime, int EndTime, int H, double S, double B)
        {
            string SpritePath = "sb/sprites/pixel.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            int FadeTime = 250;
            sprite.ColorHsb(StartTime, H, S, B);

            sprite.Fade(OsbEasing.InCubic, StartTime - FadeTime, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTime, Opacity, 0);

            sprite.Scale(StartTime, 854.0f / bitmap.Height);
        }

        public void BG_color_opac(int StartTime, int EndTime, int H, double S, double B, double Opacity, double fadeTimeMultiplier)
        {
            string SpritePath = "sb/sprites/pixel.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double FadeTime = 250 * fadeTimeMultiplier;
            sprite.ColorHsb(StartTime, H, S, B);

            sprite.Fade(OsbEasing.InCubic, StartTime - FadeTime, EndTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTime, Opacity, 0);

            sprite.Scale(StartTime, 854.0f / bitmap.Height);
        }

        public void BG_color_opac_2(int StartTime, int EndTime, int H, double S, double B, double Opacity, double fadeTimeMultiplierStart, double fadeTimeMultiplierEnd)
        {
            string SpritePath = "sb/sprites/pixel.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double FadeTimeStart = 250 * fadeTimeMultiplierStart;
            double FadeTimeEnd = 250 * fadeTimeMultiplierEnd;
            sprite.ColorHsb(StartTime, H, S, B);

            sprite.Fade(OsbEasing.OutCubic, StartTime - FadeTimeStart, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTimeEnd, Opacity, 0);

            sprite.Scale(StartTime, 854.0f / bitmap.Height);
        }

        public void BG_color_res(int StartTime, int EndTime, int H, int S, int B)
        {
            string SpritePath = "sb/sprites/pixel.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            sprite.ColorHsb(StartTime, H, S, B);

            sprite.Fade(StartTime, Opacity);
            sprite.Fade(EndTime, 0);

            sprite.Scale(StartTime, 880.0f / bitmap.Height);
        }

        public void BG_color_sp(int StartTime, int EndTime, int H, int S, int B, double Opacity)
        {
            string SpritePath = "sb/sprites/pixel.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            int FadeTime = 250;

            sprite.Fade(OsbEasing.InCubic, StartTime - FadeTime, StartTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, StartTime, EndTime, Opacity, 0);

            sprite.Scale(StartTime, 854.0f / bitmap.Height);
        }

        public void BG_color_tran(int StartTime, int EndTime, int H, int S, int B)
        {
            string SpritePath = "sb/sprites/pixel.png";
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            int FadeTime = 250;

            sprite.Fade(OsbEasing.InCubic, StartTime, EndTime - FadeTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime, EndTime + FadeTime * 4, Opacity, 0);

            sprite.Scale(StartTime, 854.0f / bitmap.Height);
        }

        public void Sprite_scale(int StartTime, int EndTime, string spritePath, double initialScale, float scaleValue, int PosX, int PosY)
        {
            string SpritePath = "sb/sprites/" + spritePath;
            var sprite = GetLayer(System.Reflection.MethodBase.GetCurrentMethod().Name).CreateSprite(SpritePath, OsbOrigin.Centre);
            var bitmap = GetMapsetBitmap(SpritePath);

            double Opacity = 1;
            double FadeTime = 250 / 1.25;

            sprite.Move(StartTime, PosX, PosY);
            sprite.Fade(StartTime - FadeTime, StartTime + FadeTime, 0, Opacity);
            sprite.Fade(OsbEasing.OutCubic, EndTime - FadeTime, EndTime + FadeTime, Opacity, 0);

            sprite.Scale(StartTime, EndTime, initialScale * scaleValue, initialScale);
        }
    }
}