using microcosm.Calc;
using microcosm.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace microcosm
{
    // レンダリング周りを集約
    // Shape周りだと重ね合わせがきれいにできず
    // PictureBoxだとマウスオーバーがうまくいかず
    // 結論、フォームアプリは適当な所でいいや
    // uwpでWebView呼んでcanvas使ったほうが楽
    partial class MainForm
    {
        public Bitmap canvas;
        public Bitmap canvas2;

        // 左下テーブルレンダリング
        private void tableRender(
            List<PlanetData> natallist, 
            List<PlanetData> progresslist, 
            List<PlanetData> transitlist,
            double[] natalcusp, 
            double[] progresscusp, 
            double[] transitcusp)
        {
            planetList.Clear();
            ColumnHeader planet = new ColumnHeader() { Text = "", Width = 30, TextAlign = HorizontalAlignment.Left };
            ColumnHeader natal = new ColumnHeader() { Text = "N", Width = 80, TextAlign = HorizontalAlignment.Left };
            planetList.Columns.Add(planet);
            planetList.Columns.Add(natal);

            // ヘッダー
            if (setting.bands > 1)
            {
                ColumnHeader transit = new ColumnHeader() { Text = "P", Width = 80, TextAlign = HorizontalAlignment.Left };
                planetList.Columns.Add(transit);
                if (setting.bands > 2)
                {
                    ColumnHeader progress = new ColumnHeader() { Text = "T", Width = 80, TextAlign = HorizontalAlignment.Left };
                    planetList.Columns.Add(progress);
                    /*
                    ColumnHeader sr = new ColumnHeader() { Text = "SR", Width = 80, TextAlign = HorizontalAlignment.Left };
                    planetList.Columns.Add(sr);
                    */
                }
            }

            // リスト
            // 天体10
            Enumerable.Range(0, 10).ToList().ForEach(i =>
            {
                ListViewItem item = new ListViewItem(Common.getPlanetSymbol(i)) { Font = new Font("Segoe UI Symbol", 11) };
                //                item.Font = new Font("Zodiac S", 12);
                string txt = Common.getSignText(natallist[i].absolute_position) + "  " +
                    Common.getDeg(natallist[i].absolute_position).ToString("00.000");
                if (natallist[i].speed < 0)
                {
                    txt += "R";
                }
                item.SubItems.Add(txt);

                if (setting.bands > 1 && progresslist != null)
                {
                    item.SubItems.Add(Common.getSignText(progresslist[i].absolute_position) + "  " +
                        Common.getDeg(progresslist[i].absolute_position).ToString("00.000"));
                    if (setting.bands > 2 && transitlist != null)
                    {
                        item.SubItems.Add(Common.getSignText(transitlist[i].absolute_position) + "  " +
                            Common.getDeg(transitlist[i].absolute_position).ToString("00.000"));
                    }

                }

                planetList.Items.Add(item);

            });

            // カスプ12
            Label[] labels = { cusp1, cusp2, cusp3, cusp4, cusp5, cusp6, cusp7, cusp8, cusp9, cusp10, cusp11, cusp12 };

            Enumerable.Range(1, 12).ToList().ForEach(i =>
            {
                string s;
                if (i == 1)
                {
                    s = i.ToString() + "(ASC)";
                }
                else if (i == 4)
                {
                    s = i.ToString() + "(IC)";
                }
                else if (i == 7)
                {
                    s = i.ToString() + "(DSC)";
                }
                else if (i == 10)
                {
                    s = i.ToString() + "(MC)";
                }
                else
                {
                    s = i.ToString();
                }
                ListViewItem item = new ListViewItem(s);
                item.Font = new Font("Segoe UI Symbol", 11);
                item.SubItems.Add(Common.getSignText(natalcusp[i]) + "  " +
                    Common.getDeg(natalcusp[i]).ToString("00.000"));

                if (setting.bands > 1 && progresscusp != null)
                {
                    item.SubItems.Add(Common.getSignText(progresscusp[i]) + "  " +
                        Common.getDeg(progresscusp[i]).ToString("00.000"));
                    if (setting.bands > 2 && transitcusp != null)
                    {
                        item.SubItems.Add(Common.getSignText(transitcusp[i]) + "  " +
                            Common.getDeg(transitcusp[i]).ToString("00.000"));
                    }

                }

                //                cuspListA.Items.Add(s + Common.getSignText(natalcusp[i]) + "  " +
                //                    Common.getDeg(natalcusp[i]).ToString("00.000"));
                labels[i - 1].Text = Common.getSignText(natalcusp[i]) + "  " + Common.getDeg(natalcusp[i]).ToString("00.000");
            });

            if (config.centric == ECentric.HELIO_CENTRIC)
            {
                centricLabel.Text = "HerioCentric";
            }
            if (config.sidereal == Esidereal.SIDEREAL)
            {
                tropicalLabel.Text = "sidereal";
            }
            if (config.progression == 1)
            {
                progressionLabel.Text = "一度一年法";
            } else if (config.progression == 2)
            {
                progressionLabel.Text = "一日一年法";
            } else
            {
                progressionLabel.Text = "CPS";
            }

        }

        // Label Iterator
        private IEnumerable<Label> labels()
        {
            Label[] labels = { cusp1, cusp2, cusp3, cusp4, cusp5, cusp6, cusp7, cusp8, cusp9, cusp10, cusp11, cusp12 };
            foreach (Label l in labels)
            {
                yield return l;
            }
        }

        // 輪のレンダリング
        private void ringRender()
        {
            Pen thick = new Pen(Color.Black, 2);
            Pen thin = new Pen(Color.LightGray, 1);
            Graphics g = Graphics.FromImage(canvas);
            g.DrawEllipse(thick, setting.zodiacRingOuterPadding.X, setting.zodiacRingOuterPadding.Y, setting.zodiacRadius, setting.zodiacRadius);
            g.DrawEllipse(thick, setting.zodiacRingInnerPadding.X, setting.zodiacRingInnerPadding.Y, setting.calcZodiacInnerRadius(), setting.calcZodiacInnerRadius());
            g.DrawEllipse(thick, setting.innerRingPadding.X, setting.innerRingPadding.Y, setting.calcInnerRadius(), setting.calcInnerRadius());

            if (setting.bands == 2)
            {
                g.DrawEllipse(thin, setting.secondRingPadding.X, setting.secondRingPadding.Y, setting.calcSecondInnerRadius(), setting.calcSecondInnerRadius());
            } else if (setting.bands == 3)
            {
                g.DrawEllipse(thin, setting.secondRingPadding.X, setting.secondRingPadding.Y, setting.calcSecondInnerRadius(), setting.calcSecondInnerRadius());
                g.DrawEllipse(thin, setting.thirdRingPadding.X, setting.thirdRingPadding.Y, setting.calcThirdInnerRadius(), setting.calcThirdInnerRadius());
            }
            chartPanel.Image = canvas;
            g.Dispose();
            thick.Dispose();
            thin.Dispose();
        }

        // ハウスカスプレンダリング
        private void houseCuspRender(double[] natalcusp)
        {
            Pen blk = new Pen(Color.Black, 1);
            Graphics g = Graphics.FromImage(canvas);
            double startX = setting.calcInnerRadius() / 2;
            double endX = setting.zodiacRadius / 2 - setting.zodiacRingWidth;

            double startY = 0;
            double endY = 0;
            Enumerable.Range(1, 12).ToList().ForEach(i =>
            {
                double degree = natalcusp[i] - natalcusp[1];

                PointF newStart = rotate(startX, startY, degree);
                newStart.X += setting.zodiacRingOuterPadding.X;
                newStart.X += setting.zodiacRadius / 2;
                // Formの座標は下がプラス、数学では上がマイナス
                newStart.Y = newStart.Y * -1;
                newStart.Y += setting.zodiacRingOuterPadding.Y;
                newStart.Y += setting.zodiacRadius / 2;

                PointF newEnd = rotate(endX, endY, degree);
                newEnd.X += setting.zodiacRingOuterPadding.X;
                newEnd.X += setting.zodiacRadius / 2;
                // Formの座標は下がプラス、数学では上がマイナス
                newEnd.Y = newEnd.Y * -1;
                newEnd.Y += setting.zodiacRingOuterPadding.Y;
                newEnd.Y += setting.zodiacRadius / 2;

                g.DrawLine(blk, (int)newStart.X, (int)newStart.Y, (int)newEnd.X, (int)newEnd.Y);

            });
            blk.Dispose();
            g.Dispose();
        }

        // サインカスプレンダリング
        private void signCuspRender(double startdegree)
        {
            Pen blk = new Pen(Color.Navy, 1);
            Graphics g = Graphics.FromImage(canvas);
            double startX =setting.zodiacRadius / 2 - setting.zodiacRingWidth;
            double endX = setting.zodiacRadius / 2;

            double startY = 0;
            double endY = 0;
            Enumerable.Range(1, 13).ToList().ForEach(i =>
           {
               double degree = (30.0 * i) - startdegree;

               PointF newStart = rotate(startX, startY, degree);
               newStart.X += setting.zodiacRingOuterPadding.X;
               newStart.X += setting.zodiacRadius / 2;
                // Formの座標は下がプラス、数学では上がマイナス
                newStart.Y = newStart.Y * -1;
               newStart.Y += setting.zodiacRingOuterPadding.Y;
               newStart.Y += setting.zodiacRadius / 2;

               PointF newEnd = rotate(endX, endY, degree);
               newEnd.X += setting.zodiacRingOuterPadding.X;
               newEnd.X += setting.zodiacRadius / 2;
                // Formの座標は下がプラス、数学では上がマイナス
                newEnd.Y = newEnd.Y * -1;
               newEnd.Y += setting.zodiacRingOuterPadding.Y;
               newEnd.Y += setting.zodiacRadius / 2;

               g.DrawLine(blk, (int)newStart.X, (int)newStart.Y, (int)newEnd.X, (int)newEnd.Y);
           });
            blk.Dispose();
            g.Dispose();
        }

        // zodiac文字列描画
        private void zodiacRender(double startdegree)
        {
            Font fnt = new Font("Segoe UI Symbol", 14);
            SolidBrush brush = new SolidBrush(Color.Red);
            Graphics g = Graphics.FromImage(canvas);
            Enumerable.Range(0, 12).ToList().ForEach(i =>
            {
                PointF point = rotate(setting.zodiacRadius / 2 - 20, 0, (30 * (i + 1)) - startdegree - 15.0);
                point.X += setting.zodiacRingOuterPadding.X;
                point.X += setting.zodiacRadius / 2;
                point.X -= 10;
                point.Y *= -1;
                point.Y += setting.zodiacRingOuterPadding.Y;
                point.Y += setting.zodiacRadius / 2;
                point.Y -= 13;
                g.DrawString(Common.getSignSymbol(i), fnt, brush, point.X, point.Y);
            });
        }

        // 天体の表示
        private void planetRender(double startdegree, List<PlanetData> natallist,
            List<PlanetData> progresslist,
            List<PlanetData> transitlist)
        {
            // カスプ線とラベルのレンダリングがうまく行かず
            // 今後uwpアプリ版でWebView使うことにするのでformアプリは適当なところであきらめる
            Font fnt = new Font("Segoe UI Symbol", 14);
            SolidBrush brush = new SolidBrush(Color.Red);
            Graphics g = Graphics.FromImage(canvas);
            natallist.ForEach(planet =>
            {
                PointF point;
                if (setting.bands == 1)
                {
                    point = rotate(170, 0, planet.absolute_position - startdegree);
                }
                else if (setting.bands == 2)
                {
                    point = rotate(152, 0, planet.absolute_position - startdegree);
                }
                else
                {
                    point = rotate(136, 0, planet.absolute_position - startdegree);
                }
                point.X += setting.zodiacRingOuterPadding.X;
                point.X += setting.zodiacRadius / 2;
                point.X -= 8;
                point.Y *= -1;
                point.Y += setting.zodiacRingOuterPadding.Y;
                point.Y += setting.zodiacRadius / 2;
                point.Y -= 15;
                g.DrawString(Common.getPlanetSymbol(planet.no), fnt, brush, point.X, point.Y);
            });

            if (setting.bands == 2)
            {
                progresslist.ForEach(planet =>
                {
                    PointF point = rotate(167, 0, planet.absolute_position - startdegree);
                    point.X += setting.zodiacRingOuterPadding.X;
                    point.X += setting.zodiacRadius / 2;
                    point.X -= 8;
                    point.Y *= -1;
                    point.Y += setting.zodiacRingOuterPadding.Y;
                    point.Y += setting.zodiacRadius / 2;
                    point.Y -= 15;
                    g.DrawString(Common.getPlanetSymbol(planet.no), fnt, brush, point.X, point.Y);
                });

            }

            if (setting.bands == 3)
            {
                progresslist.ForEach(planet =>
                {
                    PointF point = rotate(167, 0, planet.absolute_position - startdegree);
                    point.X += setting.zodiacRingOuterPadding.X;
                    point.X += setting.zodiacRadius / 2;
                    point.X -= 8;
                    point.Y *= -1;
                    point.Y += setting.zodiacRingOuterPadding.Y;
                    point.Y += setting.zodiacRadius / 2;
                    point.Y -= 15;
                    g.DrawString(Common.getPlanetSymbol(planet.no), fnt, brush, point.X, point.Y);
                });

                transitlist.ForEach(planet =>
                {
                    PointF point = rotate(195, 0, planet.absolute_position - startdegree);
                    point.X += setting.zodiacRingOuterPadding.X;
                    point.X += setting.zodiacRadius / 2;
                    point.X -= 8;
                    point.Y *= -1;
                    point.Y += setting.zodiacRingOuterPadding.Y;
                    point.Y += setting.zodiacRadius / 2;
                    point.Y -= 15;
                    g.DrawString(Common.getPlanetSymbol(planet.no), fnt, brush, point.X, point.Y);
                });
            }

            g.Dispose();
            fnt.Dispose();
        }

        private void refreshRender()
        {
            if (canvas != null)
            {
                canvas.Dispose();
                chartPanel.Image = null;
            }
            canvas = new Bitmap(chartPanel.Width, chartPanel.Height);
            chartPanel.Image = canvas;
        }

        // ポイントの回転
        // 左サイドバーのwidthマイナスして呼び、後で足すこと
        private PointF rotate(double x, double y, double degree)
        {
            // ホロスコープは180°から始まる
            degree += 180.0;

            double rad = (degree / 180.0) * Math.PI;
            double newX = x * Math.Cos(rad) - y * Math.Sin(rad);
            double newY = x * Math.Sin(rad) + y * Math.Cos(rad);


            return new PointF((float)newX, (float)newY);
        }

    }
}
