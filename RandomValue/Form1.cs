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
        private Random random;
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
            nUpDown.Maximum = 10000000000000000;
            random = new Random();
        }

        private double Function(double x)
        {
            if ((ax <= x) && (bx >= x))
            {
                return (3.0 / 8.8) * ((Math.Pow(x, 3) + 1) / 3.0 + Math.Pow(x, 2) + x);
            }
            else
            {
                return 0.0;
            }
        }        

        private double InverseFunction(double r)
        {
            return (2.0 * Math.Pow(r, 1.0 / 3.0)) - 1;
        }

        private List<Tuple<double, double>> GetInitialized()
        {
            List<Tuple<double, double>> result = new List<Tuple<double, double>>();
            double random_value;
            double function_value;

            for(uint i = 0u; i < n; ++i)
            {
                random_value = random.NextDouble();
                function_value = InverseFunction(random_value);
                result.Add(new Tuple<double, double>(function_value, Function(function_value)));
            }

            return result;
        }

        private double SampleRangeValue(List<Tuple<double, double>> sorted)
        {
            if (0 < sorted.Count)
            {
                return sorted[sorted.Count - 1].Item1 - sorted[0].Item1;
            }

            return 0.0;
        }

        private double StatisticalExpectation(List<Tuple<double, double>> list)
        {
            double result = 0.0;

            for (int i = 0; i < list.Count; ++i)
            {
                result += list[i].Item1;
            }

            return result / n;
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
                return sorted[sorted.Count / 2].Item1;
            }
            else
            {
                return (sorted[(sorted.Count / 2) - 1].Item1 +
                        sorted[(sorted.Count / 2) + 0].Item1) /
                        2;
            }
        }

        private double GetKolmogorovState(List<Tuple<double, double>> sorted)
        {
            List<double> emp = new List<double>();
            double result = 0.0;

            for(double i = 0.0; i < n; ++i)
            {
                emp.Add(i / n);
            }

            if(1 < n)
            {
                if(Math.Abs(sorted[1].Item2) > result)
                {
                    result = Math.Abs(sorted[1].Item2);
                }
                else if (1 == n)
                {
                    if (Math.Abs(sorted[0].Item2 - emp[0]) > result)
                    {
                        result = Math.Abs(sorted[0].Item2 - emp[0]);
                    }

                    if(Math.Abs(1 - sorted[0].Item2) > result)
                    {
                        result = Math.Abs(1 - sorted[0].Item2);
                    }
                }
            }

            for(int i = 0; i < n - 1; ++i)
            {
                if(Math.Abs(emp[i] - sorted[i].Item2) > result)
                {
                    result = Math.Abs(emp[i] - sorted[i].Item2);
                }

                if(Math.Abs(emp[i + 1] - sorted[i].Item2) > result)
                {
                    result = Math.Abs(emp[i + 1] - sorted[i].Item2);
                }
            }

            if (Math.Abs(emp[(int)n - 1] - sorted[(int)n - 1].Item2) > result)
            {
                result = Math.Abs(emp[(int)n - 1] - sorted[(int)n - 1].Item2);
            }

            if (Math.Abs(1 - sorted[(int)n - 1].Item2) > result)
            {
                result = Math.Abs(1 - sorted[(int)n - 1].Item2);
            }

            return result * Math.Sqrt(n);
        }

        private double StatisticalDispersion(List<Tuple<double, double>> list)
        {
            double expectation = StatisticalExpectation(list);
            double result = 0.0;

            for (int i = 0; i < list.Count; ++i)
            {
                result += Math.Pow((list[i].Item1 - expectation), 2.0);
            }

            return result / n;
        }


        private void Draw(List<Tuple<double, double>> list)
        {
            PointPairList theoretical = new PointPairList();
            PointPairList emperical   = new PointPairList();
            GraphPane pane            = Graph.GraphPane;
            double step               = (bx - ax) / n;

            for(double a = ax; a <= bx; a += (bx - ax) / n)
            {
                theoretical.Add(new PointPair(a, Function(a)));                
            }

            for(int i = 1; i < n; ++i)
            {
                emperical.Add(new PointPair(list[i].Item1, (double)i / n ));
                emperical.Add(new PointPair(list[i - 1].Item1, (double)i / n));
            }

            pane.CurveList.Clear();

            pane.AddCurve("Интегральная функция", theoretical, Color.Blue, SymbolType.None);
            pane.AddCurve("Эмперическая функция", emperical, Color.Red, SymbolType.None);

            Graph.Refresh();
            Graph.AxisChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (uint)nUpDown.Value;

            var a = GetInitialized();

            Sort(a);

            SampleRangeValueLabel.Text = SampleRangeValue(a).ToString();
            ExpectationLabel.Text = StatisticalExpectation(a).ToString();
            DispersionLabel.Text = StatisticalDispersion(a).ToString();
            FacionLabel.Text = FashionNumber(a).Item2.ToString();
            MedianLabel.Text = Median(a).ToString();
            KolmogorovStateLabel.Text = GetKolmogorovState(a).ToString();

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
            return x.Item1.CompareTo(y.Item1);
        }
    }
}
