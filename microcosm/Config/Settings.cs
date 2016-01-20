using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.Config
{
    // ini保存させない一時的な設定を格納
    public class Settings
    {
        const int leftPanelWidth = 260;

        // 二重円、三重円切り替え
        public int bands { get; set; } = 1;

        // zodiac外側パディング
        public Point zodiacRingOuterPadding { get; set; }

        // 全体の円のサイズ
        public int zodiacRadius { get; set; } = 500;

        // zodiac幅
        public int zodiacRingWidth { get; set; } = 40;

        // zodiac内側パディング
        public Point zodiacRingInnerPadding { get; set; }

        // 中央リングパディング
        public Point innerRingPadding { get; set; }

        // 二重円パディング
        public Point secondRingPadding { get; set; }

        // 三重円パディング
        public Point thirdRingPadding { get; set; }

        public int natal_year { get; set; }
        public int natal_month { get; set; }
        public int natal_day { get; set; }
        public int natal_hour { get; set; }
        public int natal_minute { get; set; }
        public int natal_second { get; set; }
        public double natal_lat { get; set; }
        public double natal_lng { get; set; }
        public int transit_year { get; set; }
        public int transit_month { get; set; }
        public int transit_day { get; set; }
        public int transit_hour { get; set; }
        public int transit_minute { get; set; }
        public int transit_second { get; set; }
        public double transit_lat { get; set; }
        public double transit_lng { get; set; }

        public Settings()
        {
            zodiacRingOuterPadding = new Point(50, 50);
            zodiacRingInnerPadding = new Point(zodiacRingOuterPadding.X + zodiacRingWidth, zodiacRingOuterPadding.Y + zodiacRingWidth);
            secondRingPadding = new Point(120, 120);
            thirdRingPadding = new Point(150, 150);
            innerRingPadding = new Point(180, 180);
        }

        // zodiac外側直径
        public int calcZodiacOuterRadius()
        {
            return zodiacRadius;
        }

        // zodiac内側直径
        public int calcZodiacInnerRadius()
        {
            return zodiacRadius - zodiacRingWidth * 2;
        }

        // 二重円直径
        public int calcSecondInnerRadius()
        {
            return zodiacRadius - (secondRingPadding.Y - zodiacRingOuterPadding.Y) * 2;
        }

        // 三重円直径
        public int calcThirdInnerRadius()
        {
            return zodiacRadius - (thirdRingPadding.Y - zodiacRingOuterPadding.Y) * 2;
        }

        // 中央円直径
        public int calcInnerRadius()
        {
            return zodiacRadius - (innerRingPadding.Y - zodiacRingOuterPadding.Y) * 2;
        }
    }
}
