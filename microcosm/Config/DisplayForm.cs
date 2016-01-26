﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace microcosm.Config
{
    public partial class DisplayForm : Form
    {
        public MainForm mainform;
        public AspectSetting[] aspectSettingList;
        public int index;

        public DisplayForm(MainForm mainform, AspectSetting[] aspectSettingList)
        {
            this.mainform = mainform;
            this.aspectSettingList = aspectSettingList;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            aspectSettingList.ToList().ForEach(aspectSetting => { settingList.Items.Add(aspectSetting.dispname); });

            setData(0);

            settingList.SetSelected(0, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIndex = settingList.SelectedIndex;
            if (newIndex == -1) return;
            SaveData();
            setData(newIndex);
            index = newIndex;
        }

        private void setData(int newIndex)
        {
            displayName.Text = aspectSettingList[newIndex].dispname;
            nnDisp.Checked = aspectSettingList[newIndex].n_n;
            npDisp.Checked = aspectSettingList[newIndex].n_p;
            ntDisp.Checked = aspectSettingList[newIndex].n_t;
            ppDisp.Checked = aspectSettingList[newIndex].p_p;
            ptDisp.Checked = aspectSettingList[newIndex].p_t;
            ttDisp.Checked = aspectSettingList[newIndex].t_t;

            // 多いよ・・・
            nnSunSoft1st.Text = aspectSettingList[newIndex].orb_nn_sun_soft_1st.ToString();
            nnSunHard1st.Text = aspectSettingList[newIndex].orb_nn_sun_hard_1st.ToString();
            nnMoonSoft1st.Text = aspectSettingList[newIndex].orb_nn_moon_soft_1st.ToString();
            nnMoonHard1st.Text = aspectSettingList[newIndex].orb_nn_moon_hard_1st.ToString();
            nnOtherSoft1st.Text = aspectSettingList[newIndex].orb_nn_other_soft_1st.ToString();
            nnOtherHard1st.Text = aspectSettingList[newIndex].orb_nn_other_hard_1st.ToString();
            nnSunSoft2nd.Text = aspectSettingList[newIndex].orb_nn_sun_soft_2nd.ToString();
            nnSunHard2nd.Text = aspectSettingList[newIndex].orb_nn_sun_hard_2nd.ToString();
            nnMoonSoft2nd.Text = aspectSettingList[newIndex].orb_nn_moon_soft_2nd.ToString();
            nnMoonHard2nd.Text = aspectSettingList[newIndex].orb_nn_moon_hard_2nd.ToString();
            nnOtherSoft2nd.Text = aspectSettingList[newIndex].orb_nn_other_soft_2nd.ToString();
            nnOtherHard2nd.Text = aspectSettingList[newIndex].orb_nn_other_hard_2nd.ToString();
            nnSunSoft150.Text = aspectSettingList[newIndex].orb_nn_sun_soft_150.ToString();
            nnSunHard150.Text = aspectSettingList[newIndex].orb_nn_sun_hard_150.ToString();
            nnMoonSoft150.Text = aspectSettingList[newIndex].orb_nn_moon_soft_150.ToString();
            nnMoonHard150.Text = aspectSettingList[newIndex].orb_nn_moon_hard_150.ToString();
            nnOtherSoft150.Text = aspectSettingList[newIndex].orb_nn_other_soft_150.ToString();
            nnOtherHard150.Text = aspectSettingList[newIndex].orb_nn_other_hard_150.ToString();

            npSunSoft1st.Text = aspectSettingList[newIndex].orb_np_sun_soft_1st.ToString();
            npSunHard1st.Text = aspectSettingList[newIndex].orb_np_sun_hard_1st.ToString();
            npMoonSoft1st.Text = aspectSettingList[newIndex].orb_np_moon_soft_1st.ToString();
            npMoonHard1st.Text = aspectSettingList[newIndex].orb_np_moon_hard_1st.ToString();
            npOtherSoft1st.Text = aspectSettingList[newIndex].orb_np_other_soft_1st.ToString();
            npOtherHard1st.Text = aspectSettingList[newIndex].orb_np_other_hard_1st.ToString();
            npSunSoft2nd.Text = aspectSettingList[newIndex].orb_np_sun_soft_2nd.ToString();
            npSunHard2nd.Text = aspectSettingList[newIndex].orb_np_sun_hard_2nd.ToString();
            npMoonSoft2nd.Text = aspectSettingList[newIndex].orb_np_moon_soft_2nd.ToString();
            npMoonHard2nd.Text = aspectSettingList[newIndex].orb_np_moon_hard_2nd.ToString();
            npOtherSoft2nd.Text = aspectSettingList[newIndex].orb_np_other_soft_2nd.ToString();
            npOtherHard2nd.Text = aspectSettingList[newIndex].orb_np_other_hard_2nd.ToString();
            npSunSoft150.Text = aspectSettingList[newIndex].orb_np_sun_soft_150.ToString();
            npSunHard150.Text = aspectSettingList[newIndex].orb_np_sun_hard_150.ToString();
            npMoonSoft150.Text = aspectSettingList[newIndex].orb_np_moon_soft_150.ToString();
            npMoonHard150.Text = aspectSettingList[newIndex].orb_np_moon_hard_150.ToString();
            npOtherSoft150.Text = aspectSettingList[newIndex].orb_np_other_soft_150.ToString();
            npOtherHard150.Text = aspectSettingList[newIndex].orb_np_other_hard_150.ToString();

            ntSunSoft1st.Text = aspectSettingList[newIndex].orb_nt_sun_soft_1st.ToString();
            ntSunHard1st.Text = aspectSettingList[newIndex].orb_nt_sun_hard_1st.ToString();
            ntMoonSoft1st.Text = aspectSettingList[newIndex].orb_nt_moon_soft_1st.ToString();
            ntMoonHard1st.Text = aspectSettingList[newIndex].orb_nt_moon_hard_1st.ToString();
            ntOtherSoft1st.Text = aspectSettingList[newIndex].orb_nt_other_soft_1st.ToString();
            ntOtherHard1st.Text = aspectSettingList[newIndex].orb_nt_other_hard_1st.ToString();
            ntSunSoft2nd.Text = aspectSettingList[newIndex].orb_nt_sun_soft_2nd.ToString();
            ntSunHard2nd.Text = aspectSettingList[newIndex].orb_nt_sun_hard_2nd.ToString();
            ntMoonSoft2nd.Text = aspectSettingList[newIndex].orb_nt_moon_soft_2nd.ToString();
            ntMoonHard2nd.Text = aspectSettingList[newIndex].orb_nt_moon_hard_2nd.ToString();
            ntOtherSoft2nd.Text = aspectSettingList[newIndex].orb_nt_other_soft_2nd.ToString();
            ntOtherHard2nd.Text = aspectSettingList[newIndex].orb_nt_other_hard_2nd.ToString();
            ntSunSoft150.Text = aspectSettingList[newIndex].orb_nt_sun_soft_150.ToString();
            ntSunHard150.Text = aspectSettingList[newIndex].orb_nt_sun_hard_150.ToString();
            ntMoonSoft150.Text = aspectSettingList[newIndex].orb_nt_moon_soft_150.ToString();
            ntMoonHard150.Text = aspectSettingList[newIndex].orb_nt_moon_hard_150.ToString();
            ntOtherSoft150.Text = aspectSettingList[newIndex].orb_nt_other_soft_150.ToString();
            ntOtherHard150.Text = aspectSettingList[newIndex].orb_nt_other_hard_150.ToString();

            ppSunSoft1st.Text = aspectSettingList[newIndex].orb_pp_sun_soft_1st.ToString();
            ppSunHard1st.Text = aspectSettingList[newIndex].orb_pp_sun_hard_1st.ToString();
            ppMoonSoft1st.Text = aspectSettingList[newIndex].orb_pp_moon_soft_1st.ToString();
            ppMoonHard1st.Text = aspectSettingList[newIndex].orb_pp_moon_hard_1st.ToString();
            ppOtherSoft1st.Text = aspectSettingList[newIndex].orb_pp_other_soft_1st.ToString();
            ppOtherHard1st.Text = aspectSettingList[newIndex].orb_pp_other_hard_1st.ToString();
            ppSunSoft2nd.Text = aspectSettingList[newIndex].orb_pp_sun_soft_2nd.ToString();
            ppSunHard2nd.Text = aspectSettingList[newIndex].orb_pp_sun_hard_2nd.ToString();
            ppMoonSoft2nd.Text = aspectSettingList[newIndex].orb_pp_moon_soft_2nd.ToString();
            ppMoonHard2nd.Text = aspectSettingList[newIndex].orb_pp_moon_hard_2nd.ToString();
            ppOtherSoft2nd.Text = aspectSettingList[newIndex].orb_pp_other_soft_2nd.ToString();
            ppOtherHard2nd.Text = aspectSettingList[newIndex].orb_pp_other_hard_2nd.ToString();
            ppSunSoft150.Text = aspectSettingList[newIndex].orb_pp_sun_soft_150.ToString();
            ppSunHard150.Text = aspectSettingList[newIndex].orb_pp_sun_hard_150.ToString();
            ppMoonSoft150.Text = aspectSettingList[newIndex].orb_pp_moon_soft_150.ToString();
            ppMoonHard150.Text = aspectSettingList[newIndex].orb_pp_moon_hard_150.ToString();
            ppOtherSoft150.Text = aspectSettingList[newIndex].orb_pp_other_soft_150.ToString();
            ppOtherHard150.Text = aspectSettingList[newIndex].orb_pp_other_hard_150.ToString();

            ptSunSoft1st.Text = aspectSettingList[newIndex].orb_pt_sun_soft_1st.ToString();
            ptSunHard1st.Text = aspectSettingList[newIndex].orb_pt_sun_hard_1st.ToString();
            ptMoonSoft1st.Text = aspectSettingList[newIndex].orb_pt_moon_soft_1st.ToString();
            ptMoonHard1st.Text = aspectSettingList[newIndex].orb_pt_moon_hard_1st.ToString();
            ptOtherSoft1st.Text = aspectSettingList[newIndex].orb_pt_other_soft_1st.ToString();
            ptOtherHard1st.Text = aspectSettingList[newIndex].orb_pt_other_hard_1st.ToString();
            ptSunSoft2nd.Text = aspectSettingList[newIndex].orb_pt_sun_soft_2nd.ToString();
            ptSunHard2nd.Text = aspectSettingList[newIndex].orb_pt_sun_hard_2nd.ToString();
            ptMoonSoft2nd.Text = aspectSettingList[newIndex].orb_pt_moon_soft_2nd.ToString();
            ptMoonHard2nd.Text = aspectSettingList[newIndex].orb_pt_moon_hard_2nd.ToString();
            ptOtherSoft2nd.Text = aspectSettingList[newIndex].orb_pt_other_soft_2nd.ToString();
            ptOtherHard2nd.Text = aspectSettingList[newIndex].orb_pt_other_hard_2nd.ToString();
            ptSunSoft150.Text = aspectSettingList[newIndex].orb_pt_sun_soft_150.ToString();
            ptSunHard150.Text = aspectSettingList[newIndex].orb_pt_sun_hard_150.ToString();
            ptMoonSoft150.Text = aspectSettingList[newIndex].orb_pt_moon_soft_150.ToString();
            ptMoonHard150.Text = aspectSettingList[newIndex].orb_pt_moon_hard_150.ToString();
            ptOtherSoft150.Text = aspectSettingList[newIndex].orb_pt_other_soft_150.ToString();
            ptOtherHard150.Text = aspectSettingList[newIndex].orb_pt_other_hard_150.ToString();

            ttSunSoft1st.Text = aspectSettingList[newIndex].orb_tt_sun_soft_1st.ToString();
            ttSunHard1st.Text = aspectSettingList[newIndex].orb_tt_sun_hard_1st.ToString();
            ttMoonSoft1st.Text = aspectSettingList[newIndex].orb_tt_moon_soft_1st.ToString();
            ttMoonHard1st.Text = aspectSettingList[newIndex].orb_tt_moon_hard_1st.ToString();
            ttOtherSoft1st.Text = aspectSettingList[newIndex].orb_tt_other_soft_1st.ToString();
            ttOtherHard1st.Text = aspectSettingList[newIndex].orb_tt_other_hard_1st.ToString();
            ttSunSoft2nd.Text = aspectSettingList[newIndex].orb_tt_sun_soft_2nd.ToString();
            ttSunHard2nd.Text = aspectSettingList[newIndex].orb_tt_sun_hard_2nd.ToString();
            ttMoonSoft2nd.Text = aspectSettingList[newIndex].orb_tt_moon_soft_2nd.ToString();
            ttMoonHard2nd.Text = aspectSettingList[newIndex].orb_tt_moon_hard_2nd.ToString();
            ttOtherSoft2nd.Text = aspectSettingList[newIndex].orb_tt_other_soft_2nd.ToString();
            ttOtherHard2nd.Text = aspectSettingList[newIndex].orb_tt_other_hard_2nd.ToString();
            ttSunSoft150.Text = aspectSettingList[newIndex].orb_tt_sun_soft_150.ToString();
            ttSunHard150.Text = aspectSettingList[newIndex].orb_tt_sun_hard_150.ToString();
            ttMoonSoft150.Text = aspectSettingList[newIndex].orb_tt_moon_soft_150.ToString();
            ttMoonHard150.Text = aspectSettingList[newIndex].orb_tt_moon_hard_150.ToString();
            ttOtherSoft150.Text = aspectSettingList[newIndex].orb_tt_other_soft_150.ToString();
            ttOtherHard150.Text = aspectSettingList[newIndex].orb_tt_other_hard_150.ToString();

        }

        private void SaveData()
        {
            aspectSettingList[index].dispname = displayName.Text;

            aspectSettingList[index].n_n = nnDisp.Checked;
            aspectSettingList[index].n_p = npDisp.Checked;
            aspectSettingList[index].n_t = ntDisp.Checked;
            aspectSettingList[index].p_p = ppDisp.Checked;
            aspectSettingList[index].p_t = ptDisp.Checked;
            aspectSettingList[index].t_t = ttDisp.Checked;

            aspectSettingList[index].orb_nn_sun_soft_1st = double.Parse(nnSunSoft1st.Text);
            aspectSettingList[index].orb_nn_sun_hard_1st = double.Parse(nnSunHard1st.Text);
            aspectSettingList[index].orb_nn_moon_soft_1st = double.Parse(nnMoonSoft1st.Text);
            aspectSettingList[index].orb_nn_moon_hard_1st = double.Parse(nnMoonHard1st.Text);
            aspectSettingList[index].orb_nn_other_soft_1st = double.Parse(nnOtherSoft1st.Text);
            aspectSettingList[index].orb_nn_other_hard_1st = double.Parse(nnOtherHard1st.Text);
            aspectSettingList[index].orb_nn_sun_soft_2nd = double.Parse(nnSunSoft2nd.Text);
            aspectSettingList[index].orb_nn_sun_hard_2nd = double.Parse(nnSunHard2nd.Text);
            aspectSettingList[index].orb_nn_moon_soft_2nd = double.Parse(nnMoonSoft2nd.Text);
            aspectSettingList[index].orb_nn_moon_hard_2nd = double.Parse(nnMoonHard2nd.Text);
            aspectSettingList[index].orb_nn_other_soft_2nd = double.Parse(nnOtherSoft2nd.Text);
            aspectSettingList[index].orb_nn_other_hard_2nd = double.Parse(nnOtherHard2nd.Text);
            aspectSettingList[index].orb_nn_sun_soft_150 = double.Parse(nnSunSoft150.Text);
            aspectSettingList[index].orb_nn_sun_hard_150 = double.Parse(nnSunHard150.Text);
            aspectSettingList[index].orb_nn_moon_soft_150 = double.Parse(nnMoonSoft150.Text);
            aspectSettingList[index].orb_nn_moon_hard_150 = double.Parse(nnMoonHard150.Text);
            aspectSettingList[index].orb_nn_other_soft_150 = double.Parse(nnOtherSoft150.Text);
            aspectSettingList[index].orb_nn_other_hard_150 = double.Parse(nnOtherHard150.Text);

            aspectSettingList[index].orb_np_sun_soft_1st = double.Parse(npSunSoft1st.Text);
            aspectSettingList[index].orb_np_sun_hard_1st = double.Parse(npSunHard1st.Text);
            aspectSettingList[index].orb_np_moon_soft_1st = double.Parse(npMoonSoft1st.Text);
            aspectSettingList[index].orb_np_moon_hard_1st = double.Parse(npMoonHard1st.Text);
            aspectSettingList[index].orb_np_other_soft_1st = double.Parse(npOtherSoft1st.Text);
            aspectSettingList[index].orb_np_other_hard_1st = double.Parse(npOtherHard1st.Text);
            aspectSettingList[index].orb_np_sun_soft_2nd = double.Parse(npSunSoft2nd.Text);
            aspectSettingList[index].orb_np_sun_hard_2nd = double.Parse(npSunHard2nd.Text);
            aspectSettingList[index].orb_np_moon_soft_2nd = double.Parse(npMoonSoft2nd.Text);
            aspectSettingList[index].orb_np_moon_hard_2nd = double.Parse(npMoonHard2nd.Text);
            aspectSettingList[index].orb_np_other_soft_2nd = double.Parse(npOtherSoft2nd.Text);
            aspectSettingList[index].orb_np_other_hard_2nd = double.Parse(npOtherHard2nd.Text);
            aspectSettingList[index].orb_np_sun_soft_150 = double.Parse(npSunSoft150.Text);
            aspectSettingList[index].orb_np_sun_hard_150 = double.Parse(npSunHard150.Text);
            aspectSettingList[index].orb_np_moon_soft_150 = double.Parse(npMoonSoft150.Text);
            aspectSettingList[index].orb_np_moon_hard_150 = double.Parse(npMoonHard150.Text);
            aspectSettingList[index].orb_np_other_soft_150 = double.Parse(npOtherSoft150.Text);
            aspectSettingList[index].orb_np_other_hard_150 = double.Parse(npOtherHard150.Text);

            aspectSettingList[index].orb_nt_sun_soft_1st = double.Parse(ntSunSoft1st.Text);
            aspectSettingList[index].orb_nt_sun_hard_1st = double.Parse(ntSunHard1st.Text);
            aspectSettingList[index].orb_nt_moon_soft_1st = double.Parse(ntMoonSoft1st.Text);
            aspectSettingList[index].orb_nt_moon_hard_1st = double.Parse(ntMoonHard1st.Text);
            aspectSettingList[index].orb_nt_other_soft_1st = double.Parse(ntOtherSoft1st.Text);
            aspectSettingList[index].orb_nt_other_hard_1st = double.Parse(ntOtherHard1st.Text);
            aspectSettingList[index].orb_nt_sun_soft_2nd = double.Parse(ntSunSoft2nd.Text);
            aspectSettingList[index].orb_nt_sun_hard_2nd = double.Parse(ntSunHard2nd.Text);
            aspectSettingList[index].orb_nt_moon_soft_2nd = double.Parse(ntMoonSoft2nd.Text);
            aspectSettingList[index].orb_nt_moon_hard_2nd = double.Parse(ntMoonHard2nd.Text);
            aspectSettingList[index].orb_nt_other_soft_2nd = double.Parse(ntOtherSoft2nd.Text);
            aspectSettingList[index].orb_nt_other_hard_2nd = double.Parse(ntOtherHard2nd.Text);
            aspectSettingList[index].orb_nt_sun_soft_150 = double.Parse(ntSunSoft150.Text);
            aspectSettingList[index].orb_nt_sun_hard_150 = double.Parse(ntSunHard150.Text);
            aspectSettingList[index].orb_nt_moon_soft_150 = double.Parse(ntMoonSoft150.Text);
            aspectSettingList[index].orb_nt_moon_hard_150 = double.Parse(ntMoonHard150.Text);
            aspectSettingList[index].orb_nt_other_soft_150 = double.Parse(ntOtherSoft150.Text);
            aspectSettingList[index].orb_nt_other_hard_150 = double.Parse(ntOtherHard150.Text);

            aspectSettingList[index].orb_pp_sun_soft_1st = double.Parse(ppSunSoft1st.Text);
            aspectSettingList[index].orb_pp_sun_hard_1st = double.Parse(ppSunHard1st.Text);
            aspectSettingList[index].orb_pp_moon_soft_1st = double.Parse(ppMoonSoft1st.Text);
            aspectSettingList[index].orb_pp_moon_hard_1st = double.Parse(ppMoonHard1st.Text);
            aspectSettingList[index].orb_pp_other_soft_1st = double.Parse(ppOtherSoft1st.Text);
            aspectSettingList[index].orb_pp_other_hard_1st = double.Parse(ppOtherHard1st.Text);
            aspectSettingList[index].orb_pp_sun_soft_2nd = double.Parse(ppSunSoft2nd.Text);
            aspectSettingList[index].orb_pp_sun_hard_2nd = double.Parse(ppSunHard2nd.Text);
            aspectSettingList[index].orb_pp_moon_soft_2nd = double.Parse(ppMoonSoft2nd.Text);
            aspectSettingList[index].orb_pp_moon_hard_2nd = double.Parse(ppMoonHard2nd.Text);
            aspectSettingList[index].orb_pp_other_soft_2nd = double.Parse(ppOtherSoft2nd.Text);
            aspectSettingList[index].orb_pp_other_hard_2nd = double.Parse(ppOtherHard2nd.Text);
            aspectSettingList[index].orb_pp_sun_soft_150 = double.Parse(ppSunSoft150.Text);
            aspectSettingList[index].orb_pp_sun_hard_150 = double.Parse(ppSunHard150.Text);
            aspectSettingList[index].orb_pp_moon_soft_150 = double.Parse(ppMoonSoft150.Text);
            aspectSettingList[index].orb_pp_moon_hard_150 = double.Parse(ppMoonHard150.Text);
            aspectSettingList[index].orb_pp_other_soft_150 = double.Parse(ppOtherSoft150.Text);
            aspectSettingList[index].orb_pp_other_hard_150 = double.Parse(ppOtherHard150.Text);

            aspectSettingList[index].orb_pt_sun_soft_1st = double.Parse(ptSunSoft1st.Text);
            aspectSettingList[index].orb_pt_sun_hard_1st = double.Parse(ptSunHard1st.Text);
            aspectSettingList[index].orb_pt_moon_soft_1st = double.Parse(ptMoonSoft1st.Text);
            aspectSettingList[index].orb_pt_moon_hard_1st = double.Parse(ptMoonHard1st.Text);
            aspectSettingList[index].orb_pt_other_soft_1st = double.Parse(ptOtherSoft1st.Text);
            aspectSettingList[index].orb_pt_other_hard_1st = double.Parse(ptOtherHard1st.Text);
            aspectSettingList[index].orb_pt_sun_soft_2nd = double.Parse(ptSunSoft2nd.Text);
            aspectSettingList[index].orb_pt_sun_hard_2nd = double.Parse(ptSunHard2nd.Text);
            aspectSettingList[index].orb_pt_moon_soft_2nd = double.Parse(ptMoonSoft2nd.Text);
            aspectSettingList[index].orb_pt_moon_hard_2nd = double.Parse(ptMoonHard2nd.Text);
            aspectSettingList[index].orb_pt_other_soft_2nd = double.Parse(ptOtherSoft2nd.Text);
            aspectSettingList[index].orb_pt_other_hard_2nd = double.Parse(ptOtherHard2nd.Text);
            aspectSettingList[index].orb_pt_sun_soft_150 = double.Parse(ptSunSoft150.Text);
            aspectSettingList[index].orb_pt_sun_hard_150 = double.Parse(ptSunHard150.Text);
            aspectSettingList[index].orb_pt_moon_soft_150 = double.Parse(ptMoonSoft150.Text);
            aspectSettingList[index].orb_pt_moon_hard_150 = double.Parse(ptMoonHard150.Text);
            aspectSettingList[index].orb_pt_other_soft_150 = double.Parse(ptOtherSoft150.Text);
            aspectSettingList[index].orb_pt_other_hard_150 = double.Parse(ptOtherHard150.Text);

            aspectSettingList[index].orb_tt_sun_soft_1st = double.Parse(ttSunSoft1st.Text);
            aspectSettingList[index].orb_tt_sun_hard_1st = double.Parse(ttSunHard1st.Text);
            aspectSettingList[index].orb_tt_moon_soft_1st = double.Parse(ttMoonSoft1st.Text);
            aspectSettingList[index].orb_tt_moon_hard_1st = double.Parse(ttMoonHard1st.Text);
            aspectSettingList[index].orb_tt_other_soft_1st = double.Parse(ttOtherSoft1st.Text);
            aspectSettingList[index].orb_tt_other_hard_1st = double.Parse(ttOtherHard1st.Text);
            aspectSettingList[index].orb_tt_sun_soft_2nd = double.Parse(ttSunSoft2nd.Text);
            aspectSettingList[index].orb_tt_sun_hard_2nd = double.Parse(ttSunHard2nd.Text);
            aspectSettingList[index].orb_tt_moon_soft_2nd = double.Parse(ttMoonSoft2nd.Text);
            aspectSettingList[index].orb_tt_moon_hard_2nd = double.Parse(ttMoonHard2nd.Text);
            aspectSettingList[index].orb_tt_other_soft_2nd = double.Parse(ttOtherSoft2nd.Text);
            aspectSettingList[index].orb_tt_other_hard_2nd = double.Parse(ttOtherHard2nd.Text);
            aspectSettingList[index].orb_tt_sun_soft_150 = double.Parse(ttSunSoft150.Text);
            aspectSettingList[index].orb_tt_sun_hard_150 = double.Parse(ttSunHard150.Text);
            aspectSettingList[index].orb_tt_moon_soft_150 = double.Parse(ttMoonSoft150.Text);
            aspectSettingList[index].orb_tt_moon_hard_150 = double.Parse(ttMoonHard150.Text);
            aspectSettingList[index].orb_tt_other_soft_150 = double.Parse(ttOtherSoft150.Text);
            aspectSettingList[index].orb_tt_other_hard_150 = double.Parse(ttOtherHard150.Text);

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            mainform.ChangeSettingCombo(aspectSettingList);
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // 表示中のデータを保存
            SaveData();

            // 書き出し
            Enumerable.Range(0, 10).ToList().ForEach(newIndex => {
                string filename = mainform.aspect_filename + newIndex.ToString() + ".xml";
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                XmlSerializer aspect_serializer = new XmlSerializer(typeof(AspectSetting));
                FileStream aspect_fs = new FileStream(filename, FileMode.Create);
                StreamWriter aspect_sw = new StreamWriter(aspect_fs);
                aspect_serializer.Serialize(aspect_sw, mainform.aspectSettingList[newIndex]);
                aspect_sw.Close();
                aspect_fs.Close();

            });
        }

        private void displayName_Leave(object sender, EventArgs e)
        {
            settingList.Items[index] = ((TextBox)sender).Text;
        }
    }
}
