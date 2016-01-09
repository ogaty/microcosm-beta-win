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

    }
}
