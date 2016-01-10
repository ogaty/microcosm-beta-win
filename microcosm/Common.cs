using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm
{
    public static class Common
    {
        // チャートウィンドウのパディング
        static public int chart_padding = 20;
        // 外側の長さ
        static public int chart_radius = 210;
        // 外周リング内側の長さ
        static public int chart_ring_radius = 180;
        // 二重円内側の長さ
        static public int chart_middle_ring_radius = 150;
        // 三重円内側の長さ
        static public int chart_tripple_ring_radius = 120;
        // 中央円の長さ
        static public int chart_center_radius = 90;
        // 
        static public int chart_signring_pos = 195;

        const double TIMEZONE_JST = 9.0;
        const double TIMEZONE_GMT = 0.0;

        public const int ZODIAC_SUN = 0;
        public const int ZODIAC_MOON = 1;
        public const int ZODIAC_MERCURY = 2;
        public const int ZODIAC_VENUS = 3;
        public const int ZODIAC_MARS = 4;
        public const int ZODIAC_JUPITER = 5;
        public const int ZODIAC_SATURN = 6;
        public const int ZODIAC_URANUS = 7;
        public const int ZODIAC_NEPTUNE = 8;
        public const int ZODIAC_PLUTO = 9;
        public const int ZODIAC_CHIRON = 15;
        public const int ZODIAC_ASC = 10000;
        public const int ZODIAC_MC = 10001;
        public const int ZODIAC_DH = 10002;

        public static double getTimezone(string timezone)
        {
            switch (timezone)
            {
                case "JST":
                    return TIMEZONE_JST;
                default:
                    break;
            }
            return TIMEZONE_GMT;
        }
        public static string getTimezoneLongText(string timezone)
        {
            switch (timezone)
            {
                case "JST":
                    return Properties.Resources.TIMEZONE_JST_STR_LONG;
                default:
                    break;
            }
            return Properties.Resources.TIMEZONE_GMT_STR_LONG;
        }
        public static string getTimezoneShortText(int index)
        {
            switch (index)
            {
                case 0:
                    return Properties.Resources.TIMEZONE_JST_STR_SHORT;
                default:
                    break;
            }
            return Properties.Resources.TIMEZONE_GMT_STR_SHORT;
        }

        public static string getPlanetSymbol(int number)
        {
            switch (number)
            {
                case ZODIAC_SUN:
                    // "\u2609";
                    return "A";
                case ZODIAC_MOON:
                    // "\u260d";
                    return "B";
                case ZODIAC_MERCURY:
                    // "\u263f";
                    return "C";
                case ZODIAC_VENUS:
                    // "\u2640";
                    return "D";
                case ZODIAC_MARS:
                    // "\u2641";
                    return "E";
                case ZODIAC_JUPITER:
                    // "\u2642";
                    return "F";
                case ZODIAC_SATURN:
                    // "\u2643";
                    return "G";
                case ZODIAC_URANUS:
                    // "\u2644";
                    return "H";
                case ZODIAC_NEPTUNE:
                    // "\u2645";
                    return "I";
                case ZODIAC_PLUTO:
                    // "\u2646";
                    // 外部フォントだと天文学用のPLUTOになっているのが困りどころ
                    return "J";
            }
            return "";
        }

        public static string getPlanetText(int number)
        {
            switch (number)
            {
                case ZODIAC_SUN:
                    return "太陽";
                case ZODIAC_MOON:
                    return "月";
                case ZODIAC_MERCURY:
                    return "水星";
                case ZODIAC_VENUS:
                    return "金星";
                case ZODIAC_MARS:
                    return "火星";
                case ZODIAC_JUPITER:
                    return "木星";
                case ZODIAC_SATURN:
                    return "土星";
                case ZODIAC_URANUS:
                    return "天王星";
                case ZODIAC_NEPTUNE:
                    return "海王星";
                case ZODIAC_PLUTO:
                    return "冥王星";
            }
            return "";
        }

        public static string getSensitiveSymbol(int number)
        {
            switch (number)
            {
                // UNICODEが無い！
                case ZODIAC_ASC:
                    return "K";
                // UNICODEが無い！
                case ZODIAC_MC:
                    return "L";
                // "\u260a"
                case ZODIAC_DH:
                    return "M";
            }
            return "";
        }

        public static string getSensitiveText(int number)
        {
            switch (number)
            {
                case ZODIAC_ASC:
                    return "ASC";
                case ZODIAC_MC:
                    return "MC";
                case ZODIAC_DH:
                    return "D.H.";
            }
            return "";
        }

    }
}
