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

            var sortcusp = natalcusp;
            Array.Sort(sortcusp);
            // リスト
            // 天体10
            int leftBottom = 0;
            int rightBottom = 0;
            int rightTop = 0;
            int leftTop = 0;
            int fire = 0;
            int earth = 0;
            int air = 0;
            int water = 0;
            int cardinalSign = 0;
            int fixedSign = 0;
            int mutableSign = 0;
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
                if (natallist[i].absolute_position < sortcusp[4])
                {
                    leftBottom++;
                }
                else if (natallist[i].absolute_position < sortcusp[7])
                {
                    rightBottom++;
                }
                else if (natallist[i].absolute_position < sortcusp[10])
                {
                    rightTop++;
                }
                else
                {
                    leftTop++;
                }

                if (natallist[i].absolute_position < 30.0 )
                {
                    cardinalSign++;
                    fire++;
                }
                else if (natallist[i].absolute_position < 60.0)
                {
                    fixedSign++;
                    earth++;
                }
                else if (natallist[i].absolute_position < 90.0)
                {
                    mutableSign++;
                    air++;
                }
                else if (natallist[i].absolute_position < 120.0)
                {
                    cardinalSign++;
                    water++;
                }
                else if (natallist[i].absolute_position < 150.0)
                {
                    fixedSign++;
                    fire++;
                }
                else if (natallist[i].absolute_position < 180.0)
                {
                    mutableSign++;
                    earth++;
                }
                else if (natallist[i].absolute_position < 210.0)
                {
                    cardinalSign++;
                    air++;
                }
                else if (natallist[i].absolute_position < 240.0)
                {
                    fixedSign++;
                    water++;
                }
                else if (natallist[i].absolute_position < 270.0)
                {
                    mutableSign++;
                    fire++;
                }
                else if (natallist[i].absolute_position < 300.0)
                {
                    cardinalSign++;
                    earth++;
                }
                else if (natallist[i].absolute_position < 300.0)
                {
                    fixedSign++;
                    air++;
                }
                else
                {
                    mutableSign++;
                    water++;
                }


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
            houseLeftBottom.Text = leftBottom.ToString();
            houseRightBottom.Text = rightBottom.ToString();
            houseRightTop.Text = rightTop.ToString();
            houseLeftTop.Text = leftTop.ToString();
            fireLabel.Text = fire.ToString();
            earthLabel.Text = earth.ToString();
            airLabel.Text = air.ToString();
            waterLabel.Text = water.ToString();
            cardinalLabel.Text = cardinalSign.ToString();
            fixedLabel.Text = fixedSign.ToString();
            mutableLabel.Text = mutableSign.ToString();


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
            if (config.houseCalc == 0)
            {
                houseCalcLabel.Text = "placidus";
            } else if (config.houseCalc == 1)
            {
                houseCalcLabel.Text = "koch";
            } else if (config.houseCalc == 2)
            {
                houseCalcLabel.Text = "campanus";
            } else
            {
                houseCalcLabel.Text = "equal";
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
            List<double> degreeList = new List<double>();
            natallist.ForEach(planet =>
            {
                // 天体表示させない
                if (!planet.isDisp)
                {
                    return;
                }

                int offset = 0;
                if (0 < degreeList.Find(p => p < planet.absolute_position + 4 && p > planet.absolute_position - 4))
                {
                    offset = 15;
                }
                PointF point;
                if (setting.bands == 1)
                {
                    point = rotate(160 + offset, 0, planet.absolute_position - startdegree);
                }
                else if (setting.bands == 2)
                {
                    point = rotate(152 + offset, 0, planet.absolute_position - startdegree);
                }
                else
                {
                    point = rotate(136 + offset, 0, planet.absolute_position - startdegree);
                }
                degreeList.Add(planet.absolute_position);
                point.X += setting.zodiacRingOuterPadding.X;
                point.X += setting.zodiacRadius / 2;
                point.X -= 8;
                point.Y *= -1;
                point.Y += setting.zodiacRingOuterPadding.Y;
                point.Y += setting.zodiacRadius / 2;
                point.Y -= 15;
                g.DrawString(Common.getPlanetSymbol(planet.no), fnt, brush, point.X, point.Y);
                Console.WriteLine(planet.absolute_position - startdegree);
            });

            if (setting.bands == 2)
            {
                progresslist.ForEach(planet =>
                {
                    if (!planet.isDisp)
                    {
                        return;
                    }

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
                    if (!planet.isDisp)
                    {
                        return;
                    }

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
                    if (!planet.isDisp)
                    {
                        return;
                    }

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

        // アスペクト表示
        public void aspectsRendering(double startDegree, List<PlanetData> natallist, List<PlanetData> progresslist, List<PlanetData> transitlist)
        {
            if (aspectSetting.n_n)
            {
                aspectRender(startDegree, natallist, 1, 1, 1);
            }
            if (aspectSetting.p_p && setting.bands > 1)
            {
                aspectRender(startDegree, progresslist, 2, 2, 1);
            }
            if (aspectSetting.t_t && setting.bands > 2)
            {
                aspectRender(startDegree, transitlist, 3, 3, 1);
            }
            if (aspectSetting.n_p && setting.bands > 1)
            {
                aspectRender(startDegree, natallist, 1, 2, 2);
            }
            if (aspectSetting.n_t && setting.bands > 2)
            {
                aspectRender(startDegree, natallist, 1, 3, 3);
            }
            if (aspectSetting.p_t && setting.bands > 2)
            {
                aspectRender(startDegree, progresslist, 2, 3, 3);
            }

        }

        private void aspectRender(double startDegree, List<PlanetData> list, int startPosition, int endPosition, int aspectKind)
        {
            if (list == null)
            {
                return;
            }
            Graphics g = Graphics.FromImage(canvas);
            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].isAspectDisp)
                {
                    continue;
                }
                PointF startPoint;
                PointF endPoint;
                Pen pen;
                if (startPosition == 1)
                {
                    startPoint = rotate(setting.calcInnerRadius() / 2, 0, list[i].absolute_position - startDegree);
                } else if (startPosition == 2)
                {
                    startPoint = rotate(setting.calcThirdInnerRadius() / 2, 0, list[i].absolute_position - startDegree);
                } else
                {
                    startPoint = rotate(setting.calcSecondInnerRadius() / 2, 0, list[i].absolute_position - startDegree);
                }
                startPoint.X += setting.zodiacRingOuterPadding.X;
                startPoint.X += setting.zodiacRadius / 2;
                startPoint.Y *= -1;
                startPoint.Y += setting.zodiacRingOuterPadding.Y;
                startPoint.Y += setting.zodiacRadius / 2;
                if (aspectKind == 1) // natal
                {
                    for (int j = 0; j < list[i].aspects.Count; j++)
                    {
                        if (!list[list[i].aspects[j].target_no].isAspectDisp )
                        {
                            continue;
                        }
                        if (endPosition == 1)
                        {
                            endPoint = rotate(setting.calcInnerRadius() / 2, 0, list[i].aspects[j].target_position - startDegree);
                        }
                        else if (endPosition == 2)
                        {
                            endPoint = rotate(setting.calcThirdInnerRadius() / 2, 0, list[i].aspects[j].target_position - startDegree);
                        }
                        else
                        {
                            endPoint = rotate(setting.calcSecondInnerRadius() / 2, 0, list[i].aspects[j].target_position - startDegree);
                        }
                        endPoint.X += setting.zodiacRingOuterPadding.X;
                        endPoint.X += setting.zodiacRadius / 2;
                        endPoint.Y *= -1;
                        endPoint.Y += setting.zodiacRingOuterPadding.Y;
                        endPoint.Y += setting.zodiacRadius / 2;
                        if (list[i].aspects[j].aspect_kind == AspectKind.OPPOSITION)
                        {
                            pen = new Pen(Color.Red);
                        }
                        else if (list[i].aspects[j].aspect_kind == AspectKind.SQUARE)
                        {
                            pen = new Pen(Color.Cyan);
                        }
                        else if (list[i].aspects[j].aspect_kind == AspectKind.TRINE)
                        {
                            pen = new Pen(Color.Orange);
                        }
                        else if (list[i].aspects[j].aspect_kind == AspectKind.SEXTILE)
                        {
                            pen = new Pen(Color.Green);
                        }
                        else
                        {
                            pen = new Pen(Color.Yellow);
                        }
                        g.DrawLine(pen, startPoint, endPoint);
                        pen.Dispose();
#if DEBUG
                        Console.WriteLine("1 i:" + i.ToString() + " j:" + j.ToString() + " deg:" + (list[i].aspects[j].target_position - startDegree).ToString());
#endif
                    }

                } else if (aspectKind == 2) // progress
                {
                    for (int j = 0; j < list[i].progressAspects.Count; j++)
                    {
                        if (!list[j].isAspectDisp)
                        {
//                            continue;
                        }
                        endPoint = rotate(setting.calcThirdInnerRadius() / 2, 0, list[i].progressAspects[j].target_position - startDegree);
                        endPoint.X += setting.zodiacRingOuterPadding.X;
                        endPoint.X += setting.zodiacRadius / 2;
                        endPoint.Y *= -1;
                        endPoint.Y += setting.zodiacRingOuterPadding.Y;
                        endPoint.Y += setting.zodiacRadius / 2;
                        if (list[i].progressAspects[j].aspect_kind == AspectKind.OPPOSITION)
                        {
                            pen = new Pen(Color.Red);
                        }
                        else if (list[i].progressAspects[j].aspect_kind == AspectKind.SQUARE)
                        {
                            pen = new Pen(Color.Cyan);
                        }
                        else if (list[i].progressAspects[j].aspect_kind == AspectKind.TRINE)
                        {
                            pen = new Pen(Color.Orange);
                        }
                        else if (list[i].progressAspects[j].aspect_kind == AspectKind.SEXTILE)
                        {
                            pen = new Pen(Color.Green);
                        }
                        else
                        {
                            pen = new Pen(Color.Yellow);
                        }
                        g.DrawLine(pen, startPoint, endPoint);
                        pen.Dispose();
#if DEBUG
                        Console.WriteLine("2 i:" + i.ToString() + " j:" + j.ToString() + " deg:" + (list[i].progressAspects[j].target_position - startDegree).ToString());
#endif
                    }

                }
                else if (aspectKind == 3) // transit
                {
                    for (int j = 0; j < list[i].transitAspects.Count; j++)
                    {
                        if (!list[j].isAspectDisp)
                        {
//                            continue;
                        }
                        endPoint = rotate(setting.calcSecondInnerRadius() / 2, 0, list[i].transitAspects[j].target_position - startDegree);
                        endPoint.X += setting.zodiacRingOuterPadding.X;
                        endPoint.X += setting.zodiacRadius / 2;
                        endPoint.Y *= -1;
                        endPoint.Y += setting.zodiacRingOuterPadding.Y;
                        endPoint.Y += setting.zodiacRadius / 2;
                        if (list[i].transitAspects[j].aspect_kind == AspectKind.OPPOSITION)
                        {
                            pen = new Pen(Color.Red);
                        }
                        else if (list[i].transitAspects[j].aspect_kind == AspectKind.SQUARE)
                        {
                            pen = new Pen(Color.Cyan);
                        }
                        else if (list[i].transitAspects[j].aspect_kind == AspectKind.TRINE)
                        {
                            pen = new Pen(Color.Orange);
                        }
                        else if (list[i].transitAspects[j].aspect_kind == AspectKind.SEXTILE)
                        {
                            pen = new Pen(Color.Green);
                        }
                        else
                        {
                            pen = new Pen(Color.Yellow);
                        }
                        g.DrawLine(pen, startPoint, endPoint);
                        pen.Dispose();
#if DEBUG
                        Console.WriteLine("3 i:" + i.ToString() + " j:" + j.ToString() + " deg:" + (list[i].transitAspects[j].target_position - startDegree).ToString());
#endif
                    }

                }
            }
            g.Dispose();
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
