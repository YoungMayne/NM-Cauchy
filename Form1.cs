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

namespace Couchy
{
    public partial class MainForm : Form
    {
        private Random random;
        private GraphPane pane;
        private double a;
        private double b;
        private uint N;

        public MainForm()
        {
            InitializeComponent();

            pane = MainGraph.GraphPane;
            random = new Random();

            pane.Title = "";
            pane.XAxis.Title = "x";
            pane.YAxis.Title = "F(x)";

            NTextBox.Text = "1000";
            aTextBox.Text = "0";
            bTextBox.Text = "1";
        }

        private double Function(double x) 
        {
            return Math.Sin(x) * Math.Exp(2 * x);
        } 

        private double FindMaximum()
        {
            double max = Function(a);
            double temp;

            for (double i = a + (b - a) / N; i < b; i += (b - a) / N)
            {
                temp = Function(i);

                if(temp > max && !double.IsInfinity(temp))
                {
                    max = temp;
                }
            }

            return max;
        }

        private double FindMinimum()
        {
            double min = Function(a);
            double temp;

            for (double i = a + (b - a) / N; i < b; i += (b - a) / N)
            {
                temp = Function(i);

                if (temp < min && !double.IsInfinity(temp))
                {
                    min = temp;
                }
            }

            return min;
        }

        private double MK1()
        {
            double result = 0.0;
            double random_number;

            for(uint i = 0; i < N; ++i)
            {
                random_number = a + random.NextDouble() * (b - a);
                result += Function(random_number);
            }

            return ((b - a) / (double)N) * result;
        }

        private double MK2()
        {
            double x;
            double y;
            double d = FindMaximum();
            double c = FindMinimum();
            double function_result;

            uint k = 0;

            for(uint i = 0; i < N; ++i)
            {
                x = a + random.NextDouble() * (b - a);
                y = c + random.NextDouble() * (d - c);

                function_result = Function(x);

                if(0 > function_result)
                {
                    if(0 > y && function_result <= y)
                    {
                        ++k;
                    }
                }
                else
                {
                    if(0 <= y && function_result >= y)
                    {
                        ++k;
                    }
                }
            }

            return ((b - a) * k * (d - c) / N) - ((b - a) * (0 - c));
        }

        private double NM()
        {
            double width;
            double height;

            double result = 0.0;

            for (double i = a + (b - a) / N; i < b; i += (b - a) / N)
            {
                width = (b - a) / N;
                height = Function(i);

                result += width * height;
            }

            return result;
        }

        private void DrawFunction()
        {
            PointPairList pairList = new PointPairList();
            PointPair pair = new PointPair();

            for (double x = a; x < b; x += (b - a) / N)
            {
                pair.X = x;
                pair.Y = Function(x);

                pairList.Add(pair);
            }

            pane.AddCurve("Function", pairList, Color.Black, SymbolType.None);

            MainGraph.Hide();
            MainGraph.AxisChange();
            MainGraph.Show();
        }

        private void DrawIntegral()
        {
            PointPairList pairListHit = new PointPairList();
            PointPairList pairListNoHit = new PointPairList();

            double function_result;
            double d = FindMaximum();
            double c = FindMinimum();
            double x;
            double y;

            for (uint i = 0; i < N; ++i)
            {
                x = a + random.NextDouble() * (b - a);
                y = c + random.NextDouble() * (d - c);

                function_result = Function(x);

                if (0 > function_result)
                {
                    if (0 > y && function_result <= y)
                    {
                        pairListHit.Add(new PointPair(x, y));
                    }
                    else
                    {
                        pairListNoHit.Add(new PointPair(x, y));
                    }
                }
                else
                {
                    if (0 <= y && function_result >= y)
                    {
                        pairListHit.Add(new PointPair(x, y));
                    }
                    else
                    {
                        pairListNoHit.Add(new PointPair(x, y));
                    }
                }
            }


            LineItem hitCurve = pane.AddCurve("Hit", pairListHit, Color.Green, SymbolType.Plus);

            hitCurve.Line.IsVisible = false;

            LineItem noHitCurve = pane.AddCurve("Not hit", pairListNoHit, Color.Red, SymbolType.Circle);

            noHitCurve.Line.IsVisible = false;

            MainGraph.Hide();
            MainGraph.AxisChange();
            MainGraph.Show();
        }

        private bool CheckInput()
        {
            bool result;

            result = double.TryParse(aTextBox.Text, out a);

            if(false == result)
            {
                return false;
            }

            result = double.TryParse(bTextBox.Text, out b);

            if (false == result)
            {
                return false;
            }

            result = uint.TryParse(NTextBox.Text, out N);

            if (false == result)
            {
                return false;
            }

            return true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(false == CheckInput())
            {
                MessageBox.Show("Input error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pane.CurveList.Clear();

            MK1Label.Text = MK1().ToString();

            if(15 < MK1Label.Text.Length)
            {
                MK1Label.Text = MK1Label.Text.Substring(0, 15);
            }
             
            MK2Label.Text = MK2().ToString();

            if (15 < MK2Label.Text.Length)
            {
                MK2Label.Text = MK2Label.Text.Substring(0, 15);
            }

            NMLabel.Text = NM().ToString();

            if (15 < NMLabel.Text.Length)
            {
                NMLabel.Text = NMLabel.Text.Substring(0, 15);
            }

            DrawFunction();
            DrawIntegral();            
        }
    }
}
