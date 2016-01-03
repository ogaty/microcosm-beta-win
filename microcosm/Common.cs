using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm
{
    public static class Common
    {
        const double TIMEZONE_JST = 9.0;
        const double TIMEZONE_GMT = 0.0;
        const string TIMEZONE_JST_STR = "JST(日本標準)";
        const string TIMEZONE_GMT_STR = "GMT(世界標準)";

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
        public static string getTimezoneText(string timezone)
        {
            switch (timezone)
            {
                case "JST":
                    return TIMEZONE_JST_STR;
                default:
                    break;
            }
            return TIMEZONE_GMT_STR;
        }

    }
}
