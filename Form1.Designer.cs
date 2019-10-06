namespace Couchy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TabControl = new System.Windows.Forms.TabControl();
			this.Page1 = new System.Windows.Forms.TabPage();
			this.Page2 = new System.Windows.Forms.TabPage();
			this.TextEpsilon = new System.Windows.Forms.TextBox();
			this.LabelEpsilon = new System.Windows.Forms.Label();
			this.Check = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TextUo = new System.Windows.Forms.TextBox();
			this.Uo = new System.Windows.Forms.Label();
			this.TextStep = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TextMaxX = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Graph1 = new ZedGraph.ZedGraphControl();
			this.Page3 = new System.Windows.Forms.TabPage();
			this.TextBeta = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.TextAlpha = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.TextEpsilon1 = new System.Windows.Forms.TextBox();
			this.LabelEpsilon1 = new System.Windows.Forms.Label();
			this.Check1 = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.TextUoo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TextUo1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TextStep1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TextMaxX1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Graph2 = new ZedGraph.ZedGraphControl();
			this.TabControl.SuspendLayout();
			this.Page2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Page3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.Page1);
			this.TabControl.Controls.Add(this.Page2);
			this.TabControl.Controls.Add(this.Page3);
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(963, 551);
			this.TabControl.TabIndex = 0;
			// 
			// Page1
			// 
			this.Page1.Location = new System.Drawing.Point(4, 22);
			this.Page1.Name = "Page1";
			this.Page1.Padding = new System.Windows.Forms.Padding(3);
			this.Page1.Size = new System.Drawing.Size(955, 525);
			this.Page1.TabIndex = 0;
			this.Page1.Text = "Тестовая задача";
			this.Page1.UseVisualStyleBackColor = true;
			// 
			// Page2
			// 
			this.Page2.Controls.Add(this.TextEpsilon);
			this.Page2.Controls.Add(this.LabelEpsilon);
			this.Page2.Controls.Add(this.Check);
			this.Page2.Controls.Add(this.label4);
			this.Page2.Controls.Add(this.TextUo);
			this.Page2.Controls.Add(this.Uo);
			this.Page2.Controls.Add(this.TextStep);
			this.Page2.Controls.Add(this.label3);
			this.Page2.Controls.Add(this.label2);
			this.Page2.Controls.Add(this.TextMaxX);
			this.Page2.Controls.Add(this.label1);
			this.Page2.Controls.Add(this.pictureBox1);
			this.Page2.Controls.Add(this.Graph1);
			this.Page2.Location = new System.Drawing.Point(4, 22);
			this.Page2.Name = "Page2";
			this.Page2.Padding = new System.Windows.Forms.Padding(3);
			this.Page2.Size = new System.Drawing.Size(955, 525);
			this.Page2.TabIndex = 1;
			this.Page2.Text = "Основная задача 1";
			this.Page2.UseVisualStyleBackColor = true;
			this.Page2.Click += new System.EventHandler(this.Page2_Click);
			// 
			// TextEpsilon
			// 
			this.TextEpsilon.Location = new System.Drawing.Point(64, 248);
			this.TextEpsilon.Name = "TextEpsilon";
			this.TextEpsilon.Size = new System.Drawing.Size(101, 20);
			this.TextEpsilon.TabIndex = 14;
			this.TextEpsilon.TextChanged += new System.EventHandler(this.TextEpsilon_TextChanged);
			// 
			// LabelEpsilon
			// 
			this.LabelEpsilon.AutoSize = true;
			this.LabelEpsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelEpsilon.Location = new System.Drawing.Point(11, 245);
			this.LabelEpsilon.Name = "LabelEpsilon";
			this.LabelEpsilon.Size = new System.Drawing.Size(50, 25);
			this.LabelEpsilon.TabIndex = 13;
			this.LabelEpsilon.Text = "E = ";
			this.LabelEpsilon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Check
			// 
			this.Check.AutoSize = true;
			this.Check.Location = new System.Drawing.Point(141, 223);
			this.Check.Name = "Check";
			this.Check.Size = new System.Drawing.Size(15, 14);
			this.Check.TabIndex = 12;
			this.Check.UseVisualStyleBackColor = true;
			this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Контроль погрешности";
			// 
			// TextUo
			// 
			this.TextUo.Location = new System.Drawing.Point(65, 191);
			this.TextUo.Name = "TextUo";
			this.TextUo.Size = new System.Drawing.Size(100, 20);
			this.TextUo.TabIndex = 10;
			this.TextUo.TextChanged += new System.EventHandler(this.TextUo_TextChanged);
			// 
			// Uo
			// 
			this.Uo.AutoSize = true;
			this.Uo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Uo.Location = new System.Drawing.Point(8, 186);
			this.Uo.Name = "Uo";
			this.Uo.Size = new System.Drawing.Size(39, 25);
			this.Uo.TabIndex = 9;
			this.Uo.Text = "Uo";
			// 
			// TextStep
			// 
			this.TextStep.Location = new System.Drawing.Point(65, 155);
			this.TextStep.Name = "TextStep";
			this.TextStep.Size = new System.Drawing.Size(100, 20);
			this.TextStep.TabIndex = 8;
			this.TextStep.TextChanged += new System.EventHandler(this.TextStep_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(8, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Шаг";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(10, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "0";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TextMaxX
			// 
			this.TextMaxX.Location = new System.Drawing.Point(100, 117);
			this.TextMaxX.Name = "TextMaxX";
			this.TextMaxX.Size = new System.Drawing.Size(65, 20);
			this.TextMaxX.TabIndex = 5;
			this.TextMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TextMaxX.TextChanged += new System.EventHandler(this.TextMaxX_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(36, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "≤ X < ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Couchy.Properties.Resources.n1;
			this.pictureBox1.Location = new System.Drawing.Point(8, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(252, 87);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Graph1
			// 
			this.Graph1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Graph1.IsShowPointValues = false;
			this.Graph1.Location = new System.Drawing.Point(266, 7);
			this.Graph1.Name = "Graph1";
			this.Graph1.PointValueFormat = "G";
			this.Graph1.Size = new System.Drawing.Size(679, 509);
			this.Graph1.TabIndex = 1;
			// 
			// Page3
			// 
			this.Page3.Controls.Add(this.TextBeta);
			this.Page3.Controls.Add(this.label12);
			this.Page3.Controls.Add(this.TextAlpha);
			this.Page3.Controls.Add(this.label11);
			this.Page3.Controls.Add(this.TextEpsilon1);
			this.Page3.Controls.Add(this.LabelEpsilon1);
			this.Page3.Controls.Add(this.Check1);
			this.Page3.Controls.Add(this.label10);
			this.Page3.Controls.Add(this.TextUoo);
			this.Page3.Controls.Add(this.label9);
			this.Page3.Controls.Add(this.TextUo1);
			this.Page3.Controls.Add(this.label8);
			this.Page3.Controls.Add(this.TextStep1);
			this.Page3.Controls.Add(this.label7);
			this.Page3.Controls.Add(this.TextMaxX1);
			this.Page3.Controls.Add(this.label6);
			this.Page3.Controls.Add(this.label5);
			this.Page3.Controls.Add(this.pictureBox2);
			this.Page3.Controls.Add(this.Graph2);
			this.Page3.Location = new System.Drawing.Point(4, 22);
			this.Page3.Name = "Page3";
			this.Page3.Size = new System.Drawing.Size(955, 525);
			this.Page3.TabIndex = 0;
			this.Page3.Text = "Основная задача 2";
			this.Page3.UseVisualStyleBackColor = true;
			this.Page3.Click += new System.EventHandler(this.Page3_Click);
			// 
			// TextBeta
			// 
			this.TextBeta.Location = new System.Drawing.Point(69, 299);
			this.TextBeta.Name = "TextBeta";
			this.TextBeta.Size = new System.Drawing.Size(100, 20);
			this.TextBeta.TabIndex = 20;
			this.TextBeta.TextChanged += new System.EventHandler(this.TextBeta_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(15, 295);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 25);
			this.label12.TabIndex = 19;
			this.label12.Text = "β";
			// 
			// TextAlpha
			// 
			this.TextAlpha.Location = new System.Drawing.Point(69, 266);
			this.TextAlpha.Name = "TextAlpha";
			this.TextAlpha.Size = new System.Drawing.Size(100, 20);
			this.TextAlpha.TabIndex = 18;
			this.TextAlpha.TextChanged += new System.EventHandler(this.TextAlpha_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(15, 261);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 25);
			this.label11.TabIndex = 17;
			this.label11.Text = "α";
			// 
			// TextEpsilon1
			// 
			this.TextEpsilon1.Location = new System.Drawing.Point(69, 360);
			this.TextEpsilon1.Name = "TextEpsilon1";
			this.TextEpsilon1.Size = new System.Drawing.Size(100, 20);
			this.TextEpsilon1.TabIndex = 16;
			this.TextEpsilon1.TextChanged += new System.EventHandler(this.TextEpsilon1_TextChanged);
			// 
			// LabelEpsilon1
			// 
			this.LabelEpsilon1.AutoSize = true;
			this.LabelEpsilon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelEpsilon1.Location = new System.Drawing.Point(13, 357);
			this.LabelEpsilon1.Name = "LabelEpsilon1";
			this.LabelEpsilon1.Size = new System.Drawing.Size(50, 25);
			this.LabelEpsilon1.TabIndex = 15;
			this.LabelEpsilon1.Text = "E = ";
			// 
			// Check1
			// 
			this.Check1.AutoSize = true;
			this.Check1.Location = new System.Drawing.Point(147, 332);
			this.Check1.Name = "Check1";
			this.Check1.Size = new System.Drawing.Size(15, 14);
			this.Check1.TabIndex = 14;
			this.Check1.UseVisualStyleBackColor = true;
			this.Check1.CheckedChanged += new System.EventHandler(this.Check1_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(17, 332);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Контроль погрешности";
			// 
			// TextUoo
			// 
			this.TextUoo.Location = new System.Drawing.Point(69, 230);
			this.TextUoo.Name = "TextUoo";
			this.TextUoo.Size = new System.Drawing.Size(100, 20);
			this.TextUoo.TabIndex = 12;
			this.TextUoo.TextChanged += new System.EventHandler(this.TextUoo_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(8, 226);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 25);
			this.label9.TabIndex = 11;
			this.label9.Text = "Uo\'";
			// 
			// TextUo1
			// 
			this.TextUo1.Location = new System.Drawing.Point(69, 197);
			this.TextUo1.Name = "TextUo1";
			this.TextUo1.Size = new System.Drawing.Size(100, 20);
			this.TextUo1.TabIndex = 10;
			this.TextUo1.TextChanged += new System.EventHandler(this.TextUo1_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(8, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 25);
			this.label8.TabIndex = 9;
			this.label8.Text = "Uo";
			// 
			// TextStep1
			// 
			this.TextStep1.Location = new System.Drawing.Point(69, 162);
			this.TextStep1.Name = "TextStep1";
			this.TextStep1.Size = new System.Drawing.Size(100, 20);
			this.TextStep1.TabIndex = 8;
			this.TextStep1.TextChanged += new System.EventHandler(this.TextStep1_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(8, 157);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 25);
			this.label7.TabIndex = 7;
			this.label7.Text = "Шаг";
			// 
			// TextMaxX1
			// 
			this.TextMaxX1.Location = new System.Drawing.Point(104, 125);
			this.TextMaxX1.Name = "TextMaxX1";
			this.TextMaxX1.Size = new System.Drawing.Size(65, 20);
			this.TextMaxX1.TabIndex = 6;
			this.TextMaxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TextMaxX1.TextChanged += new System.EventHandler(this.TextMaxX1_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(36, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 25);
			this.label6.TabIndex = 4;
			this.label6.Text = "≤ X <";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Couchy.Properties.Resources.n2;
			this.pictureBox2.Location = new System.Drawing.Point(8, 7);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(187, 96);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// Graph2
			// 
			this.Graph2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Graph2.IsShowPointValues = false;
			this.Graph2.Location = new System.Drawing.Point(266, 7);
			this.Graph2.Name = "Graph2";
			this.Graph2.PointValueFormat = "G";
			this.Graph2.Size = new System.Drawing.Size(679, 509);
			this.Graph2.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(961, 550);
			this.Controls.Add(this.TabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Caushy";
			this.TabControl.ResumeLayout(false);
			this.Page2.ResumeLayout(false);
			this.Page2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Page3.ResumeLayout(false);
			this.Page3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage Page1;
		private System.Windows.Forms.TabPage Page2;
		private ZedGraph.ZedGraphControl Graph1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextMaxX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TextStep;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Uo;
		private System.Windows.Forms.TextBox TextUo;
		private System.Windows.Forms.CheckBox Check;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LabelEpsilon;
		private System.Windows.Forms.TextBox TextEpsilon;
		private System.Windows.Forms.TabPage Page3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private ZedGraph.ZedGraphControl Graph2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TextMaxX1;
		private System.Windows.Forms.TextBox TextEpsilon1;
		private System.Windows.Forms.Label LabelEpsilon1;
		private System.Windows.Forms.CheckBox Check1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox TextUoo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TextUo1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TextStep1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TextBeta;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox TextAlpha;
		private System.Windows.Forms.Label label11;
	}
}

