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
        // 逆行かどうか(マイナスなら逆行)
        public double speed;
        // 感受点はtrue
        public bool sensitive;
        // アスペクト対象リスト
        // リスト番号が設定される
        public List<Aspect> aspects;

        public PlanetData()
        {
            absolute_position = 0.0;
            speed = 0.0;
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
                    sensitive = false;
                    break;
                case Common.ZODIAC_MOON:
                    no = 1;
                    sensitive = false;
                    break;
                case Common.ZODIAC_MERCURY:
                    no = 2;
                    sensitive = false;
                    break;
                case Common.ZODIAC_VENUS:
                    no = 3;
                    sensitive = false;
                    break;
                case Common.ZODIAC_MARS:
                    no = 4;
                    sensitive = false;
                    break;
                case Common.ZODIAC_JUPITER:
                    no = 5;
                    sensitive = false;
                    break;
                case Common.ZODIAC_SATURN:
                    no = 6;
                    sensitive = false;
                    break;
                case Common.ZODIAC_URANUS:
                    no = 7;
                    sensitive = false;
                    break;
                case Common.ZODIAC_NEPTUNE:
                    no = 8;
                    sensitive = false;
                    break;
                case Common.ZODIAC_PLUTO:
                    no = 8;
                    sensitive = false;
                    break;
                case Common.ZODIAC_ASC:
                    no = 0;
                    sensitive = true;
                    break;
                case Common.ZODIAC_MC:
                    no = 1;
                    sensitive = true;
                    break;
                case Common.ZODIAC_DH:
                    no = 1;
                    sensitive = true;
                    break;
                case 10003:
                    no = 1;
                    sensitive = true;
                    break;


            }
        }

    }
}
