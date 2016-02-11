using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.Calc
{
    public enum AspectKind {
        CONJUNCTION = 1,
        OPPOSITION = 2,
        INCONJUNCT = 3,
        SESQUIQUADRATE = 4,
        TRINE = 5,
        SQUARE = 6,
        SEXTILE = 7
    };
    public class Aspect
    {
        public double target_position; // 絶対位置
        public AspectKind aspect_kind; // アスペクト種別
        public int soft_hard; // ソフトorハード
        public int target_no; // ターゲット番号
    }
}
