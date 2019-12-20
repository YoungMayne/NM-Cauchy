using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace RandomValue
{
    public partial class Form1 : Form
    {
        private const double ax = -1;
        private const double bx = 1;
        private uint n = 5;

        public Form1()
        {
            InitializeComponent();

            Table.RowHeadersVisible = false;
            nUpDown.Value = 10;
            Graph.GraphPane.YAxis.Min = -1;
            Graph.GraphPane.XAxis.Min = -1.2;
            Graph.GraphPane.YAxis.Max = 1;
        }

        private double Function(double x, double y, double z)
        {
            if ((ax <= x) && (bx >= x))
            {
                return 3.0 / 8.0 * ((x * x) + (2.0 * x) + 1);
            }
            else
            {
                return 0.0;
            }
        }

        private List<Tuple<double, double>> Discrete()
        {
            List<Tuple<double, double>> result = new List<Tuple<double, double>>();

            double H = 0;
            for (double ix = ax; ix <= bx; ix += (bx - ax) / (n - 1))
            {
                H += Function(ix, 0, 0);
            }

            for (double ix = ax; ix <= bx; ix += (bx - ax) / (n - 1))
            {
                result.Add(new Tuple<double, double>(ix, Function(ix, 0, 0) / H));
            }

            return result;
        }

        private double SampleRangeValue(List<Tuple<double, double>> sorted)
        {
            if (0 < sorted.Count)
            {
                return sorted[sorted.Count - 1].Item2 - sorted[0].Item2;
            }

            return 0.0;
        }

        private double StatisticalExpectation(List<Tuple<double, double>> list)
        {
            double result = 0.0;

            for (int i = 0; i < list.Count; ++i)
            {
                result += list[i].Item1 * list[i].Item2;
            }

            return 1.0 / n * result;
        }

        private void Sort(List<Tuple<double, double>> list)
        {
            GFG gg = new GFG();
            list.Sort(gg);
        }

        private Tuple<int, double> FashionNumber(List<Tuple<double, double>> sorted)
        {
            double currentNumber = sorted[0].Item2;
            double mostFrequentNumber = sorted[0].Item2;
            int biggestCount = 1;
            int currentCount = 1;

            for (int i = 1; i < sorted.Count; ++i)
            {
                if (sorted[i].Item2 != currentNumber)
                {
                    if (currentCount > biggestCount)
                    {
                        biggestCount = currentCount;
                        mostFrequentNumber = currentNumber;
                    }

                    currentNumber = sorted[i].Item2;
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }
            }

            if (currentCount > biggestCount)
            {
                biggestCount = currentCount;
                mostFrequentNumber = currentNumber;
            }

            return new Tuple<int, double>(biggestCount, mostFrequentNumber);
        }

        private double Median(List<Tuple<double, double>> sorted)
        {
            if (sorted.Count % 2 == 1)
            {
                return sorted[sorted.Count / 2].Item2;
            }
            else
            {
                return (sorted[(sorted.Count / 2) - 1].Item2 +
                        sorted[(sorted.Count / 2) + 0].Item2) /
                        2;
            }
        }

        private double StatisticalDispersion(List<Tuple<double, double>> list)
        {
            double a = 0;
            double b = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                a += Math.Pow(list[i].Item1, 2) * list[i].Item2;
                b += list[i].Item1 * list[i].Item2;
            }

            return a - b * b;
        }


        private void Draw(List<Tuple<double, double>> list)
        {
            PointPairList theoretical = new PointPairList();
            PointPairList emperical   = new PointPairList();
            GraphPane pane            = Graph.GraphPane;

            LineItem line = new LineItem("Эмпирическая функция", new[] { list[0].Item1 - 1, list[0].Item1 },
                                         new[] { 0.0, 0.0 },
                                         Color.Red, SymbolType.None);

            pane.CurveList.Clear();
            pane.CurveList.Add(new LineItem(line));

            for (int i = 1; i < list.Count; ++i)
            {
                line = new LineItem(String.Empty, new[] { list[i].Item1, list[i - 1].Item1 },
                                                            new[] { list[i].Item2, list[i].Item2 },
                                                            Color.Red, SymbolType.None);

                pane.CurveList.Add(new LineItem(line));
            }

            for (int i = 0; i < list.Count; ++i)
            {
                theoretical.Add(new PointPair(list[i].Item1, list[i].Item2));
            }

            pane.AddCurve("Теоретическая функция", theoretical, Color.Blue, SymbolType.None);

            Graph.AxisChange();
            Graph.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (uint)nUpDown.Value;

            var a = Discrete();

            Sort(a);

            SampleRangeValueLabel.Text = SampleRangeValue(a).ToString();
            ExpectationLabel.Text = StatisticalExpectation(a).ToString();
            DispersionLabel.Text = StatisticalDispersion(a).ToString();
            FacionLabel.Text = FashionNumber(a).Item2.ToString();
            MedianLabel.Text = Median(a).ToString();

            Table.Rows.Clear();
            for (int i = 0; i < a.Count; ++i)
            {
                Table.Rows.Add();
                Table.Rows[i].Cells[0].Value = i + 1;
                Table.Rows[i].Cells[1].Value = a[i].Item1;
                Table.Rows[i].Cells[2].Value = a[i].Item2;
            }

            Draw(a);
        }
    }

    class GFG : IComparer<Tuple<double, double>>
    {
        public int Compare(Tuple<double, double> x, Tuple<double, double> y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.Item2.CompareTo(y.Item2);
        }
    }
}
