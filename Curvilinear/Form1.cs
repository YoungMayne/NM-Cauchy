using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Curvilinear
{
    public partial class MainForm : Form
    {
        private Random random;

        private double a;
        private double b;

        private double ax;
        private double bx;

        private double ay;
        private double by;

        private double az;
        private double bz;

        private uint N;
        private uint S;

        public MainForm()
        {
            InitializeComponent();

            random = new Random();

            NTextBox.Text = "100";
            stepsTextBox.Text = "3";
            aTextBox.Text = "0";
            bTextBox.Text = "2";
            axTextBox.Text = "-1";
            bxTextBox.Text = "0";
            ayTextBox.Text = "0";
            byTextBox.Text = "2";
            azTextBox.Text = "0";
            bzTextBox.Text = "1";
        }

        private double Function(double x, double y, double z)
        {
            return 8 * y * y * z * Math.Exp(2 * x * y * z);
        }

        private double FindMaximum()
        {
            double max = Function(ax, ay, az);
            double temp;

            for(double x = ax + (bx - ax) / N; x < bx; x += (bx - ax) / N)
            {
                for (double y = ay + (by - ay) / N; y < by; y += (by - ay) / N)
                {
                    for (double z = az + (bz - az) / N; z < bz; z += (bz - az) / N)
                    {
                        temp = Function(x, y, z);

                        if(temp > max)
                        {
                            max = temp;
                        }
                    }
                }
            }

            return max;
        }

        private double FindMinimum()
        {
            double min = Function(ax, ay, az);
            double temp;

            for (double x = ax + (bx - ax) / N; x < bx; x += (bx - ax) / N)
            {
                for (double y = ay + (by - ay) / N; y < by; y += (by - ay) / N)
                {
                    for (double z = az + (bz - az) / N; z < bz; z += (bz - az) / N)
                    {
                        temp = Function(x, y, z);

                        if (temp < min)
                        {
                            min = temp;
                        }
                    }
                }
            }

            return min;
        }

        private double MK1()
        {
            double x;
            double y;
            double z;
            double result = 0.0;

            for(uint i = 0; i < N; ++i)
            {
                x = ax + random.NextDouble() * (bx - ax);
                y = ay + random.NextDouble() * (by - ay);
                z = az + random.NextDouble() * (bz - az);

                result += Function(x, y, z);
            }

            return ((b - a) / (double)N) * result;
        }

        private double MK2()
        {
            double d = FindMaximum();
            double c = FindMinimum();

            uint k = 0u;

            for(uint i = 0; i < N; ++i)
            {
                double x = ax + random.NextDouble() * (bx - ax);
                double y = ay + random.NextDouble() * (by - ay);
                double z = az + random.NextDouble() * (bz - az);
                double random_result = c + random.NextDouble() * (d - c);

                double function_result = Function(x, y, z);

                if (0 > function_result)
                {
                    if (0 > random_result && function_result <= random_result)
                    {
                        ++k;
                    }
                }
                else
                {
                    if (0 <= random_result && function_result >= random_result)
                    {
                        ++k;
                    }
                }
            }

            return ((b - a) * k * (d - c) / N) - ((b - a) * (0 - c));
        }

        private double NM()
        {
            double x;
            double y;
            double z;

            double hx = (bx - ax) / N;
            double hy = (by - ay) / N;
            double hz = (bz - az) / N;

            double ahx = ax + hx / 2;
            double ahy = ay + hy / 2;
            double ahz = az + hz / 2;

            double result = 0.0;

            for(uint ix = 0; ix < N; ++ix)
            {
                for(uint iy = 0; iy < N; ++iy)
                {
                    for(uint iz = 0; iz < N; ++iz)
                    {
                        x = ahx + ix * hx;
                        y = ahy + iy * hy;
                        z = ahz + iz * hz;

                        result += hx * hy * hz * Function(x, y, z);
                    }
                }
            }

            return result;
        }

        private bool CheckInput()
        {
            if(true != uint.TryParse(NTextBox.Text, out N))
            {
                return false;
            }

            if (true != uint.TryParse(stepsTextBox.Text, out S))
            {
                return false;
            }

            if (true != double.TryParse(aTextBox.Text, out a))
            {
                return false;
            }

            if (true != double.TryParse(bTextBox.Text, out b))
            {
                return false;
            }

            if (true != double.TryParse(axTextBox.Text, out ax))
            {
                return false;
            }

            if (true != double.TryParse(bxTextBox.Text, out bx))
            {
                return false;
            }

            if (true != double.TryParse(ayTextBox.Text, out ay))
            {
                return false;
            }

            if (true != double.TryParse(byTextBox.Text, out by))
            {
                return false;
            }

            if (true != double.TryParse(azTextBox.Text, out az))
            {
                return false;
            }

            if (true != double.TryParse(bzTextBox.Text, out bz))
            {
                return false;
            }

            return true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(false == CheckInput())
            {
                MessageBox.Show("Input error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRowCollection rows = Table.Rows;
            rows.Clear();

            double nm_result;
            double mk1_result;
            double mk2_result;

            for(uint i = 0u; i < S; ++i)
            {
                nm_result = NM();
                mk1_result = MK1();
                mk2_result = MK2();

                rows.Add(N, nm_result, mk1_result, mk2_result);

                N *= 10;
            }
        }
    }
}
