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

            NTextBox.Text     = "100";
            stepsTextBox.Text = "3";
            axTextBox.Text    = "-1";
            bxTextBox.Text    = "0";
            ayTextBox.Text    = "0";
            byTextBox.Text    = "2";
            azTextBox.Text    = "0";
            bzTextBox.Text    = "1";
        }

        private double Function(double x, double y, double z)
        {
            return 8 * y * y * z * Math.Exp(2 * x * y * z);
        }

        private void FindMinMax(out double min, out double max)
        {
            double xStep = (bx - ax) / Math.Pow(N, 1.0 / 3.0);
            double yStep = (by - ay) / Math.Pow(N, 1.0 / 3.0);
            double zStep = (bz - az) / Math.Pow(N, 1.0 / 3.0);
            double temp;

            min = Function(ax, ay, az);
            max = Function(ax, ay, az);

            for (double x = ax + xStep; x < bx; x += xStep)
            {
                for (double y = ay + yStep; y < by; y += yStep)
                {
                    for (double z = az + zStep; z < bz; z += zStep)
                    {
                        temp = Function(x, y, z);

                        if (temp > max)
                        {
                            max = temp;
                        }

                        if(temp < min)
                        {
                            min = temp;
                        }
                    }
                }
            }
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

            double volume = (bx - ax) * (by - ay) * (bz - az);

            return (volume / (double)N) * result;
        }

        private double MK2()
        {
            double x;
            double y;
            double z;
            double d;
            double c;

            double random_result;
            double function_result;

            uint k = 0u;

            FindMinMax(out c, out d);

            for(uint i = 0; i < N; ++i)
            {
                x = ax + random.NextDouble() * (bx - ax);
                y = ay + random.NextDouble() * (by - ay);
                z = az + random.NextDouble() * (bz - az);
                random_result = c + random.NextDouble() * (d - c);

                function_result = Function(x, y, z);

                if(Math.Abs(function_result) >= random_result)
                {
                    ++k;
                }
            }

            double volume = (bx - ax) * (by - ay) * (bz - az);

            return (volume * k * (d - c) / N) - (volume * (0.0 - c));
        }

        private double NM()
        {
            double x;
            double y;
            double z;

            double n = Math.Pow(N, 1.0 / 3.0);

            double hx = (bx - ax) / n;
            double hy = (by - ay) / n;
            double hz = (bz - az) / n;

            double ahx = ax + hx / 2.0;
            double ahy = ay + hy / 2.0;
            double ahz = az + hz / 2.0;            

            double result = 0.0;

            for(uint ix = 0; ix < n + 0.5; ++ix)
            {
                for(uint iy = 0; iy < n + 0.5; ++iy)
                {
                    for(uint iz = 0; iz < n + 0.5; ++iz)
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

            double nm_avg  = 0.0;
            double mk1_avg = 0.0;
            double mk2_avg = 0.0;

            CalculateButton.Hide();

            for(uint i = 0u; i < S; ++i)
            {
                nm_result  = NM();
                mk1_result = MK1();
                mk2_result = MK2();

                rows.Add(N, nm_result, mk1_result, mk2_result);

                N *= 10;

                nm_avg  += nm_result;
                mk1_avg += mk1_result;
                mk2_avg += mk2_result;
            }

            // Fill averages
            rows.Add();
            rows.Add();
            rows[rows.Count - 1].Cells[1].Value = nm_avg  / S;
            rows[rows.Count - 1].Cells[2].Value = mk1_avg / S;
            rows[rows.Count - 1].Cells[3].Value = mk2_avg / S;


            CalculateButton.Show();
        }
    }
}
