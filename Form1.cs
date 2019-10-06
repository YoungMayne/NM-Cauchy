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
		private GraphPane pane;
		private GraphPane pane0;
		private GraphPane pane1;

		private double alpha;
		private double beta;
		private double minX;
		private double maxX;
		private double step;
		private double eps;
		private double v;
		private double v_;

		public MainForm()
		{
			InitializeComponent();

			pane = Graph1.GraphPane;
			pane0 = Graph0.GraphPane;
			pane1 = Graph2.GraphPane;

			TextMaxX.Text = "0.0";
			TextMaxX0.Text = "0.0";
			TextMaxX1.Text = "0.0";

			TextStep.Text = "0.0";
			TextStep0.Text = "0.0";
			TextStep1.Text = "0.0";

			TextUo.Text   = "0.0";
			TextUo0.Text = "0.0";
			TextUo1.Text = "0.0";
			TextUoo.Text = "0.0";

			TextEpsilon.Text = "0.0";
			TextEpsilon0.Text = "0.0";
			TextEpsilon1.Text = "0.0";

			TextAlpha.Text = "0.0";
			TextBeta.Text = "0.0";

			Check.Checked = false;
			Check0.Checked = false;
			Check1.Checked = false;

			minX = 0;

			Check_CheckedChanged(Check, null);
			Check0_CheckedChanged(Check0, null);
			Check1_CheckedChanged(Check1, null);
		}


		private void Draw()
		{
			if(step == 0.0)
			{
				return;
			}

			pane.CurveList.Clear();

			if (Check.Checked && eps > 0.0)
			{
				pane.AddCurve("Решение", Control(), Color.Purple, SymbolType.None);
			}
			else 
			{
				pane.AddCurve("Решение", NoControl(), Color.Purple, SymbolType.None);
			}

			Graph1.Hide();
			Graph1.AxisChange();
			Graph1.Show();
		}


		private void Draw0()
		{
			if (step == 0.0)
			{
				return;
			}

			pane0.CurveList.Clear();

			if (Check0.Checked && eps > 0.0)
			{
				pane0.AddCurve("Решение", Control0(), Color.Purple, SymbolType.None);
			}
			else
			{
				pane0.AddCurve("Решение", NoControl0(), Color.Purple, SymbolType.None);
			}

			Graph0.Hide();
			Graph0.AxisChange();
			Graph0.Show();
		}


		private void Draw1()
		{
			if (step == 0.0)
			{
				return;
			}

			pane1.CurveList.Clear();

			if(Check1.Checked && eps > 0.0)
			{
				pane1.AddCurve("Решение", Control1(), Color.Purple, SymbolType.None);
			}
			else
			{
				pane1.AddCurve("Решение", NoControl1(), Color.Purple, SymbolType.None);
			}

			Graph2.Hide();
			Graph2.AxisChange();
			Graph2.Show();
		}


		private PointPairList Control()
		{
			PointPairList list = new PointPairList();
			List<List<double>> table = new List<List<double>>();

			double exactV;
			double V0 = v;
			double V1 = v;
			double currentStep = step;
			double lte;

			int index = 0;
			int C1 = 0;
			int C2 = 0;


			for(double x = minX; x < maxX; x += currentStep)
			{
				V0 = V1;

				V1     = Method(x, V0, currentStep);
				exactV = Method(x, V0, currentStep / 2);
				exactV = Method(x + currentStep / 2, exactV, currentStep / 2);

				double S = (exactV - V1) / (Math.Pow(2, 5) - 1);
				lte = S * Math.Pow(2, 4);

				if(Math.Abs(S) > eps)
				{
					x -= currentStep;
					currentStep /= 2;
					V1 = V0;
					C1++;

					continue;
				}
				else if(Math.Abs(S) <= (eps / (Math.Pow(2, 5))))
				{
					currentStep *= 2;
					C2++;
				}

				PointPair pair = new PointPair(x, V1);
				list.Add(pair);
				table.Add(new List<double>(11) { index, x, V1, exactV, V1 - exactV, lte, currentStep, C1, C2, 0, 0});

				index++;
			}

			CreateTable(table);

			return list;
		}


		private PointPairList Control0()
		{
			PointPairList list = new PointPairList();
			List<List<double>> table = new List<List<double>>();

			double exactV;
			double V0 = v;
			double V1 = v;
			double currentStep = step;
			double lte;

			int index = 0;
			int C1 = 0;
			int C2 = 0;


			for (double x = minX; x < maxX; x += currentStep)
			{
				V0 = V1;

				V1 = Method0(x, V0, currentStep);
				exactV = Method0(x, V0, currentStep / 2);
				exactV = Method0(x + currentStep / 2, exactV, currentStep / 2);

				double S = (exactV - V1) / (Math.Pow(2, 5) - 1);
				lte = S * Math.Pow(2, 4);

				if (Math.Abs(S) > eps)
				{
					x -= currentStep;
					currentStep /= 2;
					V1 = V0;
					C1++;

					continue;
				}
				else if (Math.Abs(S) <= (eps / (Math.Pow(2, 5))))
				{
					currentStep *= 2;
					C2++;
				}

				PointPair pair = new PointPair(x, V1);
				list.Add(pair);
				table.Add(new List<double>(11) { index, x, V1, exactV, V1 - exactV, lte, currentStep, C1, C2, 0, 0 });

				index++;
			}

			CreateTable0(table);

			return list;
		}


		private PointPairList Control1()
		{
			PointPairList list = new PointPairList();

			double exactV;
			double V0 = v;
			double V1 = v;
			double currentStep = step;
			double lte;

			for (double x = minX; x < maxX; x += currentStep)
			{
				V0 = V1;

				V1 = Method1(x, V0, currentStep);
				exactV = Method1(x, V0, currentStep / 2);
				exactV = Method1(x + currentStep / 2, exactV, currentStep / 2);

				double S = (exactV - V1) / (Math.Pow(2, 5) - 1);
				lte = S * Math.Pow(2, 4);

				if (Math.Abs(S) > eps)
				{
					x -= currentStep;
					currentStep /= 2;
					V1 = V0;

					continue;
				}
				else if (Math.Abs(S) <= (eps / (Math.Pow(2, 5))))
				{
					currentStep *= 2;
				}

				PointPair pair = new PointPair(x, V1);
				list.Add(pair);
			}

			return list;
		}


		private PointPairList NoControl()
		{
			PointPairList list = new PointPairList();
			List<List<double>> table = new List<List<double>>();

			double startV = v;
			double exactV = v;
			double lte;

			int index = 0;

			for (double x = minX; x < maxX; x += step)
			{
				PointPair pair = new PointPair(x, startV);
				list.Add(pair);

				startV = Method(x, startV, step);

				exactV = Method(x, exactV, step / 2);
				exactV = Method(x + step / 2, exactV, step / 2);

				lte = ((exactV - startV) / Math.Pow(2, 5) - 1) * Math.Pow(2, 4);

				table.Add(new List<double>(11) { index, x, startV, exactV, startV - exactV, lte, step, 0, 0, 0, 0 });

				index++;
			}

			CreateTable(table);

			return list;
		}


		private PointPairList NoControl0()
		{
			PointPairList list = new PointPairList();
			List<List<double>> table = new List<List<double>>();

			double startV = v;
			double exactV = v;
			double lte;

			int index = 0;

			for (double x = minX; x < maxX; x += step)
			{
				PointPair pair = new PointPair(x, startV);
				list.Add(pair);

				startV = Method0(x, startV, step);

				exactV = Method0(x, exactV, step / 2);
				exactV = Method0(x + step / 2, exactV, step / 2);

				lte = ((exactV - startV) / Math.Pow(2, 5) - 1) * Math.Pow(2, 4);

				table.Add(new List<double>(11) { index, x, startV, exactV, startV - exactV, lte, step, 0, 0, 0, 0 });

				index++;
			}

			CreateTable0(table);

			return list;
		}


		private PointPairList NoControl1()
		{
			PointPairList list = new PointPairList();

			double startV = v;

			for (double x = minX; x < maxX; x += step)
			{
				PointPair pair = new PointPair(x, startV);
				list.Add(pair);

				startV = Method1(x, startV, step);
			}

			return list;
		}


		private double Function(double x, double v)
		{
			double f = 1.0 / (1.0 + Math.Pow(x, 4));

			return f * Math.Pow(v, 2) + v - Math.Pow(v, 3) * Math.Sin(10 * v);
		}


		private double Function0(double x, double v)
		{
			double n = 1.0;

			return Math.Pow(-1.0, n) * (n / 2.0) * v;
		}

		
		private double Function1(double x, double v)
		{
			double g = alpha * Math.Pow(v_, 2) + beta * v;

			return -g;
		}


		private double Method(double x, double v, double s)
		{
			//RK 4
			double k1 = Function(x, v);
			double k2 = Function(x + s / 2, v + s / 2 * k1);
			double k3 = Function(x + s / 2, v + s / 2 * k2);
			double k4 = Function(x + s, v + s * k3);

			return v + s / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
		}


		private double Method0(double x, double v, double s)
		{
			//RK 4
			double k1 = Function0(x, v);
			double k2 = Function0(x + s / 2, v + s / 2 * k1);
			double k3 = Function0(x + s / 2, v + s / 2 * k2);
			double k4 = Function0(x + s, v + s * k3);

			return v + s / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
		}


		private double Method1(double x, double v, double s)
		{
			//RK 4
			double k1 = Function1(x, v);
			double k2 = Function1(x + s / 2, v + s / 2 * k1);
			double k3 = Function1(x + s / 2, v + s / 2 * k2);
			double k4 = Function1(x + s, v + s * k3);

			return v + s / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
		}


		private double ExtractNumber(TextBox box)
		{
			bool isFloating = false;

			for (int i = 0; i < box.Text.Length; ++i)
			{
				if (!char.IsDigit(box.Text[i]))
				{
					if (box.Text[i] == '.' && i > 0 && !isFloating)
					{
						isFloating = true;
						continue;
					}

					box.Text = box.Text.Remove(i--, 1);
				}
			}

			return box.Text.Length == 0 ? 0.0 : double.Parse(box.Text);
		}


		private void CreateTable(List<List<double>> table)
		{
			DataGridViewRowCollection rows = Table.Rows;

			rows.Clear();
			for(int i = 0; i < table.Count; ++i)
			{
				rows.Add();

				for(int j = 0; j < table[i].Count; ++j)
				{
					rows[i].Cells[j].Value = table[i][j];
				}
			}
		}


		private void CreateTable0(List<List<double>> table)
		{
			DataGridViewRowCollection rows = Table0.Rows;

			rows.Clear();
			for (int i = 0; i < table.Count; ++i)
			{
				rows.Add();

				for (int j = 0; j < table[i].Count; ++j)
				{
					rows[i].Cells[j].Value = table[i][j];
				}
			}
		}


		private void TextMaxX_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			maxX = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw();
		}


		private void TextMaxX0_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			maxX = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw0();
		}


		private void TextMaxX1_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			maxX = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void TextStep_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			step = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw();
		}


		private void TextStep0_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			step = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw0();
		}


		private void TextStep1_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			step = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void TextUo_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			v = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw0();
		}


		private void TextUo1_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			v = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void TextUoo_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			v_ = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void Check_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox box = (CheckBox)sender;

			LabelEpsilon.Visible = box.Checked;
			TextEpsilon.Visible = box.Checked;

			step = ExtractNumber(TextStep);

			Draw();
		}


		private void Check0_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox box = (CheckBox)sender;

			LabelEpsilon0.Visible = box.Checked;
			TextEpsilon0.Visible = box.Checked;

			step = ExtractNumber(TextStep0);

			Draw0();
		}


		private void Check1_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox box = (CheckBox)sender;

			LabelEpsilon1.Visible = box.Checked;
			TextEpsilon1.Visible = box.Checked;

			step = ExtractNumber(TextStep1);

			Draw1();
		}


		private void TextUo0_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			v = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw0();
		}


		private void TextEpsilon_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			eps = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw();
		}


		private void TextEpsilon0_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			eps = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw0();
		}


		private void TextEpsilon1_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			eps = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void TextAlpha_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			alpha = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void TextBeta_TextChanged(object sender, EventArgs e)
		{
			TextBox box = (TextBox)sender;

			beta = ExtractNumber(box);

			box.SelectionStart = box.Text.Length;
			box.SelectionLength = 0;

			Draw1();
		}


		private void Page1_Click(object sender, EventArgs e)
		{
			TextMaxX0_TextChanged(TextMaxX, null);
			TextStep0_TextChanged(TextStep, null);
			TextUo0_TextChanged(TextUo, null);
			TextEpsilon0_TextChanged(TextEpsilon, null);

			Draw0();
		}


		private void Page2_Click(object sender, EventArgs e)
		{
			TextMaxX_TextChanged(TextMaxX, null);
			TextStep_TextChanged(TextStep, null);
			TextUo_TextChanged(TextUo, null);
			TextEpsilon_TextChanged(TextEpsilon, null);

			Draw();
		}


		private void Page3_Click(object sender, EventArgs e)
		{
			TextMaxX1_TextChanged(TextMaxX, null);
			TextStep1_TextChanged(TextStep, null);
			TextUo1_TextChanged(TextUo, null);
			TextUoo_TextChanged(TextUoo, null);
			TextAlpha_TextChanged(TextAlpha, null);
			TextBeta_TextChanged(TextBeta, null);
			TextEpsilon1_TextChanged(TextEpsilon, null);

			Draw1();
		}
	}
}
