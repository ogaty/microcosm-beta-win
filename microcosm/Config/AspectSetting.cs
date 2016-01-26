using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.Config
{
    public class AspectSetting
    {
        public string dispname;
        public double orb_nn_sun_soft_1st = 8.0;
        public double orb_nn_sun_hard_1st = 4.0;
        public double orb_nn_moon_soft_1st = 8.0;
        public double orb_nn_moon_hard_1st = 4.0;
        public double orb_nn_other_soft_1st = 6.0;
        public double orb_nn_other_hard_1st = 3.0;
        public double orb_nn_sun_soft_2nd = 3.0;
        public double orb_nn_sun_hard_2nd = 1.5;
        public double orb_nn_moon_soft_2nd = 3.0;
        public double orb_nn_moon_hard_2nd = 1.5;
        public double orb_nn_other_soft_2nd = 2.0;
        public double orb_nn_other_hard_2nd = 1.0;
        public double orb_nn_sun_soft_150 = 3.0;
        public double orb_nn_sun_hard_150 = 2.0;
        public double orb_nn_moon_soft_150 = 3.0;
        public double orb_nn_moon_hard_150 = 2.0;
        public double orb_nn_other_soft_150 = 2.0;
        public double orb_nn_other_hard_150 = 1.0;


        public double orb_np_sun_soft_1st = 3.0;
        public double orb_np_sun_hard_1st = 2.0;
        public double orb_np_moon_soft_1st = 3.0;
        public double orb_np_moon_hard_1st = 2.0;
        public double orb_np_other_soft_1st = 2.0;
        public double orb_np_other_hard_1st = 1.0;
        public double orb_np_sun_soft_2nd = 2.0;
        public double orb_np_sun_hard_2nd = 1.0;
        public double orb_np_moon_soft_2nd = 2.0;
        public double orb_np_moon_hard_2nd = 1.0;
        public double orb_np_other_soft_2nd = 1.0;
        public double orb_np_other_hard_2nd = 0.5;
        public double orb_np_sun_soft_150 = 2.0;
        public double orb_np_sun_hard_150 = 1.0;
        public double orb_np_moon_soft_150 = 2.0;
        public double orb_np_moon_hard_150 = 1.0;
        public double orb_np_other_soft_150 = 1.0;
        public double orb_np_other_hard_150 = 0.5;

        public double orb_nt_sun_soft_1st = 3.0;
        public double orb_nt_sun_hard_1st = 2.0;
        public double orb_nt_moon_soft_1st = 3.0;
        public double orb_nt_moon_hard_1st = 2.0;
        public double orb_nt_other_soft_1st = 2.0;
        public double orb_nt_other_hard_1st = 1.0;
        public double orb_nt_sun_soft_2nd = 2.0;
        public double orb_nt_sun_hard_2nd = 1.0;
        public double orb_nt_moon_soft_2nd = 2.0;
        public double orb_nt_moon_hard_2nd = 1.0;
        public double orb_nt_other_soft_2nd = 1.0;
        public double orb_nt_other_hard_2nd = 0.5;
        public double orb_nt_sun_soft_150 = 2.0;
        public double orb_nt_sun_hard_150 = 1.0;
        public double orb_nt_moon_soft_150 = 2.0;
        public double orb_nt_moon_hard_150 = 1.0;
        public double orb_nt_other_soft_150 = 1.0;
        public double orb_nt_other_hard_150 = 0.5;

        public double orb_pp_sun_soft_1st = 8.0;
        public double orb_pp_sun_hard_1st = 4.0;
        public double orb_pp_moon_soft_1st = 8.0;
        public double orb_pp_moon_hard_1st = 4.0;
        public double orb_pp_other_soft_1st = 6.0;
        public double orb_pp_other_hard_1st = 3.0;
        public double orb_pp_sun_soft_2nd = 3.0;
        public double orb_pp_sun_hard_2nd = 1.5;
        public double orb_pp_moon_soft_2nd = 3.0;
        public double orb_pp_moon_hard_2nd = 1.5;
        public double orb_pp_other_soft_2nd = 2.0;
        public double orb_pp_other_hard_2nd = 1.0;
        public double orb_pp_sun_soft_3rd = 2.0;
        public double orb_pp_sun_hard_3rd = 1.0;
        public double orb_pp_moon_soft_3rd = 2.0;
        public double orb_pp_moon_hard_3rd = 1.0;
        public double orb_pp_other_soft_3rd = 2.0;
        public double orb_pp_other_hard_3rd = 1.0;
        public double orb_pp_sun_soft_150 = 3.0;
        public double orb_pp_sun_hard_150 = 2.0;
        public double orb_pp_moon_soft_150 = 3.0;
        public double orb_pp_moon_hard_150 = 2.0;
        public double orb_pp_other_soft_150 = 2.0;
        public double orb_pp_other_hard_150 = 1.0;

        public double orb_pt_sun_soft_1st = 3.0;
        public double orb_pt_sun_hard_1st = 2.0;
        public double orb_pt_moon_soft_1st = 3.0;
        public double orb_pt_moon_hard_1st = 2.0;
        public double orb_pt_other_soft_1st = 2.0;
        public double orb_pt_other_hard_1st = 1.0;
        public double orb_pt_sun_soft_2nd = 2.0;
        public double orb_pt_sun_hard_2nd = 1.0;
        public double orb_pt_moon_soft_2nd = 2.0;
        public double orb_pt_moon_hard_2nd = 1.0;
        public double orb_pt_other_soft_2nd = 1.0;
        public double orb_pt_other_hard_2nd = 0.5;
        public double orb_pt_sun_soft_3rd = 2.0;
        public double orb_pt_sun_hard_3rd = 1.0;
        public double orb_pt_moon_soft_3rd = 2.0;
        public double orb_pt_moon_hard_3rd = 1.0;
        public double orb_pt_other_soft_3rd = 1.0;
        public double orb_pt_other_hard_3rd = 0.5;
        public double orb_pt_sun_soft_150 = 2.0;
        public double orb_pt_sun_hard_150 = 1.0;
        public double orb_pt_moon_soft_150 = 2.0;
        public double orb_pt_moon_hard_150 = 1.0;
        public double orb_pt_other_soft_150 = 1.0;
        public double orb_pt_other_hard_150 = 0.5;

        public double orb_tt_sun_soft_1st = 8.0;
        public double orb_tt_sun_hard_1st = 4.0;
        public double orb_tt_moon_soft_1st = 8.0;
        public double orb_tt_moon_hard_1st = 4.0;
        public double orb_tt_other_soft_1st = 6.0;
        public double orb_tt_other_hard_1st = 3.0;
        public double orb_tt_sun_soft_2nd = 3.0;
        public double orb_tt_sun_hard_2nd = 1.5;
        public double orb_tt_moon_soft_2nd = 3.0;
        public double orb_tt_moon_hard_2nd = 1.5;
        public double orb_tt_other_soft_2nd = 2.0;
        public double orb_tt_other_hard_2nd = 1.0;
        public double orb_tt_sun_soft_3rd = 2.0;
        public double orb_tt_sun_hard_3rd = 1.0;
        public double orb_tt_moon_soft_3rd = 2.0;
        public double orb_tt_moon_hard_3rd = 1.0;
        public double orb_tt_other_soft_3rd = 2.0;
        public double orb_tt_other_hard_3rd = 1.0;
        public double orb_tt_sun_soft_150 = 3.0;
        public double orb_tt_sun_hard_150 = 2.0;
        public double orb_tt_moon_soft_150 = 3.0;
        public double orb_tt_moon_hard_150 = 2.0;
        public double orb_tt_other_soft_150 = 2.0;
        public double orb_tt_other_hard_150 = 1.0;


        public bool n_n = true;
        public bool p_p = false;
        public bool t_t = false;
        public bool n_p = false;
        public bool n_t = false;
        public bool p_t = false;

    }
}
