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
    public class Rains : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            Rain(
/* StartTime */                 228125,
/* StartRainFadeInStart */      228125,
/* StartRainFadeInEnd */        231125,
/* FinishRainFadeOutStart */    251375,
/* EndTime */                   252125,
/* RainOpacity */               .5f,
/* RainCount */                 150,
// /* LoopCount */                 50,
/* PositionXMin */              -300,
/* PositionXMax */              400,
/* ScaleXMin */                 1,
/* ScaleXMax */                 3,
/* ScaleYMin */                 50,
/* ScaleYMax */                 250,
/* MinDuration */               100,
/* MaxDuration */               500,
// /* Hue */                       0,
// /* Saturation */                0,
// /* Brightness */                100,
/* Additive */                  false,
/* LayerName */                 "rain"
            );
        }

        public void Rain(
            int StartTime, // start time 
            int StartRainFadeInStart, // start fade begin
            int StartRainFadeInEnd, // start fade end

            int FinishRainFadeOutStart, // end fade begin
            int EndTime, // end time 

            float RainOpacity, // opacity for rain sprites

            int RainCount, // rain amount
            // int LoopCount, // intensity

            // randomness
            double PositionXMin,
            double PositionXMax,

            double ScaleXMin,
            double ScaleXMax,
            double ScaleYMin,
            double ScaleYMax,

            // falling speed
            int MinDuration,
            int MaxDuration,

            // color
            // double Hue,
            // int Saturation,
            // int Brightness,

            // additive
            bool Additive,

            string LayerName
        )
        {
            for (var i = 0; i < RainCount; i++)
            {
                // function general settings
                string SpritePath = "sb/sprites/pixel.png";
                var Sprite = GetLayer(LayerName).CreateSprite(SpritePath, OsbOrigin.Centre);

                // fixed variable values
                int Offset = 0;
                double ScaleX = .1;
                double ScaleY = .1;
                // double SaturationConv = Saturation / 100;
                // double BrightnessConv = Brightness / 100;

                // move speed
                double RainDuration = Random(MinDuration, MaxDuration);

                // sprite positioning
                double StartPostionX = Random(-107 - PositionXMax, 747 + PositionXMax);
                double StartPositionY = 0 - ScaleYMax * 2;
                double EndPositionX = Random(StartPostionX - PositionXMin, StartPostionX + PositionXMax); // randomize the ending position of x
                double EndPositionY = 480 + ScaleYMax * 2;

                // angle measurements
                double DeltaX = EndPositionX - StartPostionX; // diff in x
                double DeltaY = EndPositionY - StartPositionY; // diff in y
                double RotationRad = Math.Atan2(DeltaY, DeltaX); // delta result in radians

                // start loop
                var loopStartTime = Random(StartTime, (EndTime - MaxDuration));
                var loopCount = (int)Math.Ceiling((EndTime - loopStartTime) / RainDuration);
                Sprite.StartLoopGroup(loopStartTime, loopCount);

                // start loop (if constant rain)
                // Sprite.StartLoopGroup(StartTime, LoopCount);

                // sprite manipulation
                Sprite.MoveX(Offset, RainDuration, StartPostionX, EndPositionX); // position of rain for X axis
                Sprite.MoveY(Offset, RainDuration, StartPositionY, EndPositionY); // position of rain for Y axis
                Sprite.ScaleVec(Offset, Random(ScaleX * ScaleXMin, ScaleX * ScaleXMax), Random(ScaleY * ScaleYMin, ScaleY * ScaleYMax)); // rain scale
                // Sprite.ColorHsb(Offset, Hue, SaturationConv, BrightnessConv); // rain color
                Sprite.Rotate(Offset, RotationRad + Math.PI / 2); // rain angle
                if (Additive) // additive switch
                {
                    Sprite.Additive(Offset, RainDuration);
                }

                // end loop
                Sprite.EndGroup();

                // global fade
                Sprite.Fade(StartRainFadeInStart, StartRainFadeInEnd, 0, RainOpacity); // fade-in
                Sprite.Fade(FinishRainFadeOutStart, EndTime, RainOpacity, 0); // fade-out
            }
        }
    }
}