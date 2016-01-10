using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using microcosm;

namespace microcosm.Calc
{
    public class PlanetData
    {
        // swiss_epheと対応した惑星番号
        public int no;
        // 0.0～359.99、絶対値
        public double absolute_position;
        // 逆行かどうか
        public bool retrograde;
        // 天体の文字列、太陽、月、...
        public string text;
        // ☿とか♀とか
        public string symbol;
        // 感受点はtrue
        public bool sensitive;

        public PlanetData()
        {
            absolute_position = 0.0;
            retrograde = false;
            text = "";
            no = 0;
        }

        public PlanetData(int kind)
        {
            // todo font周り
            // unicodeでASC、MCが出てくればそっちへ移行
            // 最終的には自作したほうが早いかも
            switch (kind)
            {
                case Common.ZODIAC_SUN:
                    no = 0;
                    text = "太陽";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_SUN);
                    sensitive = false;
                    break;
                case Common.ZODIAC_MOON:
                    no = 1;
                    text = "月";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_MOON);
                    sensitive = false;
                    break;
                case Common.ZODIAC_MERCURY:
                    no = 2;
                    text = "水星";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_MERCURY);
                    sensitive = false;
                    break;
                case Common.ZODIAC_VENUS:
                    no = 3;
                    text = "金星";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_VENUS);
                    sensitive = false;
                    break;
                case Common.ZODIAC_MARS:
                    no = 4;
                    text = "火星";
                    symbol = "\u2642";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_MARS);
                    sensitive = false;
                    break;
                case Common.ZODIAC_JUPITER:
                    no = 5;
                    text = "木星";
                    symbol = "\u2643";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_JUPITER);
                    sensitive = false;
                    break;
                case Common.ZODIAC_SATURN:
                    no = 6;
                    text = "土星";
                    symbol = "\u2644";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_SATURN);
                    sensitive = false;
                    break;
                case Common.ZODIAC_URANUS:
                    no = 7;
                    text = "天王星";
                    symbol = "\u2645";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_URANUS);
                    sensitive = false;
                    break;
                case Common.ZODIAC_NEPTUNE:
                    no = 8;
                    text = "海王星";
                    symbol = "\u2646";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_NEPTUNE);
                    sensitive = false;
                    break;
                case Common.ZODIAC_PLUTO:
                    no = 8;
                    text = "冥王星";
                    symbol = "\u2647";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_PLUTO);
                    sensitive = false;
                    break;
                case Common.ZODIAC_ASC:
                    no = 0;
                    text = "ASC";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_ASC);
                    sensitive = true;
                    break;
                case Common.ZODIAC_MC:
                    no = 1;
                    text = "MC";
                    symbol = "L";
                    sensitive = true;
                    break;
                case Common.ZODIAC_DH:
                    no = 1;
                    text = "DH";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_DH);
                    sensitive = true;
                    break;
                case 10003:
                    no = 1;
                    text = "キロン";
                    symbol = Common.getPlanetSymbol(Common.ZODIAC_CHIRON);
                    sensitive = true;
                    break;


            }
        }

    }
}
